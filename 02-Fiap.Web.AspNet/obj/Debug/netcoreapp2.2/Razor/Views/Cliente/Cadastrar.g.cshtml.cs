#pragma checksum "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\Cliente\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70073fca2a6129d45f54a1deae905942db310190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Cadastrar), @"mvc.1.0.view", @"/Views/Cliente/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Cadastrar.cshtml", typeof(AspNetCore.Views_Cliente_Cadastrar))]
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
#line 1 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _02_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _02_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70073fca2a6129d45f54a1deae905942db310190", @"/Views/Cliente/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c709c5fd796b7643c5b998a9ca7bc4ccd0d593", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cliente/Cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\Cliente\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
            BeginContext(47, 44, true);
            WriteLiteral("\r\n<h1>Cadastrar</h1>\r\n\r\n<p>Nome do usuário: ");
            EndContext();
            BeginContext(92, 16, false);
#line 8 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\Cliente\Cadastrar.cshtml"
               Write(ViewData["nome"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 16, true);
            WriteLiteral("</p>\r\n<p>CPF: \r\n");
            EndContext();
#line 10 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\Cliente\Cadastrar.cshtml"
     if (@ViewBag.cliente != null)
    {
        

#line default
#line hidden
            BeginContext(176, 19, false);
#line 12 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\Cliente\Cadastrar.cshtml"
   Write(ViewBag.cliente.Cpf);

#line default
#line hidden
            EndContext();
#line 12 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\Cliente\Cadastrar.cshtml"
                            
    }

#line default
#line hidden
            BeginContext(204, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(214, 15, false);
#line 15 "D:\Rm81728\Thiago\Projeto\02-Fiap.Web.AspNet\02-Fiap.Web.AspNet\Views\Cliente\Cadastrar.cshtml"
Write(TempData["msg"]);

#line default
#line hidden
            EndContext();
            BeginContext(229, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(237, 799, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70073fca2a6129d45f54a1deae905942db3101905823", async() => {
                BeginContext(285, 744, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""id-nome"">Nome</label>
        <input type=""text"" name=""nome"" id=""id-nome"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label for=""id-email"">E-Mail</label>
        <input type=""text"" name=""email"" id=""id-email"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label for=""id-cpf"">CPF</label>
        <input type=""text"" name=""cpf"" id=""id-cpf"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <input type=""checkbox"" name=""m_idade"" id=""id_idade"" class=""custom-checkbox"" />
        <label for=""id_idade"">Maior de Idade</label>
    </div>
    <input type=""submit"" class=""btn btn-primary"" value=""Cadastrar"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1036, 4, true);
            WriteLiteral("\r\n\r\n");
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
