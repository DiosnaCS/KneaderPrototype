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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Upload/Index.cshtml")]
    public partial class _Views_Upload_Index_cshtml : System.Web.Mvc.WebViewPage<KneaderPrototype.Upload.Models.UploadFile>
    {
        public _Views_Upload_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Upload\Index.cshtml"
  
    ViewBag.Title = "Index";
    string fileName = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Index of Upload System</h2>\r\n");

            
            #line 8 "..\..\Views\Upload\Index.cshtml"
Write(ViewBag.message);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\Views\Upload\Index.cshtml"
 using (Html.BeginForm("UploadFile", "Upload", FormMethod.Post, new { @class = "form-horizontal", role = "form", enctype = "multipart/form-data" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Upload\Index.cshtml"
   Write(Html.TextBoxFor(m => m.File, new { type = "file" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\Upload\Index.cshtml"
       Write(Html.ValidationMessageFor(m => m.File));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Upload\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Upload\Index.cshtml"
             if (ViewBag.plcName == null)
            {
                
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Upload\Index.cshtml"
           Write(Html.HiddenFor(m => m.plcName, new { Value = Request.QueryString["plc"].ToString() }));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Upload\Index.cshtml"
                                                                                                      
            }
            else {
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Upload\Index.cshtml"
           Write(Html.HiddenFor(m => m.plcName, new { Value = ViewBag.plcName }));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Upload\Index.cshtml"
                                                                                
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" value=\"Upload File\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n");

            
            #line 29 "..\..\Views\Upload\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral(@"<script>
    function show() {

        //var filePath = document.getElementById(""file2"").file[0].fileName;
        var file = document.getElementById(""file2"").value;
        //document.getElementById(""filePathToView2"").innerHTML = filePath;
        document.getElementById(""filePathToView"").innerHTML = file;
}
</script>
<div");

WriteLiteral(" id=\"filePathToView\"");

WriteLiteral(">\r\n</div>\r\n<div");

WriteLiteral(" id=\"filePathToView2\"");

WriteLiteral(">\r\n</div>\r\n<h3>9_Public</h3>\r\n");

            
            #line 44 "..\..\Views\Upload\Index.cshtml"
  
    int i = 0;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 47 "..\..\Views\Upload\Index.cshtml"
 if (ViewBag.fileList != null)
{
    foreach (string file in ViewBag.fileList)
    {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"list-group-item-text\"");

WriteLiteral(">\r\n");

            
            #line 52 "..\..\Views\Upload\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Upload\Index.cshtml"
                   
                    fileName = file.Substring(file.LastIndexOf('/')+1);
                
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 55 "..\..\Views\Upload\Index.cshtml"
           Write(fileName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1745), Tuple.Create("\"", 1789)
, Tuple.Create(Tuple.Create("", 1752), Tuple.Create("/Download/downloadFile?nameFile=", 1752), true)
            
            #line 56 "..\..\Views\Upload\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1784), Tuple.Create<System.Object, System.Int32>(file
            
            #line default
            #line hidden
, 1784), false)
);

WriteLiteral(">Download</a>\r\n");

            
            #line 57 "..\..\Views\Upload\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Upload\Index.cshtml"
                 if (file.Contains(".pdf") || file.Contains(".txt"))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1916), Tuple.Create("\"", 1967)
, Tuple.Create(Tuple.Create("", 1923), Tuple.Create("/Download/downloadFile?nameFile=", 1923), true)
            
            #line 59 "..\..\Views\Upload\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1955), Tuple.Create<System.Object, System.Int32>(file
            
            #line default
            #line hidden
, 1955), false)
, Tuple.Create(Tuple.Create("", 1960), Tuple.Create("&View=1", 1960), true)
);

WriteLiteral(">View</a>");

WriteLiteral("<br>\r\n");

            
            #line 60 "..\..\Views\Upload\Index.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <br>\r\n");

            
            #line 64 "..\..\Views\Upload\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 66 "..\..\Views\Upload\Index.cshtml"
        i++;
    }
}
else {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">No files has been found</div>\r\n");

            
            #line 71 "..\..\Views\Upload\Index.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
