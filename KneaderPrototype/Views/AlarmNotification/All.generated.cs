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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AlarmNotification/All.cshtml")]
    public partial class _Views_AlarmNotification_All_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_AlarmNotification_All_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\AlarmNotification\All.cshtml"
  
    ViewBag.Title = "Notification from alarms";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Notification from alarms</h2>\r\n<div");

WriteLiteral(" class=\"bottom\"");

WriteLiteral(">\r\n    Check checkbox of deisired alarms\r\n\r\n");

            
            #line 10 "..\..\Views\AlarmNotification\All.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\AlarmNotification\All.cshtml"
         using (Html.BeginForm("NewNotification", "AlarmNotification", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <table");

WriteLiteral(" class=\"table table-striped table-bordered table-condensed table-hover\"");

WriteLiteral(">\r\n                <tr>\r\n                    <th></th>\r\n                    <th>I" +
"d</th>\r\n                    <th>Alarm Label</th>\r\n                </tr>\r\n");

            
            #line 18 "..\..\Views\AlarmNotification\All.cshtml"
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\AlarmNotification\All.cshtml"
                 foreach (KneaderPrototype.AlarmNotificationHandler.alarm_texts Alarm in ViewBag.Alarms)
                {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td><input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 785), Tuple.Create("\"", 801)
            
            #line 21 "..\..\Views\AlarmNotification\All.cshtml"
, Tuple.Create(Tuple.Create("", 792), Tuple.Create<System.Object, System.Int32>(Alarm.id
            
            #line default
            #line hidden
, 792), false)
);

WriteLiteral(">");

WriteLiteral("</td>\r\n                    <td>");

            
            #line 22 "..\..\Views\AlarmNotification\All.cshtml"
                   Write(Alarm.id);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 23 "..\..\Views\AlarmNotification\All.cshtml"
                   Write(Alarm.title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 25 "..\..\Views\AlarmNotification\All.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </table>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary btn-sm\"");

WriteLiteral(" \" value=\"Save Notification\" />\r\n                </div>\r\n                <div cla" +
"ss=\"col-md-10\">\r\n                    <a href=\"/Alarm/\"");

WriteLiteral(" class=\"btn btn-primary btn-sm\"");

WriteLiteral(">Back</a>\r\n");

WriteLiteral("                </div>\r\n");

WriteLiteral("             </div>\r\n");

WriteLiteral("        </div>\r\n");

            
            #line 38 "..\..\Views\AlarmNotification\All.cshtml"
       }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
