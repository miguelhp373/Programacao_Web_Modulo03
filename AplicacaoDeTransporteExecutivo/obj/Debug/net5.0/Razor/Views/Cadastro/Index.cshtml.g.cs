#pragma checksum "C:\Projetos _Modulo03_Etecvav\Modulo 03\Programacao_Web_Modulo03\AplicacaoDeTransporteExecutivo\Views\Cadastro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d64685ec87ac2008bef47f876ab3c6dd662f93a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Index), @"mvc.1.0.view", @"/Views/Cadastro/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d64685ec87ac2008bef47f876ab3c6dd662f93a", @"/Views/Cadastro/Index.cshtml")]
    public class Views_Cadastro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<");
            WriteLiteral("DOCTYPES html>\r\n    <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d64685ec87ac2008bef47f876ab3c6dd662f93a2806", async() => {
                WriteLiteral("\r\n        <title>Transporte Executivo</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d64685ec87ac2008bef47f876ab3c6dd662f93a3827", async() => {
                WriteLiteral(@"
        <div>
            <h1>Cadastro - Transporte Executivo</h1>
            <form method=""post"" action=""/Cadastro/ReceberCadastro"">
                <div>
                    <label for=""nome"">Nome:</label>
                    <input type=""text"" name=""nome"" id=""nome"" maxlength=""40"" placeholder=""Informe seu nome..."">
                    ");
#nullable restore
#line 13 "C:\Projetos _Modulo03_Etecvav\Modulo 03\Programacao_Web_Modulo03\AplicacaoDeTransporteExecutivo\Views\Cadastro\Index.cshtml"
               Write(Html.ValidationMessage("nome"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div>
                    <label for=""telefone"">Telefone:</label>
                    <input type=""text"" name=""telefone"" id=""telefone"" maxlength=""15"" placeholder=""Informe seu telefone de contato..."">
                    ");
#nullable restore
#line 18 "C:\Projetos _Modulo03_Etecvav\Modulo 03\Programacao_Web_Modulo03\AplicacaoDeTransporteExecutivo\Views\Cadastro\Index.cshtml"
               Write(Html.ValidationMessage("telefone"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div>
                    <label for=""ida"">Ida:</label>
                    <select name=""ida"">
                        <option value=""sim"">Sim</option>
                        <option value=""não"">Não</option>
                    </select>
                    ");
#nullable restore
#line 26 "C:\Projetos _Modulo03_Etecvav\Modulo 03\Programacao_Web_Modulo03\AplicacaoDeTransporteExecutivo\Views\Cadastro\Index.cshtml"
               Write(Html.ValidationMessage("ida"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div>
                    <label for=""volta"">Volta:</label>
                    <select name=""volta"">
                        <option value=""sim"">Sim</option>
                        <option value=""não"">Não</option>
                    </select>
                    ");
#nullable restore
#line 34 "C:\Projetos _Modulo03_Etecvav\Modulo 03\Programacao_Web_Modulo03\AplicacaoDeTransporteExecutivo\Views\Cadastro\Index.cshtml"
               Write(Html.ValidationMessage("volta"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <button type=""submit"">Enviar</button>
                <button type=""reset"">Limpar</button>
            </form>
        </div>
        <footer>
            <div>
                <p>Todos os direitos reservados para Transporte Executivo 3M&copy; - 2021 - ");
#nullable restore
#line 42 "C:\Projetos _Modulo03_Etecvav\Modulo 03\Programacao_Web_Modulo03\AplicacaoDeTransporteExecutivo\Views\Cadastro\Index.cshtml"
                                                                                       Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(".</p>\r\n            </div>\r\n        </footer>\r\n    ");
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
            WriteLiteral("\r\n</html>\r\n");
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