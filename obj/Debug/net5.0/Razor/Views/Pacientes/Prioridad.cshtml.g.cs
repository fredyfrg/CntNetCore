#pragma checksum "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b10f286bcbed72d0b0425e01d90e17d6b49b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes_Prioridad), @"mvc.1.0.view", @"/Views/Pacientes/Prioridad.cshtml")]
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
#line 1 "C:\Users\FRG\source\repos\CntNetCore\Views\_ViewImports.cshtml"
using CntNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FRG\source\repos\CntNetCore\Views\_ViewImports.cshtml"
using CntNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b10f286bcbed72d0b0425e01d90e17d6b49b63", @"/Views/Pacientes/Prioridad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db58b2e08072d31819b316076853820bb63198ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacientes_Prioridad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CntNetCore.Models.Pacientes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atender", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
  
    ViewData["Title"] = "Prioridad";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Prioridad Pacientes</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Estatura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Fumador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Añosfumador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Dieta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayNameFor(model => model.Prioridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estatura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fumador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Añosfumador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dieta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prioridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b10f286bcbed72d0b0425e01d90e17d6b49b6310797", async() => {
                WriteLiteral("<button class=\"btn btn-success\">Atender</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
                                          WriteLiteral(item.Documento);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\FRG\source\repos\CntNetCore\Views\Pacientes\Prioridad.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CntNetCore.Models.Pacientes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
