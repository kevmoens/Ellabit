var workspace;
export function initialize(toolbox) {
    if (toolbox) {
        workspace = Blockly.inject('blocklyDiv', {
            media: 'media/',
            toolbox: toolbox
        });
    } else {
        workspace = Blockly.inject('blocklyDiv', {
            media: 'media/',
            toolbox: document.getElementById('toolbox')
        });
    }

    Blockly.Xml.domToWorkspace(document.getElementById('defaultProgram'), workspace);
}

export async function evalProgram() {
    setOutput("");
    var xml = Blockly.Xml.workspaceToDom(workspace);
    var xmlText = new XMLSerializer().serializeToString(xml);
    return await send(xmlText, setOutput);
}

export function setOutput(value) {
    return value;
    //document.getElementById("output").innerText = value;
}

export async function send(payload, cb) {
    var result = await DotNet.invokeMethodAsync('Ellabit', 'Evaluate', payload);
        //.catch(err => console.error(err));
    return result;
}

export function setBlocks(value) {
    var xmlDom = null;
    try {
        xmlDom = Blockly.Xml.textToDom(value);
    } catch (e) {
        console.log(e);
    }
    if (xmlDom) {
        workspace.clear();
        Blockly.Xml.domToWorkspace(xmlDom, workspace);
    }

    Blockly.Xml.textToDom(value);
}

export function getBlockXml() {
    var xmlDom = Blockly.Xml.workspaceToDom(Blockly.mainWorkspace);
    return Blockly.Xml.domToPrettyText(xmlDom);
}