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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Error.cshtml")]
    public partial class _Views_Shared_Error_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Error_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\Shared\Error.cshtml"
  
    ViewBag.Title = "Error";
    MvcApplication.ErrorId++;
    Exception error = Server.GetLastError();
    Server.ClearError();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">Error:</h4>\r\n<h5");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">Id: ");

            
            #line 10 "..\..\Views\Shared\Error.cshtml"
                       Write(MvcApplication.ErrorId);

            
            #line default
            #line hidden
WriteLiteral(" At: ");

            
            #line 10 "..\..\Views\Shared\Error.cshtml"
                                                   Write(DateTime.Now.ToShortTimeString());

            
            #line default
            #line hidden
WriteLiteral(" Happened on: ");

            
            #line 10 "..\..\Views\Shared\Error.cshtml"
                                                                                                  Write(DateTime.Now.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral(" <br>\r\n    Occured so please try it again after some time</h5>\r\n");

            
            #line 12 "..\..\Views\Shared\Error.cshtml"
   
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\Error.cshtml"
    if (error != null)
   {

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        Error: ");

            
            #line 15 "..\..\Views\Shared\Error.cshtml"
          Write(error.Message.ToString());

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n        Stack trace: ");

            
            #line 16 "..\..\Views\Shared\Error.cshtml"
                Write(error.StackTrace.ToString());

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n        Inner exception: ");

            
            #line 17 "..\..\Views\Shared\Error.cshtml"
                    Write(error.InnerException.ToString());

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n        Source: ");

            
            #line 18 "..\..\Views\Shared\Error.cshtml"
           Write(error.Source.ToString());

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n        HResult: ");

            
            #line 19 "..\..\Views\Shared\Error.cshtml"
            Write(error.HResult.ToString());

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n        Other: ");

            
            #line 20 "..\..\Views\Shared\Error.cshtml"
          Write(error.HelpLink.ToString());

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 20 "..\..\Views\Shared\Error.cshtml"
                                        Write(error.Data.ToString());

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    </div>\r\n");

            
            #line 22 "..\..\Views\Shared\Error.cshtml"
   }

            
            #line default
            #line hidden
WriteLiteral("<a");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" href=\"/Account/Login\"");

WriteLiteral(">Please try again login for second try</a>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
