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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Compatibility.cshtml")]
    public partial class _Views_Home_Compatibility_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Compatibility_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\Home\Compatibility.cshtml"
  
    ViewBag.Title = "Order";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Under development</h2>\r\n\r\n<div");

WriteLiteral(" class=\"jumbotron\"");

WriteLiteral(">\r\n    <p>\r\n       System is under production so please be patient<br />\r\n       " +
"Chrome well-comptible browser so use it please<br />\r\n    </p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 238), Tuple.Create("\"", 252)
, Tuple.Create(Tuple.Create("", 245), Tuple.Create<System.Object, System.Int32>(Href("~/Home/")
, 245), false)
);

WriteLiteral(" class=\"btn-primary btn-lg\"");

WriteLiteral(">Back to hompepage</a>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
