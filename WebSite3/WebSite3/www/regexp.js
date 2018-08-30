
 function ifIndex (_index) {
     if (!/^[1-9]\d*$/.test(_index.value)) {
        alert("请输入正确序号");
        _index.value = "";
        return false;
    }
};
function reg(arr) {
    var arr2 = [];
    for (var i = 0; i < arr.length; i++) {
        arr2.push(/0|(^\s*)|(\s*$)|^\d+(\.\d{1,2})?$/.test(arr[i].value));
    }
    console.log(arr2);
    for (var i = 0; i < arr2.length; i++) {
        if (arr2[i] == false) {
            arr[i].value = "";
        }
        alert("请输入有效数字");
        return false;
    }
            
}