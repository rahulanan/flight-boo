#pragma checksum "C:\Users\rahulana\source\repos\SendingMail\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674f2eee39908fb0675f67e0c3dab65636261be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rahulana\source\repos\SendingMail\Views\_ViewImports.cshtml"
using SendingMail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rahulana\source\repos\SendingMail\Views\_ViewImports.cshtml"
using SendingMail.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"674f2eee39908fb0675f67e0c3dab65636261be8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4533123a2efde7af0702d724db6d909ab199980e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rahulana\source\repos\SendingMail\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Sending Email with HTML content from SMTP server using Asp.Net Core MVC 5.0</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\rahulana\source\repos\SendingMail\Views\Home\Index.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""form-group col-md-6"">
                <input type=""email"" class=""form-control"" name=""toEmail"" />
            </div>
            <div class=""form-group col-md-6"">
                <input type=""submit"" value=""Send Email"" />
            </div>
        </div>
");
#nullable restore
#line 19 "C:\Users\rahulana\source\repos\SendingMail\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\rahulana\source\repos\SendingMail\Views\Home\Index.cshtml"
     if (ViewBag.EmailSentMessage != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bg-success\">\r\n            <label>");
#nullable restore
#line 23 "C:\Users\rahulana\source\repos\SendingMail\Views\Home\Index.cshtml"
              Write(ViewBag.EmailSentMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\rahulana\source\repos\SendingMail\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
