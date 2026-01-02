
function moveEditor(id, newParent) {
    var editor = document.getElementById(id);
    if (!editor) {
        alert("editor empty");
    }
    var par = document.getElementById(newParent);
    if (!par) {
        alert("parent empty");
    }
    par.appendChild(editor);
}


function ClearEditors () {
    window.Blazaco.Editors = [];
}