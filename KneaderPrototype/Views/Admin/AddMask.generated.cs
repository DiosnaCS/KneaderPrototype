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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Admin/AddMask.cshtml")]
    public partial class _Views_Admin_AddMask_cshtml : System.Web.Mvc.WebViewPage<KneaderPrototype.Admin.Models.AdminAddMaskModel>
    {
        public _Views_Admin_AddMask_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Admin\AddMask.cshtml"
  
    ViewBag.Title = "Add Mask of file";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Add Mask of file</h2>\r\n\r\n<div");

WriteLiteral(" class=\"message\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Admin\AddMask.cshtml"
Write(ViewBag.message);

            
            #line default
            #line hidden
WriteLiteral("\r\n    <b>Masks for current bakery:</b><br>\r\n");

            
            #line 11 "..\..\Views\Admin\AddMask.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Admin\AddMask.cshtml"
     foreach (string mask in ViewBag.masks)
    {
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Admin\AddMask.cshtml"
   Write(mask);

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n");

            
            #line 14 "..\..\Views\Admin\AddMask.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <b>All roles in the system:</b><br>\r\n");

            
            #line 16 "..\..\Views\Admin\AddMask.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Admin\AddMask.cshtml"
     foreach (var role in ViewBag.roles)
    {
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Admin\AddMask.cshtml"
   Write(role);

            
            #line default
            #line hidden
WriteLiteral(" <br>\r\n");

            
            #line 19 "..\..\Views\Admin\AddMask.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 21 "..\..\Views\Admin\AddMask.cshtml"
 using (Html.BeginForm("AddMaskForm", "Admin", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 24 "..\..\Views\Admin\AddMask.cshtml"
   Write(Html.LabelFor(m => m.bakeryId, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 26 "..\..\Views\Admin\AddMask.cshtml"
       Write(Html.TextBoxFor(m => m.bakeryId, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 30 "..\..\Views\Admin\AddMask.cshtml"
   Write(Html.LabelFor(m => m.maskName, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Admin\AddMask.cshtml"
       Write(Html.TextBoxFor(m => m.maskName, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 36 "..\..\Views\Admin\AddMask.cshtml"
   Write(Html.LabelFor(m => m.maskRole, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\Admin\AddMask.cshtml"
       Write(Html.TextBoxFor(m => m.maskRole, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 42 "..\..\Views\Admin\AddMask.cshtml"
   Write(Html.LabelFor(m => m.Mask, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\Admin\AddMask.cshtml"
       Write(Html.TextBoxFor(m => m.Mask, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Send\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n");

            
            #line 52 "..\..\Views\Admin\AddMask.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
