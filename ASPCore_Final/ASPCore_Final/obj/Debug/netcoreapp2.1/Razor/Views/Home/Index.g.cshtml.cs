#pragma checksum "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d683fa35626bc1596401509d3f85ff63df95594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d683fa35626bc1596401509d3f85ff63df95594", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae0022d08f620143d968fa9654a9b9c381b59a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTiet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("opacity:1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 344, true);
            WriteLiteral(@"

    <div class=""banner"" style=""background: url(/images/banner.jpg) no-repeat 0px 0px;"">
        <div class=""container"">
            <div class=""banner-info animated wow zoomIn"" data-wow-delay="".5s"">
                <h3>ESHOP</h3>
                <h4 style=""margin:auto"">Fashionista</h4>
            </div>
        </div>
    </div>
");
            EndContext();
#line 14 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
      
        ESHOPContext db = new ESHOPContext();
        List<HangHoa> hhs = db.HangHoa.ToList();
        List<HangHoa> hhnb = new List<HangHoa>();
        int demhhnb = 0;
        foreach (var item in hhs)
        {
            List<BinhLuanSp> bls = db.BinhLuanSp.Where(p => p.MaHh == item.MaHh).ToList();
            if (bls.Count > 0 && demhhnb < 8)
            {
                ++demhhnb;
                hhnb.Add(item);
            }
        }
        if (demhhnb < 8)
        {
            Random rnd = new Random();
            List<HangHoa> hhs_random = hhs.OrderBy(x => rnd.Next()).ToList();

            foreach (var hh in hhs_random)
            {
                if(!hhnb.Contains(hh) && demhhnb < 8)
                {
                    ++demhhnb;
                    hhnb.Add(hh);
                }
            }
        }
    

#line default
#line hidden
            BeginContext(1268, 211, true);
            WriteLiteral("    <div class=\"new-collections\">\r\n        <div class=\"container\">\r\n            <h3 class=\"animated wow zoomIn\" data-wow-delay=\".5s\">Sản phẩm nổi bật</h3>\r\n            <div class=\"new-collections-grids\">\r\n\r\n");
            EndContext();
#line 48 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                 foreach (var item in hhnb)
                {

#line default
#line hidden
            BeginContext(1543, 307, true);
            WriteLiteral(@"                    <div class=""col-md-3 new-collections-grid"">
                        <div class=""new-collections-grid1 new-collections-grid1-image-width animated wow slideInUp"" data-wow-delay="".5s"">
                            <div class=""new-collections-grid1-image"">
                                ");
            EndContext();
            BeginContext(1850, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473e89c5b40246d5a978902628708efe", async() => {
                BeginContext(1949, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb88ce275f194af6af7180353938057b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1959, "~/HangHoa/", 1959, 10, true);
#line 53 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1969, item.Hinh, 1969, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahh", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                                                     WriteLiteral(item.MaHh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahh", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2018, 150, true);
            WriteLiteral("\r\n                                <div class=\"new-collections-grid1-image-pos new-collections-grid1-image-pos1\">\r\n                                    ");
            EndContext();
            BeginContext(2168, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "875b474b10fd47678c002b47d2673d0b", async() => {
                BeginContext(2245, 13, true);
                WriteLiteral("Xem chi tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahh", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                                                         WriteLiteral(item.MaHh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahh", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahh"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2262, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 57 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                  
                                    List<SanPhamKho> sanPhamKhos = db.SanPhamKho.Where(p => p.MaHh == item.MaHh).ToList();
                                    var soluong = sanPhamKhos.Sum(x => x.SoLuong);
                                    if (soluong > 10)
                                    {
                                        double gg = item.GiamGia * 100;

#line default
#line hidden
            BeginContext(2715, 111, true);
            WriteLiteral("                                        <div class=\"new-one\">\r\n                                            <p>-");
            EndContext();
            BeginContext(2827, 2, false);
#line 64 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                           Write(gg);

#line default
#line hidden
            EndContext();
            BeginContext(2829, 55, true);
            WriteLiteral("%</p>\r\n                                        </div>\r\n");
            EndContext();
#line 66 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                    }
                                    else if (soluong > 0)
                                    {

#line default
#line hidden
            BeginContext(3021, 179, true);
            WriteLiteral("                                        <div class=\"new-one\">\r\n                                            <p>Sắp hết hàng</p>\r\n                                        </div>\r\n");
            EndContext();
#line 72 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3320, 179, true);
            WriteLiteral("                                        <div class=\"new-one\">\r\n                                            <p>Tạm hết hàng</p>\r\n                                        </div>\r\n");
            EndContext();
#line 78 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(3573, 166, true);
            WriteLiteral("                                <div class=\"new-collections-grid1-right new-collections-grid1-right-rate\">\r\n                                    <div class=\"rating\">\r\n");
            EndContext();
#line 82 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                          
                                            List<YeuThich> yts = db.YeuThich.Where(p => p.MaHh == item.MaHh).ToList();
                                            double diemyt = 0;
                                            if (yts.Count > 0)
                                            {
                                                double tongdiem = 0;
                                                foreach (var y in yts)
                                                {
                                                    tongdiem = tongdiem + y.DiemDanhGia;
                                                }
                                                diemyt = tongdiem / yts.Count();
                                                int diem = int.Parse(diemyt.ToString().Split(".")[0]);
                                                if (diem < 3)
                                                {
                                                    diem = 3;
                                                }
                                                for (int i = 1; i <= 5; i++)
                                                {
                                                    if (i <= diem)
                                                    {

#line default
#line hidden
            BeginContext(5078, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(5134, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d04ad924592427e80fc03649ae30bd3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 103 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                    }
                                                    else if (i > diem)
                                                    {

#line default
#line hidden
            BeginContext(5362, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(5418, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8312f4433323444a9f30225c4a9f9128", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5462, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 107 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#line 112 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                 for (int i = 1; i <= 5; i++)
                                                {

#line default
#line hidden
            BeginContext(5844, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(5896, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4450759fc3848a4b656b48728743e35", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5940, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 115 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#line 115 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                 
                                            }
                                        

#line default
#line hidden
            BeginContext(6083, 178, true);
            WriteLiteral("                                    </div>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n                            <h4><a href=\"single.html\">");
            EndContext();
            BeginContext(6262, 10, false);
#line 123 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                 Write(item.TenHh);

#line default
#line hidden
            EndContext();
            BeginContext(6272, 11, true);
            WriteLiteral("</a></h4>\r\n");
            EndContext();
#line 124 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                               
                                double giaban = item.DonGia * (1 - item.GiamGia);
                            

#line default
#line hidden
            BeginContext(6430, 129, true);
            WriteLiteral("                            <div class=\"new-collections-grid1-left simpleCart_shelfItem\">\r\n                                <p><i>");
            EndContext();
            BeginContext(6560, 29, false);
#line 128 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                 Write(item.DonGia.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(6589, 32, true);
            WriteLiteral(" đ</i> <span class=\"item_price\">");
            EndContext();
            BeginContext(6622, 24, false);
#line 128 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                                                                                               Write(giaban.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(6646, 111, true);
            WriteLiteral(" đ</span></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 132 "C:\Users\Dell\Downloads\Github\ASPCore_Final\ASPCore_Final\ASPCore_Final\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(6776, 50, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
