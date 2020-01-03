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

//layui表格 删除、修改事件
function DelbookLayui(data) {
    var json = JSON.parse(data);

    if (json.state == 1) {

        if (wlimits - 1 == 0) {
            wpage -= 1;
        }

        //删除后对table进行重载
        layui.use('table', function () {
            var table = layui.table;

            table.reload('testTable', {
                page: {
                    curr: wpage
                },
                where: {
                    empty: "无意义"
                }
            }, 'data');
        });

        layer.alert(json.msg, { icon: 6 });
    }
    else {
        layer.alert(json.msg, { icon: 5 });
    }
}

//给表格赋值数据， 赋值未知数据
function LayuiTable() {

    layui.use('table', function () {
        var table = layui.table;

        //展示已知数据
        var wst = table.render({
            elem: '#demo'
            , id: 'testTable'
            , cols: [[ //标题栏
                { type: 'checkbox', fixed: 'left' }
                , { field: 'BookId', title: 'ID', width: 60, sort: true, fixed: 'left' }
                , { field: 'BookName', title: '书名', width: 150 }
                , { field: 'Author', title: '作者', minWidth: 150 }
                , { field: 'Price', title: '价格', minWidth: 100, sort: true }
                , { field: 'Publishing', title: '出版社', width: 150 }
                , { fixed: 'right', title: '操作', toolbar: '#barDemo', width: 150 }
            ]]
            , response: {
                statusName: 'state' //规定数据状态的字段名称，默认：code
                , statusCode: 100 //规定成功的状态码，默认：0
                //,msgName: 'hint' //规定状态信息的字段名称，默认：msg
                //,countName: 'total' //规定数据总数的字段名称，默认：count
                //,dataName: 'rows' //规定数据列表的字段名称，默认：data
            }
            , url: 'Getbooklayui'
            , method: 'get'
            , parseData: function (res) { //res 即为原始返回的数据
                return {
                    "state": res.state, //解析接口状态
                    "msg": res.msg, //解析提示文本
                    "count": res.count, //解析数据长度
                    "data": res.data //解析数据列表(res:json字符串格式)
                };
            }
            , even: true  //隔行背景
            , page: true //是否显示分页
            , limit: 10 //每页默认显示的数量
            , limits: [5, 10, 15, 20]
            , width: 800
            , height: 500
            , done: function (res, curr, count) {
                //如果是异步请求数据方式，res即为你接口返回的信息。
                //如果是直接赋值的方式，res即为：{data: [], count: 99} data为当前页数据、count为数据总长度

                wlimits = res.data.length;  //每页的具体行数

                wpage = curr;  //当前页码
            }
        });

        //wst.config.limit;  //默认每页行数
    });

    
}