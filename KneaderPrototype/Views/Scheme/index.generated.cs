﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using KneaderPrototype;
    using KneaderPrototype.Controllers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Scheme/index.cshtml")]
    public partial class _Views_Scheme_index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Scheme_index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral(@"<script>
    var i = 0;
    $(document).ready(function autreload() {
        load();
        setInterval(""autoreload()"", 20000);
    });
    function reload() {
        load();
    }
    function load() {
        var d = new Date();
        document.getElementById(""schema"").src = ""/scheme/getImage?514561"" + d.getTime();
    }
</script>
<h4>");

            
            #line 15 "..\..\Views\Scheme\index.cshtml"
Write(ViewBag.name);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n<div");

WriteLiteral(" onclick=\"reload()\"");

WriteLiteral(">\r\n    <img");

WriteLiteral(" id=\"schema\"");

WriteLiteral(" src=\"/scheme/getImage\"");

WriteLiteral(" />\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
