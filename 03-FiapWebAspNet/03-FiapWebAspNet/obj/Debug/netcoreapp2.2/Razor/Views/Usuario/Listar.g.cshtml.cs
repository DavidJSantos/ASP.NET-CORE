#pragma checksum "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d827363b4bf50c6d050fe5e50a25868bd6b6a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 1 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\_ViewImports.cshtml"
using _03_FiapWebAspNet;

#line default
#line hidden
#line 2 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\_ViewImports.cshtml"
using _03_FiapWebAspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d827363b4bf50c6d050fe5e50a25868bd6b6a4", @"/Views/Usuario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef03d9c4ca1c2b0674dfb1e74e05f6bbb80de7dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\Usuario\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(65, 84, true);
            WriteLiteral("\r\n<h1>Listar</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 12 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\Usuario\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(190, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(221, 9, false);
#line 15 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\Usuario\Listar.cshtml"
           Write(item.nome);

#line default
#line hidden
            EndContext();
            BeginContext(230, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(254, 17, false);
#line 16 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\Usuario\Listar.cshtml"
           Write(item.dtNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(271, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(295, 10, false);
#line 17 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\Usuario\Listar.cshtml"
           Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(305, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 19 "D:\RM81728\Projeto\ASP.NET-CORE\03-FiapWebAspNet\03-FiapWebAspNet\Views\Usuario\Listar.cshtml"
        
    }

#line default
#line hidden
            BeginContext(344, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
