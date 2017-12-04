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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Notification/Index.cshtml")]
    public partial class _Views_Notification_Index_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<KneaderPrototype.Controllers.Notification>>
    {
        public _Views_Notification_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Notification\Index.cshtml"
  
    string alarmName = string.Empty;
    string graphName = string.Empty;
    ViewBag.Title = "Notification center";
    ViewBag.names = Session["names"];
    ViewBag.plc = Session["plc"];
    foreach (string name in ViewBag.names)
    {
        if (name.ToLower().Contains("alarm"))
        {
            alarmName = name;
        }
        if (name.ToLower().Contains("graph"))
        {
            graphName = name;
        }
    }
    var list = Model.ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>Notification center</h4>\r\n");

            
            #line 24 "..\..\Views\Notification\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Notification\Index.cshtml"
     if (list.Count >= 1)
    {

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"table col-md-1\"");

WriteLiteral(">\r\n            <tr>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ProjectName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 32 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BakeryID));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Definition));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 41 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TimestampCreated));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Active));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 47 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Detail));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 50 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Occurred));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>\r\n");

WriteLiteral("                    ");

            
            #line 53 "..\..\Views\Notification\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <th>Actions</th>\r\n            </tr>\r\n\r\n");

            
            #line 58 "..\..\Views\Notification\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Notification\Index.cshtml"
             foreach (var item in Model)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 62 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProjectName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 65 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BakeryID));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 68 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 71 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Definition));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 74 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TimestampCreated));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 77 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Active));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 80 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Detail));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 83 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Occurred));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 86 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 89 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("                        ");

            
            #line 90 "..\..\Views\Notification\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 93 "..\..\Views\Notification\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 95 "..\..\Views\Notification\Index.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">\r\n            You don\'t have defined any notifications<br>\r\n        </div>\r\n");

            
            #line 101 "..\..\Views\Notification\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591