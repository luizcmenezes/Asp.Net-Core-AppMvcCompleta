#pragma checksum "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47646160f3b2e4d5520db170b48c5b2d27936634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Delete), @"mvc.1.0.view", @"/Views/Produtos/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Delete.cshtml", typeof(AspNetCore.Views_Produtos_Delete))]
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
#line 1 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#line 2 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47646160f3b2e4d5520db170b48c5b2d27936634", @"/Views/Produtos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1c4f7112a188c6823fcdfc8cbeb3cfe4ebb5b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px; height: 428px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
  
    ViewData["Title"] = "Excluir - " + Model.Nome;

#line default
#line hidden
            BeginContext(107, 32, true);
            WriteLiteral("\r\n<h4 style=\"padding-top: 50px\">");
            EndContext();
            BeginContext(140, 17, false);
#line 7 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(157, 100, true);
            WriteLiteral("</h4>\r\n\r\n<h5>Você tem certeza disso?</h5>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(257, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47646160f3b2e4d5520db170b48c5b2d279366345557", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 267, "~/imagens/", 267, 10, true);
#line 13 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
AddHtmlAttributeValue("", 277, Model.Imagem, 277, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
AddHtmlAttributeValue("", 297, Model.Imagem, 297, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(350, 90, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <dl>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(441, 48, false);
#line 18 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FornecedorId));

#line default
#line hidden
            EndContext();
            BeginContext(489, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(545, 47, false);
#line 21 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Fornecedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(592, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(648, 40, false);
#line 24 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(744, 36, false);
#line 27 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(780, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(836, 45, false);
#line 30 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(881, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(937, 41, false);
#line 33 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(978, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1034, 41, false);
#line 36 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1131, 25, false);
#line 39 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1212, 48, false);
#line 42 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1316, 44, false);
#line 45 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1416, 41, false);
#line 48 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1513, 37, false);
#line 51 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1550, 63, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1613, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47646160f3b2e4d5520db170b48c5b2d2793663413203", async() => {
                BeginContext(1639, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1657, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47646160f3b2e4d5520db170b48c5b2d2793663413604", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 56 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Produtos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1693, 187, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger\" />\r\n                <a class=\"btn btn-info\" href=\"javascript:window.history.back();\">Voltar</a>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1887, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
