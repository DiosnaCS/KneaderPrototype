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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CMS/DetailSection.cshtml")]
    public partial class _Views_CMS_DetailSection_cshtml : System.Web.Mvc.WebViewPage<KneaderPrototype.Models.Section>
    {
        public _Views_CMS_DetailSection_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\CMS\DetailSection.cshtml"
  
    ViewBag.Title = "DetailSection";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Detail Section</h2>\r\n\r\n<div>\r\n    <h4>Section</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayFor(model => model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 26 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleId));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayFor(model => model.ArticleId));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayNameFor(model => model.Role));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayFor(model => model.Role));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayNameFor(model => model.BakeryId));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\CMS\DetailSection.cshtml"
       Write(Html.DisplayFor(model => model.BakeryId));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 56 "..\..\Views\CMS\DetailSection.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("    ");

            
            #line 57 "..\..\Views\CMS\DetailSection.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n");

        }
    }
}
#pragma warning restore 1591
