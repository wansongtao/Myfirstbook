#pragma checksum "C:\MyFirstBook\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad109ef080c6883a0a71ff6dd5d6a20fdbce3bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MyFirstBook\Views\_ViewImports.cshtml"
using MyFirstBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyFirstBook\Views\_ViewImports.cshtml"
using MyFirstBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad109ef080c6883a0a71ff6dd5d6a20fdbce3bc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246be813015db6334474d750d8aad710c72408a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/jQuery/jquery-3.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\MyFirstBook\Views\Home\Index.cshtml"
  

    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad109ef080c6883a0a71ff6dd5d6a20fdbce3bc5174", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n");
                WriteLiteral(@"    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <title>book</title>
    <link rel=""stylesheet"" type=""text/css"" href=""../../Content/layui/css/layui.css"" />

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad109ef080c6883a0a71ff6dd5d6a20fdbce3bc5792", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad109ef080c6883a0a71ff6dd5d6a20fdbce3bc6891", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad109ef080c6883a0a71ff6dd5d6a20fdbce3bc8694", async() => {
                WriteLiteral("\r\n\r\n    <fieldset class=\"layui-elem-field layui-field-title\" style=\"margin-top: 20px;\">\r\n        <legend>书籍信息</legend>\r\n    </fieldset>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad109ef080c6883a0a71ff6dd5d6a20fdbce3bc9107", async() => {
                    WriteLiteral(@"

        <div class=""layui-form-item"">

            <div class=""layui-inline"">
                <label class=""layui-form-label"">ID：</label>
                <div class=""layui-input-inline"">
                    <input type=""number"" id=""ID"" name=""ID"" lay-verify=""required"" placeholder=""请输入要查询书籍的ID"" autocomplete=""off"" class=""layui-input"">
                </div>
                <button type=""button"" id=""Inquire"" class=""layui-btn layui-btn-radius layui-btn-normal"">查询</button>
                <button type=""button"" id=""Del"" class=""layui-btn layui-btn-radius layui-btn-danger"">删除</button>
            </div>

        </div>

        <div class=""layui-form-item"">
            <div class=""layui-inline"">
                <label class=""layui-form-label"">书名：</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" id=""BookName"" name=""BookName"" lay-verify=""required"" autocomplete=""off"" class=""layui-input"">
                </div>
            </div>
        </div>

    ");
                    WriteLiteral(@"    <div class=""layui-form-item"">
            <div class=""layui-inline"">
                <label class=""layui-form-label"">作者：</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" id=""Author"" name=""Author"" lay-verify=""required"" autocomplete=""off"" class=""layui-input"">
                </div>
            </div>
        </div>

        <div class=""layui-form-item"">
            <div class=""layui-inline"">
                <label class=""layui-form-label"">价格：</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" id=""Price"" name=""Price"" lay-verify=""required"" autocomplete=""off"" class=""layui-input"">
                </div>
            </div>
        </div>

        <div class=""layui-form-item"">
            <div class=""layui-inline"">
                <label class=""layui-form-label"">出版社：</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" id=""Publishing"" name=""Publishing"" lay-ve");
                    WriteLiteral("rify=\"required\" autocomplete=\"off\" class=\"layui-input\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
                    WriteLiteral(@"
        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <button type=""button"" id=""Add"" class=""layui-btn layui-btn-radius layui-btn-danger"">添加</button>
                <button type=""button"" id=""Update"" class=""layui-btn layui-btn-radius layui-btn-danger"">修改</button>
                <button type=""reset"" class=""layui-btn layui-btn-radius layui-btn-danger"">重置</button>

                <button type=""button"" id=""JumpToPage"" class=""layui-btn layui-btn-radius layui-btn-danger"">跳转页面</button>
            </div>
        </div>

    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    
    <script>
        $(document).ready(function () {

            //根据ID查询书籍信息
            $(""#Inquire"").on(""click"", function () {

                var id = $(""#ID"").val();

                if (id != null && id != """") {

                    $.ajax({
                        type: ""GET"",
                        url: ""Home/GetBook"",
                        data: { id: id },
                        success: function (data) {
                            var json = JSON.parse(data);  //将json字符串转换为json对象

                            /*//json数组类型字符串取值
                            for(var i=0;i<json.length;i++){
                                alert(json[i].id);  //取json中的值
                            }*/

                            if (json.state == 0) {

                                layui.use('layer', function(){
                                    var layer = layui.layer;
                                    layer.alert(json.msg, {icon: 5});
                                });");
                WriteLiteral(@"                                 
                            }
                            else {
                                //$(""#all"").val(data);
                                $(""#BookName"").val(json[0].BookName);
                                $(""#Author"").val(json[0].Author);
                                $(""#Price"").val(json[0].Price);
                                $(""#Publishing"").val(json[0].Publishing);
                            }
                        }
                    });
                }
                else {
                    layui.use('layer', function () {
                        var layer = layui.layer;
                        layer.alert('请先输入您要查询的ID', { icon: 5 });
                    }); 
                    
                }
            });

            //根据ID修改书籍信息
            $(""#Update"").on(""click"", function () {

                var ID = $(""#ID"").val();
                var BookName = $(""#BookName"").val();
                var Author = $");
                WriteLiteral(@"(""#Author"").val();
                var Price = $(""#Price"").val();
                var Publishing = $(""#Publishing"").val();

                if (ID != """" && BookName != """" && Author != """"
                    && Price != """" && Publishing != """") {

                    var jsondata = {
                        ID: ID, BookName: BookName, Author: Author,
                        Price: Price, Publishing: Publishing
                    };

                    $.ajax({
                        type:""PUT"",
                        url: ""Home/PutBook"",
                        data: jsondata,
                        success: function (data) {
                            var json = JSON.parse(data);

                            if (json.state == 1) {
                                //成功                                
                                layui.use('layer', function(){
                                    var layer = layui.layer;
                                    layer.alert(json.msg, { ic");
                WriteLiteral(@"on: 6 });
                                });
                            }
                            else {
                                //失败
                                layui.use('layer', function(){
                                    var layer = layui.layer;
                                    layer.alert(json.msg, { icon: 5 });
                                });
                                
                            }
                        }
                    });
                }
                else {
                    
                    layui.use('layer', function () {
                        var layer = layui.layer;
                        layer.alert('所有信息都不能为空', { icon: 5 });
                    });
                }
            });

            //增加书籍信息
            $(""#Add"").on(""click"", function () {

                var ID = $(""#ID"").val();
                var BookName = $(""#BookName"").val();
                var Author = $(""#Author"").val();
   ");
                WriteLiteral(@"             var Price = $(""#Price"").val();
                var Publishing = $(""#Publishing"").val();

                if (ID != """" && BookName != """" && Author != """"
                    && Price != """" && Publishing != """") {

                    var jsondata = {
                        ID: ID, BookName: BookName, Author: Author,
                        Price: Price, Publishing: Publishing
                    };

                    $.ajax({
                        type: ""POST"",
                        url: ""Home/AddBookone"",
                        data: jsondata,
                        success: function (data) {

                            var json = JSON.parse(data);

                            if (json.state == 1) {
                                layui.use('layer', function(){
                                    var layer = layui.layer;
                                    layer.alert(json.msg, { icon: 6 });
                                });
                            }
       ");
                WriteLiteral(@"                     else {
                                layui.use('layer', function(){
                                    var layer = layui.layer;
                                    layer.alert(json.msg, { icon: 5 });
                                });
                            }
                        }
                    });
                }
                else {
                    
                    layui.use('layer', function () {
                        var layer = layui.layer;
                        layer.alert('请输入所有书籍有关信息', { icon: 5 });
                    });
                }

            });

            //根据ID删除书籍信息
            $(""#Del"").on(""click"", function () {

                var id = $(""#ID"").val();

                if (id != """") {
                    $.ajax({
                        type: ""DELETE"",
                        url: ""Home/DeleteBookOne"",
                        data: { id: id },
                        success: function (data) {
    ");
                WriteLiteral(@"                        var json = JSON.parse(data);

                            if (json.state == 1) {
                                layui.use('layer', function(){
                                    var layer = layui.layer;
                                    layer.alert(json.msg, { icon: 6 });
                                });
                            }
                            else {
                                layui.use('layer', function(){
                                    var layer = layui.layer;
                                    layer.alert(json.msg, { icon: 5 });
                                });
                            }
                        }
                    });
                }
                else {
                    
                    layui.use('layer', function () {
                        var layer = layui.layer;
                        layer.alert('请输入您要删除书籍信息的ID', { icon: 5 });
                    });
                }
            ");
                WriteLiteral("});\r\n\r\n            //跳转页面\r\n            $(\"#JumpToPage\").on(\"click\", function () {\r\n                window.location.href = \"Home/Bookview\";\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
