#pragma checksum "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e02c099c32097add578379772b3d343078cef485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e02c099c32097add578379772b3d343078cef485", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab047a4d674c214c15db459a584c05f98bae6169", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_layout_original"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("\n\n<!doctype html>\n\n<html class=\"no-js\">\n\n");
#nullable restore
#line 11 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_head"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e02c099c32097add578379772b3d343078cef4853795", async() => {
                WriteLiteral("\n\n    ");
#nullable restore
#line 15 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


    <!-- #wrapper -->
    <div id=""wrapper"">
        <!-- .page-sidebar -->
        <aside id=""sidebar"" class=""page-sidebar hidden-md hidden-sm hidden-xs"">
            <div class=""sidebar-inner"">
                <div class=""sidebar-scrollarea"">


                    ");
#nullable restore
#line 26 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("PartialViews/_profile_left_sidebar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                    <div class=\"sidebar-panel\">\n                        <h5 class=\"sidebar-panel-title\">Navigation</h5>\n                    </div>\n\n                    <div class=\"side-nav\">\n                        <ul class=\"nav\">\n\n");
                WriteLiteral("\n                            ");
#nullable restore
#line 37 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
                       Write(await Html.PartialAsync("PartialViews/_lis_do_menu_left"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                        </ul>\n                    </div>\n                    <!-- / side-nav -->\n\n                    ");
#nullable restore
#line 43 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("PartialViews/_menu_inferior_left"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                </div>\n            </div>\n            <!-- End .sidebar-scrollarea -->\n\n        </aside>\n        <!-- / page-sidebar -->\n\n        ");
#nullable restore
#line 52 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("PartialViews/_rightsidebar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        <!-- .page-content -->\n        <div class=\"page-content sidebar-page right-sidebar-page clearfix\">\n            <div class=\"page-content-wrapper\">\n                <div class=\"page-content-inner\">\n\n                    ");
#nullable restore
#line 59 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                </div>\n            </div>\n        </div>\n\n\n\n    </div>\n    <!-- / #wrapper -->\n\n\n    ");
#nullable restore
#line 71 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n    <!-- Back to top -->\n    <div id=\"back-to-top\">\n        <a href=\"#\">Voltar para o Topo</a>\n    </div>\n\n    ");
#nullable restore
#line 79 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_scripts"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 81 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
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
            WriteLiteral("\n</html>\n");
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
