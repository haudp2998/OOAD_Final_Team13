#pragma checksum "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cdb317880ff1fa7cb7b9f5b1d3614a5b08198b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhaCungCaps_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/NhaCungCaps/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NhaCungCaps/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_NhaCungCaps_Details))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cdb317880ff1fa7cb7b9f5b1d3614a5b08198b0", @"/Areas/Admin/Views/NhaCungCaps/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NhaCungCaps_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCore_Final.Models.NhaCungCap>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 127, true);
            WriteLiteral("\r\n<h2>Chi tiết</h2>\r\n\r\n<div>\r\n    <h4>Nhà cung cấp</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(272, 45, false);
#line 15 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenCongTy));

#line default
#line hidden
            EndContext();
            BeginContext(317, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(361, 41, false);
#line 18 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenCongTy));

#line default
#line hidden
            EndContext();
            BeginContext(402, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(446, 41, false);
#line 21 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(487, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(531, 37, false);
#line 24 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(568, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(612, 45, false);
#line 27 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(657, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(701, 41, false);
#line 30 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(786, 42, false);
#line 33 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(828, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(872, 38, false);
#line 36 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(954, 40, false);
#line 39 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(994, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1038, 36, false);
#line 42 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
       Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1121, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d65c99afd474cfd87ddd39f1db16fbb", async() => {
                BeginContext(1194, 3, true);
                WriteLiteral("Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhaCungCaps\Details.cshtml"
                           WriteLiteral(Model.MaNcc);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1201, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1209, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cea2df0ed0946518e65101c73c2ea67", async() => {
                BeginContext(1255, 7, true);
                WriteLiteral("Trở lại");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1266, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCore_Final.Models.NhaCungCap> Html { get; private set; }
    }
}
#pragma warning restore 1591