//异步请求
function ajax(APItype, FileAddress, jsondata, Bookfunction) {
    $.ajax({
        type: APItype,
        url: FileAddress,
        data: jsondata,
        success: Bookfunction,
        error: function (xhr) {
            layer.alert(xhr.statusText, { icon: 5 });
        }
    });
}

//绑定数据到table
function Book_List(data) {
    var json = JSON.parse(data);

    $("#Book").bootstrapTable({
        data: json
    });

    //alldata = [];

    for (var i = 0; i < json.length; i++) {
        alldata.push(json[i]);
    }
}

//重载表格
function Bookload(data) {
    var json = JSON.parse(data);

    $("#Book").bootstrapTable('load', json);

    //alldata = [];

    for (var i = 0; i < json.length; i++) {
        alldata.push(json[i]);
    }
}

//删除
function Deletebook(data) {
    var json = JSON.parse(data);

    if (json.state == 1) {

        Bookfunction = Bookload;
        Getbook(Bookfunction);

        layer.alert(json.msg, { icon: 6 });

    }
    else {
        layer.alert(json.msg, { icon: 5 });
    }
}

//修改页面，绑定数据
function GetUpdateBook(data) {
    var json = JSON.parse(data);

    if (json.state == 0) {
        layer.alert(json.msg, { icon: 5 });
    }
    else {
        jsonID = json[0].BookId;
        jsonBookName = json[0].BookName;
        jsonAuthor = json[0].Author;
        jsonPrice = json[0].Price;
        jsonPub = json[0].Publishing;

        $("#ID").val(jsonID);
        $("#BookName").val(jsonBookName);
        $("#Author").val(jsonAuthor);
        $("#Price").val(jsonPrice);
        $("#Publishing").val(jsonPub);
    }
}

//修改
function AlterBook(data) {
    var json = JSON.parse(data);

    if (json.state == 1) {
        layer.alert(json.msg, { icon: 6 });  //弹出框，提示操作成功

        //三秒后关闭窗口
        setTimeout(function () {
            var layerindex = parent.layer.getFrameIndex(window.name);
            parent.layer.close(layerindex);

        }, 3000);
    }
    else {
        layer.alert(json.msg, { icon: 5 });
    }
}