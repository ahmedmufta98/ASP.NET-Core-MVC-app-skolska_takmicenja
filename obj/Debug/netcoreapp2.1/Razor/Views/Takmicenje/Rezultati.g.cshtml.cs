#pragma checksum "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1e01ebce26e49319d97b5937f3ed69c87c089e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_Rezultati), @"mvc.1.0.view", @"/Views/Takmicenje/Rezultati.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Takmicenje/Rezultati.cshtml", typeof(AspNetCore.Views_Takmicenje_Rezultati))]
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
#line 2 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\_ViewImports.cshtml"
using RS1_Ispit_asp.net_core.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e01ebce26e49319d97b5937f3ed69c87c089e8", @"/Views/Takmicenje/Rezultati.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48672cdbdd041e8c199d184866358cb183341b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_Rezultati : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TakmicenjeRezultatiVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
  
    ViewData["Title"] = "Rezultati";

#line default
#line hidden
            BeginContext(75, 77, true);
            WriteLiteral("\r\n<h2>Rezultati takmičenja</h2>\r\n<br />\r\n<label>Škola domaćin:</label><label>");
            EndContext();
            BeginContext(153, 11, false);
#line 8 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                               Write(Model.Skola);

#line default
#line hidden
            EndContext();
            BeginContext(164, 48, true);
            WriteLiteral("</label>\r\n<br />\r\n<label>Predmet:</label><label>");
            EndContext();
            BeginContext(213, 13, false);
#line 10 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                         Write(Model.Predmet);

#line default
#line hidden
            EndContext();
            BeginContext(226, 47, true);
            WriteLiteral("</label>\r\n<br />\r\n<label>Razred:</label><label>");
            EndContext();
            BeginContext(274, 12, false);
#line 12 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                        Write(Model.Razred);

#line default
#line hidden
            EndContext();
            BeginContext(286, 57, true);
            WriteLiteral("</label>\r\n<br />\r\n<label>Datum takmičenja:</label><label>");
            EndContext();
            BeginContext(344, 11, false);
#line 14 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                  Write(Model.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(355, 18, true);
            WriteLiteral("</label>\r\n<br />\r\n");
            EndContext();
#line 16 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
 if (Model.Zakljucan == false)
{

#line default
#line hidden
            BeginContext(408, 56, true);
            WriteLiteral("    <a class=\"btn btn-primary zakljucaj\">Zaključaj</a>\r\n");
            EndContext();
#line 19 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
}

#line default
#line hidden
            BeginContext(467, 87, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div id=\"ucesnici\"></div>\r\n<br />\r\n<br />\r\n<a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 554, "\"", 622, 4);
            WriteAttributeValue("", 561, "/Takmicenje/Dodaj?SkolaId=", 561, 26, true);
#line 26 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
WriteAttributeValue("", 587, Model.SkolaId, 587, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 601, "&Razred=", 601, 8, true);
#line 26 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
WriteAttributeValue("", 609, Model.Razred, 609, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(623, 100, true);
            WriteLiteral(">Novo takmičenje</a>\r\n<script>\r\n    $(document).ready(()=>{\r\n        $.get(\"/Takmicenje/Ucesnici?id=");
            EndContext();
            BeginContext(724, 18, false);
#line 29 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                  Write(Model.TakmicenjeId);

#line default
#line hidden
            EndContext();
            BeginContext(742, 180, true);
            WriteLiteral("\", function (data) {\r\n            $(\"#ucesnici\").html(data);\r\n        });\r\n        $(document).on(\'click\', \'.zakljucaj\', function () {\r\n            $.get(\"/Takmicenje/Zakljucaj?id=");
            EndContext();
            BeginContext(923, 18, false);
#line 33 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Takmicenje\Rezultati.cshtml"
                                       Write(Model.TakmicenjeId);

#line default
#line hidden
            EndContext();
            BeginContext(941, 114, true);
            WriteLiteral("\", function (data) {\r\n                $(\"#ucesnici\").html(data);\r\n            });\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TakmicenjeRezultatiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
