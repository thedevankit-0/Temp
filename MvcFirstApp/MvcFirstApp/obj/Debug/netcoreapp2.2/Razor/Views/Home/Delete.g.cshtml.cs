#pragma checksum "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4a997163de9d6c866158cf58a7e5fe9d7395eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4a997163de9d6c866158cf58a7e5fe9d7395eb", @"/Views/Home/Delete.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcFirstApp.Models.Movie>
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(62, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(91, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b4a997163de9d6c866158cf58a7e5fe9d7395eb3173", async() => {
                BeginContext(97, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Delete</title>\r\n");
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
            BeginContext(192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(194, 1147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b4a997163de9d6c866158cf58a7e5fe9d7395eb4449", async() => {
                BeginContext(200, 158, true);
                WriteLiteral("\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(359, 38, false);
#line 22 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(397, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(461, 34, false);
#line 25 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(495, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(558, 41, false);
#line 28 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(599, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(663, 37, false);
#line 31 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(700, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(763, 45, false);
#line 34 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MovieStar));

#line default
#line hidden
                EndContext();
                BeginContext(808, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(872, 41, false);
#line 37 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MovieStar));

#line default
#line hidden
                EndContext();
                BeginContext(913, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(976, 45, false);
#line 40 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MovieType));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(1085, 41, false);
#line 43 "D:\Ankitkumar-Singh\Asp-Core-Mvc\MvcFirstApp\MvcFirstApp\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MovieType));

#line default
#line hidden
                EndContext();
                BeginContext(1126, 208, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
            BeginContext(1341, 11, true);
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
