#pragma checksum "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64161894f6a39ba848bd1738349dcf6547591568"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogLoginRecord_List), @"mvc.1.0.view", @"/Views/LogLoginRecord/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LogLoginRecord/List.cshtml", typeof(AspNetCore.Views_LogLoginRecord_List))]
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
#line 1 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
#line 3 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64161894f6a39ba848bd1738349dcf6547591568", @"/Views/LogLoginRecord/List.cshtml")]
    public class Views_LogLoginRecord_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Log_LoginRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/laypage/1.2/laypage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/static/h-ui.admin/js/H-ui.admin.common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(213, 648, true);
            WriteLiteral(@"<nav class=""breadcrumb"">
    <i class=""Hui-iconfont"">&#xe67f;</i> 首页 <span class=""c-gray en"">&gt;</span> 系统管理 <span class=""c-gray en"">&gt;</span> 系统日志 <span class=""c-gray en"">&gt;</span> 列表
    <a id=""btn_refresh"" class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a>
</nav>
<div class=""page-container"">
    <div class=""text-c"">
        日期范围：
        <input type=""text"" onfocus=""WdatePicker({ maxDate:'#F{$dp.$D(\'datemax\')||\'%y-%M-%d\'}' })"" id=""datemin"" name=""datemin"" class=""input-text Wdate"" style=""width:120px;""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 861, "\"", 885, 1);
#line 16 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 869, ViewBag.datemin, 869, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(886, 196, true);
            WriteLiteral(" />\r\n        -\r\n        <input type=\"text\" onfocus=\"WdatePicker({ minDate:\'#F{$dp.$D(\\\'datemin\\\')}\',maxDate:\'%y-%M-%d\' })\" id=\"datemax\" name=\"datemax\" class=\"input-text Wdate\" style=\"width:120px;\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1082, "\"", 1106, 1);
#line 18 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 1090, ViewBag.datemax, 1090, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1107, 199, true);
            WriteLiteral(" />\r\n        <select id=\"clientId\" name=\"clientId\" class=\"select\" style=\"width:100px; height:31px;vertical-align: middle;\">\r\n            <option value=\"\">全部状态</option>\r\n            <option value=\"1\" ");
            EndContext();
            BeginContext(1308, 41, false);
#line 21 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "1" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1350, 45, true);
            WriteLiteral(">Web</option>\r\n            <option value=\"2\" ");
            EndContext();
            BeginContext(1397, 41, false);
#line 22 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "2" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral(">M</option>\r\n            <option value=\"3\" ");
            EndContext();
            BeginContext(1484, 41, false);
#line 23 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "3" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1526, 44, true);
            WriteLiteral(">WX</option>\r\n            <option value=\"4\" ");
            EndContext();
            BeginContext(1572, 41, false);
#line 24 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "4" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1614, 152, true);
            WriteLiteral(">App</option>\r\n        </select>\r\n        <input type=\"text\" class=\"input-text\" style=\"width:350px\" placeholder=\"帐号、姓名、IP地址\" id=\"keyword\" name=\"keyword\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1766, "\"", 1790, 1);
#line 26 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 1774, ViewBag.keyword, 1774, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1791, 554, true);
            WriteLiteral(@" />
        <button type=""submit"" class=""btn btn-success radius"" id=""search"" name=""search"" onclick=""$.mainu.search()""><i class=""Hui-iconfont"">&#xe665;</i> 搜日志</button>
    </div>
    <div class=""cl pd-5 bg-1 bk-gray mt-20"">
        <span class=""l"">
            <a href=""javascript:;"" onclick=""$.mainu.deleteBatch()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 批量删除</a>
            <a href=""javascript:;"" onclick=""$.mainu.deleteAll()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 清空日志</a>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2345, "\"", 2371, 1);
#line 33 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 2352, Url.Action("list"), 2352, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2372, 133, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe667;</i> 日志列表</a>\r\n        </span>\r\n        <span class=\"r\">共有数据：<strong>");
            EndContext();
            BeginContext(2506, 13, false);
#line 35 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2519, 755, true);
            WriteLiteral(@"</strong> 条</span>
    </div>
    <div class=""mt-20"">
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""25""><input type=""checkbox"" name="""" value=""""></th>
                    <th width=""60"">序号</th>
                    <th width=""80"">工号</th>
                    <th width=""80"">姓名</th>
                    <th width=""80"">客户端</th>
                    <th width=""120"">IP地址</th>
                    <th width="""">描述</th>
                    <th width=""70"">结果</th>
                    <th width=""120"">操作时间</th>
                    <th width=""80"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 54 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(3399, 109, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td><input type=\"checkbox\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3508, "\"", 3521, 1);
#line 59 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 3516, m.ID, 3516, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3522, 40, true);
            WriteLiteral("></td>\r\n                            <td>");
            EndContext();
            BeginContext(3563, 4, false);
#line 60 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                           Write(m.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3567, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3608, 55, false);
#line 61 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.Account, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3664, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3705, 56, false);
#line 62 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.NickName, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3762, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3802, 12, false);
#line 63 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                           Write(m.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(3814, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3854, 11, false);
#line 64 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                           Write(m.IpAddress);

#line default
#line hidden
            EndContext();
            BeginContext(3865, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(3920, 13, false);
#line 65 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                          Write(m.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3933, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(3992, 149, false);
#line 66 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                              Write(m.IsResult.ToBool() ? Html.Raw("<span class='label label-success radius'>成功</span>") : Html.Raw("<span class='label label-defaunt radius'>失败</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(4142, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4183, 77, false);
#line 67 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                            Write(m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy-MM-dd HH:mm") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(4261, 124, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n                                <a title=\"删除\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4385, "\"", 4423, 3);
            WriteAttributeValue("", 4395, "$.mainu.delete(this,\'", 4395, 21, true);
#line 69 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 4416, m.ID, 4416, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 4421, "\')", 4421, 2, true);
            EndWriteAttribute();
            BeginContext(4424, 117, true);
            WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 72 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4583, 120, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"pt-30\" style=\"width:100%; height:60px;\"></div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4782, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(4816, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4414e900eea49acb308100bece94cec", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4908, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4914, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55e118e18b9e426db878e1f95eff709e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5015, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5021, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8282e986c904ba09eb1dcaff13ee909", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5102, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5108, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06c11ff95bcb4c3b9ae891f3592fd2c3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5204, 1849, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
            (function ($) {
                $.mainu = {
                    init: function () {
                        $('.table-sort').dataTable({
                            ""aaSorting"": [[1, ""desc""]],//默认第几个排序
                            ""bStateSave"": true,//状态保存
                            ""aoColumnDefs"": [
                              { ""orderable"": false, ""aTargets"": [0, 9] }// 制定列不参与排序
                            ],
                            ""aLengthMenu"": [10, 25, 50, 100]
                        });
                    },
                    search: function () {
                        var dateMin = $(""input[name='datemin']"").val();
                        var dateMax = $(""input[name='datemax']"").val();
                        var clientId = $(""select[name='clientId']"").val();
                        var keyword = $(""input[name='keyword']"").val();
                        if (keyword == """") {
                            if (dateMin == """" ||");
                WriteLiteral(@" dateMax == """") {
                                layer.alert('日期范围不能空', { icon: 5 });
                                return;
                            }
                        }
                        var params = {
                            dateMin: dateMin,
                            dateMax: dateMax,
                            clientId: clientId,
                            keyword: keyword
                        };
                        var url = ""?"" + urlEncodes(params);
                        window.location.href = url;
                    },
                    delete: function (obj, id) {
                        layer.confirm('确认要删除吗？', function (index) {
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(7054, 20, false);
#line 127 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                 Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(7074, 1858, true);
                WriteLiteral(@"',
                                data: { id: id },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;
                                    var message = result.message;
                                    if (state == ""success"") {
                                        $(obj).parents(""tr"").remove();
                                        layer.msg('已删除!', { icon: 1, time: 1000 });
                                    } else {
                                        layer.msg(message, { icon: 5, time: 1000 });
                                    }
                                },
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""系统错误！"", { icon: 5 });
                                    }
                  ");
                WriteLiteral(@"              }
                            });
                        });
                    },
                    deleteBatch: function () {
                        layer.confirm('确认要删除吗？', function (index) {
                            var arrId = [];
                            $(""input:checkbox[name='id']:checked"").each(function () {
                                //alert($(this).val());
                                arrId.push($(this).val());
                            });
                            if (arrId.length == 0) {
                                layer.msg('请选择需要删除日志！', { icon: 5, time: 2000 });
                                return;
                            }
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(8933, 25, false);
#line 161 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                 Write(Url.Action("DeleteBatch"));

#line default
#line hidden
                EndContext();
                BeginContext(8958, 1338, true);
                WriteLiteral(@"',
                                data: { arrid: arrId },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;          //错误代码
                                    var message = result.message;        //错误说明
                                    if (state == ""success"") {
                                        window.location.replace(location.href);
                                    } else {
                                        layer.msg(message, { icon: 5, time: 1000 });
                                    }
                                },
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""系统错误！"", { icon: 5 });
                                    }
                                }
                       ");
                WriteLiteral(@"     });
                        });
                    },
                    deleteAll: function () {
                        layer.confirm('确认要清空系统日志吗？保留最近三天日志。', function (index) {
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(10297, 23, false);
#line 185 "G:\蓝点管理信息系统-开源版ASP.NET CORE\LdCms\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                 Write(Url.Action("DeleteAll"));

#line default
#line hidden
                EndContext();
                BeginContext(10320, 1230, true);
                WriteLiteral(@"',
                                data: { id: 0 },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;          //错误代码
                                    var message = result.message;        //错误说明
                                    if (state == ""success"") {
                                        window.location.replace(location.href);
                                    } else {
                                        layer.msg(message, { icon: 5, time: 1000 });
                                    }
                                },
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""系统错误！"", { icon: 5 });
                                    }
                                }
                            })");
                WriteLiteral(";\r\n                        });\r\n                    }\r\n                };\r\n                $(function () {\r\n                    $.mainu.init();\r\n                });\r\n            })(jQuery);\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(11553, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Log_LoginRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
