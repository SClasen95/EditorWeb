#pragma checksum "C:\Users\Simon\source\repos\EditorWeb\EditorWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efdee5efa9e2f772994f64fee18d379671049c5c"
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
#line 1 "C:\Users\Simon\source\repos\EditorWeb\EditorWeb\Views\_ViewImports.cshtml"
using EditorWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simon\source\repos\EditorWeb\EditorWeb\Views\_ViewImports.cshtml"
using EditorWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efdee5efa9e2f772994f64fee18d379671049c5c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97808785c9f76cc111bcd070749d9a4e679f9d7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Simon\source\repos\EditorWeb\EditorWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewBag.title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4 textoBlanco"">Bienvenido</h1>
     <br/>
     <p class=""textoBlanco"">Esta es una vista previa del menu principal de la aplicacion</p>
    <img class=""imgMain"" src=""/assets/prevMainLoaded.png""/>
    <br />
    <h3 class=""display-4 textoBlanco"">Algunas Caracteristicas</h3>
    <br />
    <ul align=""center"" class=""col-4 ml-auto mr-auto"">
        <li>
            <img class=""imgLista"" src=""/assets/prevCF.png"" />
            <p style=""display: block"" class=""textoBlanco"">Esta funcionalidad permite cambiar el formato de tu video a cualquier formato deseado</p>
        </li>
        <li>
            <img class=""imgLista"" src=""/assets/prevCR.png"" />
            <p class=""textoBlanco"">Esta funcionalidad permite cambiar la resolucion de tu video a una resolucion dentro de una lista de opciones</p>
        </li>
        <li>
            <img class=""imgLista"" src=""/assets/prevEA.png"" />
            <p class=""textoBlanco"">Esta funcionalidad permite extr");
            WriteLiteral(@"aer el audio de un video en formato mp3</p>
        </li>
        <li>
            <img class=""imgLista"" src=""/assets/prevEI.png"" />
            <p class=""textoBlanco"">Esta funcionalidad permite extraer una imagen en formato png de cada tantas imagenes de tu video</p>
        </li>
        <li>
            <img class=""imgLista"" src=""/assets/prevRA.png"" />
            <p class=""textoBlanco"">Esta funcionalidad permite remover el audio del video, devolviendo un video sin sonido</p>
        </li>
    </ul>

    


");
#nullable restore
#line 40 "C:\Users\Simon\source\repos\EditorWeb\EditorWeb\Views\Home\Index.cshtml"
     if(ViewBag.usuario!=null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <a href=\"https://github.com/SClasen95/VideoEdit/archive/main.zip\" target=\"_blank\">¡¡¡Hace click aca para descargar la aplicacion!!!</a>\r\n");
#nullable restore
#line 43 "C:\Users\Simon\source\repos\EditorWeb\EditorWeb\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    ");
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
