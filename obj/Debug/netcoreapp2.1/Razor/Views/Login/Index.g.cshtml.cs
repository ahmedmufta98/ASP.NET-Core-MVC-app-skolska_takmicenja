#pragma checksum "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d671e94b73d7d7eed51912cec7b4189775ccbbee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d671e94b73d7d7eed51912cec7b4189775ccbbee", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48672cdbdd041e8c199d184866358cb183341b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Login\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(39, 43, true);
            WriteLiteral("\r\n<h2 class=\"\">Logiranje na sistem</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Login\Index.cshtml"
 using (Html.BeginForm("Provjera", "Login"))
{


#line default
#line hidden
            BeginContext(133, 389, true);
            WriteLiteral(@"    <div class=""form-group"">
        <label for=""username"">Username</label>
        <input  class=""form-control"" id=""username"" name=""username"" placeholder=""Username"" value=""1"">
    </div>
    <div class=""form-group"">
        <label for=""password"">Password</label>
        <input  class=""form-control"" id=""password""  name=""password""  placeholder=""Password"" value=""test"">
    </div>
");
            EndContext();
            BeginContext(527, 71, true);
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-default\">Prijavi se</button>\r\n");
            EndContext();
#line 21 "C:\Users\ZZO5\Desktop\FINALE 30.01.2020\rs1-2020-01-30\RS1_Ispit_2020_01_30_aspnet_core\RS1_Ispit\Views\Login\Index.cshtml"

           
}

#line default
#line hidden
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
