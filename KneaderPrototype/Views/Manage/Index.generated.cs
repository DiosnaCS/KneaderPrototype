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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Manage/Index.cshtml")]
    public partial class _Views_Manage_Index_cshtml : System.Web.Mvc.WebViewPage<KneaderPrototype.Models.IndexViewModel>
    {
        public _Views_Manage_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Manage\Index.cshtml"
  
    ViewBag.Title = "Manage";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>");

            
            #line 6 "..\..\Views\Manage\Index.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h2>\r\n\r\n<p");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Manage\Index.cshtml"
                   Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n<div>\r\n    <h4>Change your account settings</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>Password:</dt>\r\n        <dd>\r\n            [\r\n");

            
            #line 16 "..\..\Views\Manage\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Manage\Index.cshtml"
             if (Model.HasPassword)
            {
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Manage\Index.cshtml"
           Write(Html.ActionLink("Change your password", "ChangePassword"));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Manage\Index.cshtml"
                                                                          
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Manage\Index.cshtml"
           Write(Html.ActionLink("Create", "SetPassword"));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Manage\Index.cshtml"
                                                         
            }

            
            #line default
            #line hidden
WriteLiteral("            ]\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591