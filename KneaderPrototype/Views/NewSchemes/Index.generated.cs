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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NewSchemes/Index.cshtml")]
    public partial class _Views_NewSchemes_Index_cshtml : System.Web.Mvc.WebViewPage<KneaderPrototype.Sheme.Models.SchemeEditor>
    {
        public _Views_NewSchemes_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\NewSchemes\Index.cshtml"
  
    ViewBag.Title = "Scheme Editor";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>New scheme</h2>\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 121), Tuple.Create("\"", 150)
, Tuple.Create(Tuple.Create("", 127), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/NewSchemes.js")
, 127), false)
);

WriteLiteral(" ></script>\r\n<div");

WriteLiteral(" onclick=\"getValues()\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\NewSchemes\Index.cshtml"
Write(Html.Raw(File.ReadAllText(Server.MapPath(Model.relativePath))));

            
            #line default
            #line hidden
WriteLiteral("\r\n  <object");

WriteLiteral(" type=\"image/svg+xml\"");

WriteAttribute("data", Tuple.Create(" data=\"", 292), Tuple.Create("\"", 318)
            
            #line 10 "..\..\Views\NewSchemes\Index.cshtml"
, Tuple.Create(Tuple.Create("", 299), Tuple.Create<System.Object, System.Int32>(Model.relativePath
            
            #line default
            #line hidden
, 299), false)
);

WriteLiteral(">\r\n      Your object does not suupport SVG\r\n  </object>\r\n</div>");

        }
    }
}
#pragma warning restore 1591