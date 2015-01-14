// JScript 文件

function SelectAll(sel) {
    var obj = document.getElementsByName("checkboxid");
    for (var i = 0; i < obj.length; i++) {
        obj[i].checked = sel;
    }
}

function CheckSelect() {
    var flag = false;
    var obj = document.getElementsByName("checkboxid");
    if (obj.length == 0) {
        alert("你未选择任何项,请至少选择一项.");
        return false;
    }
    for (var i = 0; i < obj.length; i++) {
        if (obj[i].checked) {
            flag = true;
            break;
        }
    }
    if (flag) {
        if (confirm("确认对所选项进行操作?")) {
            return true;
        }
        else {
            return false;
        }
    }
    else {
        alert("你未选择任何项,请至少选择一项.");
        return false;
    }
}