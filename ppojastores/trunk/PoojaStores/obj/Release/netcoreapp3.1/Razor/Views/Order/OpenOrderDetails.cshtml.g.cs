#pragma checksum "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc56d3ff018e7db88da3399bfbcc0e4f0f661ef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OpenOrderDetails), @"mvc.1.0.view", @"/Views/Order/OpenOrderDetails.cshtml")]
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
#line 1 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc56d3ff018e7db88da3399bfbcc0e4f0f661ef0", @"/Views/Order/OpenOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd5e81157aaadf292c89301cd5c1be8ee9a165", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OpenOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.OrderDetailPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Order/OpenOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
  
    int rCnt = 1;
    Layout = "~/Views/Shared/AdminMaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-book""></i>
        </div>
        <div class=""header-title"">
            <h1>Open Order Details</h1>
            <small>Order management.</small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">                   
                    <div class=""card-header"">
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <div class=""card-title custom_title"">
                                    <h4>Open Order Details List</h4>
                                </div>
                            </div>

                            <div class=""col-md-8"">
                                <div class=""btn-");
            WriteLiteral("group float-right\" role=\"group\">\r\n                                    <div class=\"buttonexport\" id=\"buttonlist\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc56d3ff018e7db88da3399bfbcc0e4f0f661ef06386", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-reply mr-2\"></i>Back\r\n                                        ");
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
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-3"">
                                        Full Name 
                                        <br />
                                        Address 1 
                                        <br />
");
#nullable restore
#line 49 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                         if (Model.Address2 != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Address 2 </span>\r\n                                            <br />\r\n");
#nullable restore
#line 53 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        Street   
                                        <br />
                                        LandMark 
                                    </div>
                                    <div class=""col-md-1"">
                                        :
                                        <br />
                                        :
                                        <br />
");
#nullable restore
#line 63 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                         if (Model.Address2 != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>: </span>\r\n                                            <br />\r\n");
#nullable restore
#line 67 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        :
                                        <br />
                                        :
                                    </div>
                                    <div class=""col-md-8"">
                                        ");
#nullable restore
#line 73 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <br />\r\n                                        ");
#nullable restore
#line 75 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.Address1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <br />\r\n");
#nullable restore
#line 77 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                         if (Model.Address2 != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 79 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                             Write(Model.Address2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <br />\r\n");
#nullable restore
#line 81 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
#nullable restore
#line 82 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.LocationStreet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <br />\r\n                                        ");
#nullable restore
#line 84 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.LandMark);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""row"">
                                    <div class=""col-md-3"">                                        
                                        City     
                                        <br />
                                        State    
                                        <br />
                                        Country  
                                        <br />
                                        Zipcode  
                                    </div>
                                    <div class=""col-md-1"">
                                        :
                                        <br />
                                        :
                                        <br />
                                        :
                      ");
            WriteLiteral("                  <br />\r\n                                        :\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        ");
#nullable restore
#line 109 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <br />\r\n                                        ");
#nullable restore
#line 111 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <br />\r\n                                        ");
#nullable restore
#line 113 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <br />\r\n                                        ");
#nullable restore
#line 115 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                   Write(Model.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div id=""no-more-tables"">
                            <table class=""col-md-12 table-bordered table-striped table-condensed cf"">
                                <thead class=""cf"">
                                    <tr>
                                        <th>S.no</th>
                                        <th>Order Id</th>
                                        <th>Product Code</th>
                                        <th>Product</th>
                                        <th>No Of Items Ordered</th>
                                        <th>Dispatch</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 135 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                     foreach (var u in Model.odetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td data-title=\"S.no\">");
#nullable restore
#line 138 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                                              Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td data-title=\"Category Name\">");
#nullable restore
#line 139 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                                                      Write(u.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td data-title=\"Category Name\">");
#nullable restore
#line 140 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                                                      Write(u.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td data-title=\"Category Name\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc56d3ff018e7db88da3399bfbcc0e4f0f661ef017551", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7025, "~/ProductImages/", 7025, 16, true);
#nullable restore
#line 142 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
AddHtmlAttributeValue("", 7041, u.Image, 7041, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td data-title=\"Category Name\">");
#nullable restore
#line 144 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                                                      Write(u.NumberOfItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td data-title=\"Dispatch\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc56d3ff018e7db88da3399bfbcc0e4f0f661ef019696", async() => {
                WriteLiteral("Dispatch");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7306, "~/Order/DispatchDetails?id=", 7306, 27, true);
#nullable restore
#line 145 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
AddHtmlAttributeValue("", 7333, u.PODetailId, 7333, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 147 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Order\OpenOrderDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n    <!-- /.content -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.OrderDetailPage> Html { get; private set; }
    }
}
#pragma warning restore 1591