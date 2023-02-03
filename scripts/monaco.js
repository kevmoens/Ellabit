window.Blazaco = window.Blazaco || {};
window.Blazaco.Editors = [];

window.Blazaco.Editor = {
    InitializeEditor: function (editorId) {
        var el = document.getElementById(editorId);
        if (el) {

            let thisEditor = monaco.editor.create(el, {
                value: ['void Main() {', '\tConsole.WriteLine("Hello world!");', '}'].join('\n'),
                language: 'csharp'
            });
            if (window.Blazaco.Editors.find(e => e.id === editorId)) {
                return false;
            }
            window.Blazaco.Editors.push({ id: editorId, editor: thisEditor });
            return true;
        }
        return false;
    },
    GetValue: function (id) {
        let myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        return myEditor.editor.getValue();
    },
    SetValue: function (id, value) {
        let myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        myEditor.editor.setValue(value);
        return true;
    },
    SetTheme: function (id, theme) {
        let myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        monaco.editor.setTheme(theme);
        return true;
    }
}

//function initEditor() {
//    require.config({ paths: { vs: 'monaco-editor/min/vs' } });
//    require(['vs/editor/editor.main'], function () {
//        var editor = monaco.editor.create(document.getElementById('editor'), {
//            value: ['void Main() {', '\tConsole.WriteLine("Hello world!");', '}'].join('\n'),
//            language: 'csharp'
//        });
        
//    });
//}

