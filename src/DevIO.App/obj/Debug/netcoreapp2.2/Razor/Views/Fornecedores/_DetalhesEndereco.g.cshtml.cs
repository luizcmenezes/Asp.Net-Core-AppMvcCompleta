#pragma checksum "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80bd19f9a6f2f5297537b0df05c071032405ad98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco), @"mvc.1.0.view", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedores/_DetalhesEndereco.cshtml", typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bd19f9a6f2f5297537b0df05c071032405ad98", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d67c6974e923fe87ca692c3df0af5766f8f5bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores__DetalhesEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.FornecedorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 101, true);
            WriteLiteral("\r\n<div style=\"padding-top: 20px\">\r\n    <div>\r\n        <hr />\r\n        <h4>Endereço</h4>\r\n    </div>\r\n");
            EndContext();
#line 8 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(182, 155, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <thead class=\"thead-dark\">\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(338, 55, false);
#line 14 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(393, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(473, 51, false);
#line 17 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(524, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(604, 56, false);
#line 20 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(660, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(740, 51, false);
#line 23 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(791, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(871, 48, false);
#line 26 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(919, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(999, 51, false);
#line 29 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1130, 51, false);
#line 32 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 167, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1349, 51, false);
#line 40 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1468, 47, false);
#line 43 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1583, 52, false);
#line 46 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1703, 47, false);
#line 49 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1818, 44, false);
#line 52 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1930, 47, false);
#line 55 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2045, 47, false);
#line 58 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
               Write(Html.DisplayFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2092, 210, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"><span title=\"Editar\" class=\"fa fa-pencil-alt\"></span></a>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 65 "D:\Projeto_Dev\ASPNet Core FullStack\AppCompleta\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
    }

#line default
#line hidden
            BeginContext(2309, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.FornecedorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
