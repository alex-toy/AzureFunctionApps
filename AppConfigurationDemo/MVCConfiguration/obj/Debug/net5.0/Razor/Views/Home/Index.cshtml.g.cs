#pragma checksum "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3c0717c876a83ee1287d893c2f12eab103fe738"
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
#line 1 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\_ViewImports.cshtml"
using MVCConfiguration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\_ViewImports.cshtml"
using MVCConfiguration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\Home\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3c0717c876a83ee1287d893c2f12eab103fe738", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e931ff09ef99e496b529c5518aee5a5bedfeefa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color : ");
#nullable restore
#line 10 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\Home\Index.cshtml"
                      Write(Configuration["TestApp:Settings:BackGroundColor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    }\r\n\r\n    h1 {\r\n        color : ");
#nullable restore
#line 14 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\Home\Index.cshtml"
           Write(Configuration["TestApp:Settings:FontColor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        font-size : ");
#nullable restore
#line 15 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\Home\Index.cshtml"
               Write(Configuration["TestApp:Settings:FontSize"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    }\r\n</style>\r\n\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 20 "C:\source\cSharpAzure\AzureFunctionApps\AppConfigurationDemo\MVCConfiguration\Views\Home\Index.cshtml"
   Write(Configuration["TestApp:Settings:Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
