#pragma checksum "C:\ASPCORE\asp8\asp8\Views\Home\_parcial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df7f63becb1740c22758d1d36a0c68ade85d8460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__parcial), @"mvc.1.0.view", @"/Views/Home/_parcial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_parcial.cshtml", typeof(AspNetCore.Views_Home__parcial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df7f63becb1740c22758d1d36a0c68ade85d8460", @"/Views/Home/_parcial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__parcial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<asp8.ViewModel.Bag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 34, true);
            WriteLiteral("\r\n<h3>View Partial</h3>\r\n<p>Nome: ");
            EndContext();
            BeginContext(62, 17, false);
#line 4 "C:\ASPCORE\asp8\asp8\Views\Home\_parcial.cshtml"
    Write(Model.humano.nome);

#line default
#line hidden
            EndContext();
            BeginContext(79, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(81, 20, false);
#line 4 "C:\ASPCORE\asp8\asp8\Views\Home\_parcial.cshtml"
                       Write(Model.humano.apelido);

#line default
#line hidden
            EndContext();
            BeginContext(101, 16, true);
            WriteLiteral("</p>\r\n<p>Carro: ");
            EndContext();
            BeginContext(118, 21, false);
#line 5 "C:\ASPCORE\asp8\asp8\Views\Home\_parcial.cshtml"
     Write(Model.automovel.marca);

#line default
#line hidden
            EndContext();
            BeginContext(139, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(143, 19, false);
#line 5 "C:\ASPCORE\asp8\asp8\Views\Home\_parcial.cshtml"
                              Write(Model.automovel.cor);

#line default
#line hidden
            EndContext();
            BeginContext(162, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<asp8.ViewModel.Bag> Html { get; private set; }
    }
}
#pragma warning restore 1591
