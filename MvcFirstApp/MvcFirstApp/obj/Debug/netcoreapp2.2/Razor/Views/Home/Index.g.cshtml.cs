#pragma checksum "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eed5a4c3fa2f81ba2e107f369e948be4d60e2ff"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eed5a4c3fa2f81ba2e107f369e948be4d60e2ff", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcFirstApp.Models.Movie>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(73, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(81, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eed5a4c3fa2f81ba2e107f369e948be4d60e2ff3048", async() => {
                BeginContext(87, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(183, 1256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eed5a4c3fa2f81ba2e107f369e948be4d60e2ff4323", async() => {
                BeginContext(189, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(327, 149, true);
                WriteLiteral("\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
                EndContext();
#line 22 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(533, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(606, 37, false);
#line 26 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(643, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(723, 40, false);
#line 29 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(763, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(843, 44, false);
#line 32 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieStar));

#line default
#line hidden
                EndContext();
                BeginContext(887, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(967, 44, false);
#line 35 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieType));

#line default
#line hidden
                EndContext();
                BeginContext(1011, 81, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1093, 53, false);
#line 39 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1146, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(1175, 66, false);
#line 40 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Details", "StudentDetails", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1241, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(1270, 57, false);
#line 41 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1327, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 44 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1394, 38, true);
                WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1439, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcFirstApp.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
