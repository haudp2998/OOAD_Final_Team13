#pragma checksum "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37b8038b666e1fcfcb73ade7ef4be8caf354eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Loais_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Loais/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Loais/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Loais_Index))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 3 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37b8038b666e1fcfcb73ade7ef4be8caf354eaf", @"/Areas/Admin/Views/Loais/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Loais_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.Loai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(247, 105, true);
            WriteLiteral("\r\n<div class=\"outer-w3-agile mt-3\">\r\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách Loại HH</h4>\r\n    ");
            EndContext();
            BeginContext(352, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35214faaab23467a8b0240d584b62739", async() => {
                BeginContext(391, 81, true);
                WriteLiteral("\r\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 472, "\"", 529, 1);
#line 14 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
WriteAttributeValue("", 496, Model.RouteValue["searchString"], 496, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(530, 169, true);
                WriteLiteral(" />\r\n        <button type=\"submit\" class=\"btn btn-info\">\r\n            <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span> Search\r\n        </button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(706, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(725, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d99429ce88547b297e4fc270c299836", async() => {
                BeginContext(772, 7, true);
                WriteLiteral("Tạo mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(783, 128, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(912, 44, false);
#line 26 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(956, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1036, 43, false);
#line 29 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1242, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1261, "\"", 1301, 4);
            WriteAttributeValue("", 1271, "_delete(\'", 1271, 9, true);
#line 37 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
WriteAttributeValue("", 1280, item.MaLoai, 1280, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1292, "\',", 1292, 2, true);
            WriteAttributeValue(" ", 1294, "event)", 1295, 7, true);
            EndWriteAttribute();
            BeginContext(1302, 96, true);
            WriteLiteral(" >\r\n                    <td scope=\"row\">\r\n                        \r\n                        <a> ");
            EndContext();
            BeginContext(1399, 46, false);
#line 40 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                       Write(Html.Raw(item.GioiTinh == true ? "Nam" : "Nữ"));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 96, true);
            WriteLiteral("</a> \r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1542, 42, false);
#line 43 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1675, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a939c3d4db4e93915bb10beb85a4a8", async() => {
                BeginContext(1724, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                                               WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1732, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1760, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "676336129e4b41a692364e0ce261f698", async() => {
                BeginContext(1812, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                                                  WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1823, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1851, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2fb4c9ffd9411cb49daab6a52b197e", async() => {
                BeginContext(1902, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                                                 WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1912, 150, true);
            WriteLiteral(" |\r\n                        <button type=\"button\" class=\"btn btn-primary btn-delete\" >Xóa</button>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2077, 1121, true);
            WriteLiteral(@"        </tbody>
    </table>
    <script>
        function _delete(id, ev) {
            if (ev.target.className == 'btn btn-primary btn-delete') {
                console.log(ev.target);
                console.log(ev.currentTarget);
                var cf = confirm('Bạn có muốn xoá loại HH ID: ' + id + '?');
                if (cf) {
                    $(ev.currentTarget).fadeOut();
                    $.ajax({
                        url: '/api/Loais/' + id,
                        type: ""Delete"",
                        contentType: ""application/json; charset=utf-8"",
                        dataType: ""json"",
                        async: true,
                        success: function (result) {
                            alert(""Xoá loại HH thành công"");
                        },
                        error: function (errormessage) {
                            alert(errormessage.responseText);
                        }
                    });
                }
            }");
            WriteLiteral("\r\n        }\r\n    </script>\r\n    <nav class=\"navbar-default justify-content-center\">\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(3199, 135, false);
#line 83 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(3334, 24, true);
            WriteLiteral("\r\n\r\n\r\n    </nav>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.Loai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
