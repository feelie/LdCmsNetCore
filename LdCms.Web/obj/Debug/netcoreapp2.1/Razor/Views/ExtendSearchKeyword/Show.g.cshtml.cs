#pragma checksum "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755ac3f7bb031512f3af38c409cf5358501247d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExtendSearchKeyword_Show), @"mvc.1.0.view", @"/Views/ExtendSearchKeyword/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ExtendSearchKeyword/Show.cshtml", typeof(AspNetCore.Views_ExtendSearchKeyword_Show))]
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
#line 1 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
#line 4 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
using LdCms.Common.Enum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755ac3f7bb031512f3af38c409cf5358501247d8", @"/Views/ExtendSearchKeyword/Show.cshtml")]
    public class Views_ExtendSearchKeyword_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ld_Extend_SearchKeyword>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
  
    ViewData["Title"] = "Show";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(231, 401, true);
            WriteLiteral(@"
<article class=""page-container"">
    <div>
        <div style=""height:32px;line-height:32px;"">基本信息：</div>
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <tbody>
                <tr>
                    <td class=""text-r"" style=""background-color:#f5fafe;"" width=""200"">关建字：</td>
                    <td class=""text-l"" width="""" colspan=""3"">");
            EndContext();
            BeginContext(633, 13, false);
#line 18 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                                       Write(Model.Keyword);

#line default
#line hidden
            EndContext();
            BeginContext(646, 200, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"text-r\" style=\"background-color:#f5fafe;\" width=\"200\">会员ID：</td>\r\n                    <td class=\"text-l\" width=\"35%\">");
            EndContext();
            BeginContext(847, 14, false);
#line 22 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                              Write(Model.MemberID);

#line default
#line hidden
            EndContext();
            BeginContext(861, 151, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-r\" style=\"background-color:#f5fafe;\" width=\"200\">客户端：</td>\r\n                    <td class=\"text-l\" width=\"\">");
            EndContext();
            BeginContext(1013, 16, false);
#line 24 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 196, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"text-r\" style=\"background-color:#f5fafe;\" width=\"200\">总次数：</td>\r\n                    <td class=\"text-l\" width=\"\">");
            EndContext();
            BeginContext(1226, 18, false);
#line 28 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                           Write(Model.Hits.ToInt());

#line default
#line hidden
            EndContext();
            BeginContext(1244, 152, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-r\" style=\"background-color:#f5fafe;\" width=\"200\">是否置顶：</td>\r\n                    <td class=\"text-l\" width=\"\">");
            EndContext();
            BeginContext(1398, 28, false);
#line 30 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                            Write(Model.IsTop.ToBool()?"是":"否");

#line default
#line hidden
            EndContext();
            BeginContext(1427, 197, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"text-r\" style=\"background-color:#f5fafe;\" width=\"200\">IP地址：</td>\r\n                    <td class=\"text-l\" width=\"\">");
            EndContext();
            BeginContext(1625, 15, false);
#line 34 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                           Write(Model.IpAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 150, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-r\" style=\"background-color:#f5fafe;\" width=\"200\">时间：</td>\r\n                    <td class=\"text-l\" width=\"\">");
            EndContext();
            BeginContext(1791, 54, false);
#line 36 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                           Write(Model.CreateDate.ToDate().ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 655, true);
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
    </div>
    <div>
        <div style=""height:32px;line-height:32px;"">新数据：</div>
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""80"">客户端</th>
                    <th width=""100"">会员ID</th>
                    <th width="""">关键字</th>
                    <th width=""110"">IP地址</th>
                    <th width=""80"">置顶</th>
                    <th width=""120"">加入时间</th>
                </tr>
            </thead>
            <tbody id=""lists"">
");
            EndContext();
#line 55 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                 foreach (var m in ViewData["list"] as List<Ld_Extend_SearchKeyword>)
                {

#line default
#line hidden
            BeginContext(2606, 69, true);
            WriteLiteral("                    <tr class=\"text-c\">\r\n                        <td>");
            EndContext();
            BeginContext(2676, 12, false);
#line 58 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                       Write(m.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(2688, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2724, 10, false);
#line 59 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                       Write(m.MemberID);

#line default
#line hidden
            EndContext();
            BeginContext(2734, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-l\">");
            EndContext();
            BeginContext(2785, 9, false);
#line 60 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                      Write(m.Keyword);

#line default
#line hidden
            EndContext();
            BeginContext(2794, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2830, 11, false);
#line 61 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                       Write(m.IpAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2841, 53, true);
            WriteLiteral("</td>\r\n                        <td class=\"td-status\">");
            EndContext();
            BeginContext(2896, 144, false);
#line 62 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                                          Write(m.IsTop.ToBool() ? Html.Raw("<span class='label label-success radius'>是</span>") : Html.Raw("<span class='label label-defaunt radius'>否</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(3041, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3078, 50, false);
#line 63 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                        Write(m.CreateDate.ToDate().ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(3129, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 65 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\ExtendSearchKeyword\Show.cshtml"
                }

#line default
#line hidden
            BeginContext(3182, 130, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"pt-30\" style=\"width:100%; height:60px;\"></div>\r\n</article>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ld_Extend_SearchKeyword> Html { get; private set; }
    }
}
#pragma warning restore 1591
