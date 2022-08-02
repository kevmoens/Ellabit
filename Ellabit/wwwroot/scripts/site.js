function registerProviders(dotnetHelper) {

    window.monaco.languages.registerCompletionItemProvider("csharp", {
        triggerCharacters: ["."],
        // this signature is outdated, actually it is resolveCompletionItem: (item, token)
        // https://github.com/microsoft/vscode/commit/ce850e02d56cd3ff5b5a93ce23c2272d3bac0fa2
        resolveCompletionItem: (model, position, item) => {
            return resolveCompletionItem(item, dotnetHelper)
        },
        provideCompletionItems: (model, position, context) => {
            return provideCompletionItems(model, position, context, dotnetHelper)
        }
    });

    window.monaco.languages.registerSignatureHelpProvider("csharp", {
        signatureHelpTriggerCharacters: ['('],
        provideSignatureHelp: (model, position) => {
            return provideSignatureHelp(model, position, dotnetHelper)
        }
    });
}

let _lastCompletions;

async function provideCompletionItems(model, position, context, dotnetHelper) {
    let request = this._createRequest(position);
    request.CompletionTrigger = (context.triggerKind + 1);
    request.TriggerCharacter = context.triggerCharacter;

    try {
        const code = model.getValue();
        const response = await dotnetHelper.invokeMethodAsync("GetCompletionAsync", code, request);
        const mappedItems = response.items.map(this._convertToVscodeCompletionItem);

        let lastCompletions = new Map();

        for (let i = 0; i < mappedItems.length; i++) {
            lastCompletions.set(mappedItems[i], response.items[i]);
        }

        this._lastCompletions = lastCompletions;

        return { suggestions: mappedItems };
    }
    catch (error) {
        return;
    }
}

async function resolveCompletionItem(item, dotnetHelper) {
    const lastCompletions = this._lastCompletions;
    if(!lastCompletions) {
        return item;
    }

    const lspItem = lastCompletions.get(item);
    if(!lspItem) {
        return item;
    }

    const request = { Item: lspItem };
    try {
        const response = await dotnetHelper.invokeMethodAsync("GetCompletionResolveAsync", request);
        return this._convertToVscodeCompletionItem(response.item);
    }
        catch(error) {
        return;
    }
}

async function provideSignatureHelp(model, position, dotnetHelper) {

    let req = _createRequest(position);

    try {
        let code = model.getValue();
        let res = await dotnetHelper.invokeMethodAsync("GetSignatureHelpAsync", code, req);

        if (!res) {
            return undefined;
        }

        let ret = {
            signatures: [],
            activeSignature: res.activeSignature,
            activeParameter: res.activeParameter
        }

        for (let signature of res.signatures) {

            let signatureInfo = {
                label: signature.label,
                documentation: signature.structuredDocumentation.summaryText,
                parameters: []
            }

            ret.signatures.push(signatureInfo);

            for (let parameter of signature.parameters) {
                let parameterInfo = {
                    label: parameter.label,
                    documentation: this._getParameterDocumentation(parameter)
                }

                signatureInfo.parameters.push(parameterInfo);
            }
        }

        return {
            value: ret,
            dispose: () => { }
        }
    }
    catch (error) {
        return undefined;
    }
}

function setDiagnostics(diagnostics, uri) {

    var model = monaco.editor.getModel(uri)

    diagnostics.forEach(diagnostic => {
        diagnostic.startLineNumber = diagnostic.start.line + 1;
        diagnostic.startColumn = diagnostic.start.character + 1;

        diagnostic.endLineNumber = diagnostic.end.line + 1;
        diagnostic.endColumn = diagnostic.end.character + 1;
    });

    window.monaco.editor.setModelMarkers(model, "owner", diagnostics);
}

function _getParameterDocumentation(parameter) {
    let summary = parameter.documentation;
    if (summary.length > 0) {
        let paramText = `**${parameter.name}**: ${summary}`;
        return {
            value: paramText
        };
    }

    return "";
}

function _convertToVscodeCompletionItem(omnisharpCompletion) {
    const docs = omnisharpCompletion.documentation;

    const mapRange = function (edit) {
        const newStart = {
            lineNumber: edit.startLine + 1,
            column: edit.startColumn + 1
        };
        const newEnd = {
            lineNumber: edit.endLine + 1,
            column: edit.endColumn + 1
        };
        return {
            startLineNumber: newStart.lineNumber,
            startColumn: newStart.column,
            endLineNumber: newEnd.lineNumber,
            endColumn: newEnd.column
        };
    };

    const mapTextEdit = function (edit) {
        return new TextEdit(mapRange(edit), edit.NewText);
    };

    const additionalTextEdits = omnisharpCompletion.additionalTextEdits?.map(mapTextEdit);

    const newText = omnisharpCompletion.textEdit?.newText ?? omnisharpCompletion.insertText;
    const insertText = newText;

    const insertRange = omnisharpCompletion.textEdit ? mapRange(omnisharpCompletion.textEdit) : undefined;

    return {
        label: omnisharpCompletion.label,
        kind: omnisharpCompletion.kind - 1,
        detail: omnisharpCompletion.detail,
        documentation: {
            value: docs
        },
        commitCharacters: omnisharpCompletion.commitCharacters,
        preselect: omnisharpCompletion.preselect,
        filterText: omnisharpCompletion.filterText,
        insertText: insertText,
        range: insertRange,
        tags: omnisharpCompletion.tags,
        sortText: omnisharpCompletion.sortText,
        additionalTextEdits: additionalTextEdits,
        keepWhitespace: true
    };
}

function _createRequest(position) {

    let Line, Column;
    
    Line = position.lineNumber - 1;
    Column = position.column - 1;

    let request = {
        Line,
        Column
    };

    return request;
}