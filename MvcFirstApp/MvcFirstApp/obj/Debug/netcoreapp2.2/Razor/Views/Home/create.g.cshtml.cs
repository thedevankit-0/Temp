#pragma checksum "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3645f0383789fdb01b9ff6056f69e482c1cbf8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_create), @"mvc.1.0.view", @"/Views/Home/create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/create.cshtml", typeof(AspNetCore.Views_Home_create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3645f0383789fdb01b9ff6056f69e482c1cbf8c7", @"/Views/Home/create.cshtml")]
    public class Views_Home_create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcFirstApp.Models.Movie>
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
            BeginContext(33, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(62, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3645f0383789fdb01b9ff6056f69e482c1cbf8c72923", async() => {
                BeginContext(68, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>create</title>\r\n");
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
            BeginContext(163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(165, 2730, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3645f0383789fdb01b9ff6056f69e482c1cbf8c74199", async() => {
                BeginContext(171, 71, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"mb-3\">\r\n            ");
                EndContext();
                BeginContext(243, 99, false);
#line 13 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
       Write(Html.ActionLink("Home", "Index", "Assignment1", new object { }, new { @class = "btn btn-primary" }));

#line default
#line hidden
                EndContext();
                BeginContext(342, 170, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"card border-primary\">\r\n            <div class=\"card-header\">Add guest</div>\r\n            <div class=\"col-md-6 card-body offset-3\">\r\n");
                EndContext();
#line 18 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
                BeginContext(595, 23, false);
#line 20 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(620, 165, true);
                WriteLiteral("                    <div class=\"form-horizontal\">\r\n                        <h4>Add guest for the party</h4>\r\n                        <hr />\r\n                        ");
                EndContext();
                BeginContext(786, 64, false);
#line 24 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(850, 80, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(931, 94, false);
#line 26 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                       Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(1025, 87, true);
                WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
                EndContext();
                BeginContext(1113, 94, false);
#line 28 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1207, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1242, 83, false);
#line 29 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1325, 148, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(1474, 98, false);
#line 33 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                       Write(Html.LabelFor(model => model.MovieType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(1572, 87, true);
                WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
                EndContext();
                BeginContext(1660, 98, false);
#line 35 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                           Write(Html.EditorFor(model => model.MovieType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1758, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1793, 87, false);
#line 36 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.MovieType, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1880, 148, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(2029, 98, false);
#line 40 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                       Write(Html.LabelFor(model => model.MovieStar, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(2127, 87, true);
                WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
                EndContext();
                BeginContext(2215, 98, false);
#line 42 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                           Write(Html.EditorFor(model => model.MovieStar, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2313, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2348, 87, false);
#line 43 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.MovieStar, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2435, 384, true);
                WriteLiteral(@"
                            </div>
                        </div>

                        <div class=""form-group"">
                            <div class=""col-md-offset-2 col-md-10"">
                                <input type=""submit"" value=""Create"" class=""btn  btn-primary"" />
                            </div>
                        </div>
                    </div>
");
                EndContext();
#line 53 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\create.cshtml"
                }

#line default
#line hidden
                BeginContext(2838, 50, true);
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
            BeginContext(2895, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcFirstApp.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591