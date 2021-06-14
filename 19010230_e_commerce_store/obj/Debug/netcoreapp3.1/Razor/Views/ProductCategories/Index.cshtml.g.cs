#pragma checksum "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\ProductCategories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2bcd6f550c343bfc7b8ff5921f90d1ba92147e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductCategories_Index), @"mvc.1.0.view", @"/Views/ProductCategories/Index.cshtml")]
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
#line 1 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\_ViewImports.cshtml"
using _19010230_e_commerce_store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\_ViewImports.cshtml"
using _19010230_e_commerce_store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2bcd6f550c343bfc7b8ff5921f90d1ba92147e", @"/Views/ProductCategories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62dce1d4408cdc28ba040bb6d7608ebcd789fd8b", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_19010230_e_commerce_store.Models.ProductCategory>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\ProductCategories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b2bcd6f550c343bfc7b8ff5921f90d1ba92147e3573", async() => {
                WriteLiteral(@"
    <script>
window.onload = function () {

var chart = new CanvasJS.Chart(""chartContainer"", {
	animationEnabled: true,
	title: {
		text: ""Total Product Sales""
	},
	subtitles: [{
		text: ""across each category""
	}],
	axisY: {
		title: ""Number of Sales"",
		gridThickness: 0
	},
	data: [{
		type: ""bar"",
		indexLabel: ""{y}"",
		dataPoints: ");
#nullable restore
#line 27 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\ProductCategories\Index.cshtml"
               Write(Html.Raw(ViewBag.DataPoints));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t}]\r\n});\r\nchart.render();\r\n\r\n}\r\n    </script>\r\n");
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
            WriteLiteral(@"


    <h1>Product Category Sale History</h1>

    <div class=""card"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Product Category
                    </th>
                    <th>
                        Total Product Orders
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 53 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\ProductCategories\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\ProductCategories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\ProductCategories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "C:\Users\callu\source\repos\19010230_e_commerce_store\19010230_e_commerce_store\Views\ProductCategories\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>


        <br />
        <br />
        <br />

        <div id=""chartContainer"" style=""height: 370px; width: 100%;""></div>
        <script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>

    </div>
<style>
    .card {
        /* Add shadows to create the ""card"" effect */
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        transition: 0.3s;
    }

        /* On mouse-over, add a deeper shadow */
        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
            border-color: black;
        }

    /* Add some padding inside the card container */
    .container {
        padding: 2px 16px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_19010230_e_commerce_store.Models.ProductCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
