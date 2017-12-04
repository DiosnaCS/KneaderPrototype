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
    
    #line 2 "..\..\Views\ReportOverview\Index.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    
    #line 1 "..\..\Views\ReportOverview\Index.cshtml"
    using System.Threading;
    
    #line default
    #line hidden
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ReportOverview/Index.cshtml")]
    public partial class _Views_ReportOverview_Index_cshtml : System.Web.Mvc.WebViewPage<KneaderPrototype.Report.Models.OverviewReportModel>
    {
        public _Views_ReportOverview_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\ReportOverview\Index.cshtml"
  
    ViewBag.Title = "Index";
    string name = string.Empty;
    int EndType = 0;
    int amntTotal = 0;
    bool thMotherCulture = false;
    bool thFlour = false;
    bool thWater= false;
    bool thOldBread = false;
    bool thLiquidYeast = false;
    bool thMixture = false;
    bool thGeneric = false;
    int countHeades = 0;
    int countOverall = 0;
    int year = ViewBag.year;
    int monthLess = ViewBag.Month - 1;
    int monthMore = ViewBag.Month + 1;
    if (monthLess < 1)
    {
        year--;
        monthLess = 12;
    }
    if (monthMore > 12)
    {
        year++;
        monthMore = 1;
    }
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
    DateTime monthDT = new DateTime(year, ViewBag.month, 1);
    string monthName = monthDT.ToString("MMMM");


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Cunsumption Report</h2>\r\n\r\n<div");

WriteLiteral(" class=\" col-md-10\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"btn-primary btn-xs\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1035), Tuple.Create("\"", 1080)
, Tuple.Create(Tuple.Create("", 1042), Tuple.Create("/ReportOverview/Month/", 1042), true)
            
            #line 41 "..\..\Views\ReportOverview\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1064), Tuple.Create<System.Object, System.Int32>(monthLess
            
            #line default
            #line hidden
, 1064), false)
, Tuple.Create(Tuple.Create("", 1074), Tuple.Create("/", 1074), true)
            
            #line 41 "..\..\Views\ReportOverview\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1075), Tuple.Create<System.Object, System.Int32>(year
            
            #line default
            #line hidden
, 1075), false)
);

WriteLiteral(">-1 month</a> Month: ");

            
            #line 41 "..\..\Views\ReportOverview\Index.cshtml"
                                                                                               Write(monthName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 41 "..\..\Views\ReportOverview\Index.cshtml"
                                                                                                          Write(year);

            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" class=\"btn-primary btn-xs\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1148), Tuple.Create("\"", 1193)
, Tuple.Create(Tuple.Create("", 1155), Tuple.Create("/ReportOverview/Month/", 1155), true)
            
            #line 41 "..\..\Views\ReportOverview\Index.cshtml"
                                                                                               , Tuple.Create(Tuple.Create("", 1177), Tuple.Create<System.Object, System.Int32>(monthMore
            
            #line default
            #line hidden
, 1177), false)
, Tuple.Create(Tuple.Create("", 1187), Tuple.Create("/", 1187), true)
            
            #line 41 "..\..\Views\ReportOverview\Index.cshtml"
                                                                                                          , Tuple.Create(Tuple.Create("", 1188), Tuple.Create<System.Object, System.Int32>(year
            
            #line default
            #line hidden
, 1188), false)
);

WriteLiteral(">+1 month</a>\r\n    <p></p>\r\n</div>\r\n");

            
            #line 44 "..\..\Views\ReportOverview\Index.cshtml"
 if (Model.Data.Count != 0 && Model.Data.All(p => p.day !=  0))
{

            
            #line default
            #line hidden
WriteLiteral("<table");

WriteLiteral(" class=\"table-bordered table-condensed table-report\"");

WriteLiteral(" id=\"cunsumptionTable\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr >\r\n            <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Day</th>\r\n");

            
            #line 50 "..\..\Views\ReportOverview\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\ReportOverview\Index.cshtml"
             if (Model.Data.Max(p => p.MotherCultureBatchCount > 0))
            {
                
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\ReportOverview\Index.cshtml"
                  thMotherCulture = true; 
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\ReportOverview\Index.cshtml"
                                           

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Mother culture</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"th-Report\"");

WriteLiteral("></th>\r\n");

            
            #line 55 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 56 "..\..\Views\ReportOverview\Index.cshtml"
             if (Model.Data.Max(p => p.FlourBatchCount > 0))
            {
                
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\ReportOverview\Index.cshtml"
                  thFlour = true; 
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\ReportOverview\Index.cshtml"
                                   

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Flour</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"th-Report\"");

WriteLiteral("></th>\r\n");

            
            #line 61 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 62 "..\..\Views\ReportOverview\Index.cshtml"
             if (Model.Data.Max(p => p.WaterBatchCount > 0))
            {
                
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\ReportOverview\Index.cshtml"
                  thWater = true; 
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\ReportOverview\Index.cshtml"
                                   

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Water</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"th-Report\"");

WriteLiteral("></th>\r\n");

            
            #line 67 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 68 "..\..\Views\ReportOverview\Index.cshtml"
             if (Model.Data.Max(p => p.OldBreadBatchCount > 0))
            {
                
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\ReportOverview\Index.cshtml"
                  thOldBread = true; 
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\ReportOverview\Index.cshtml"
                                      

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Old Bread</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"th-Report\"");

WriteLiteral("></th>\r\n");

            
            #line 73 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 74 "..\..\Views\ReportOverview\Index.cshtml"
             if (Model.Data.Max(p => p.LiquidYeastBatchCount > 0))
            {
                
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\ReportOverview\Index.cshtml"
                  thLiquidYeast = true; 
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\ReportOverview\Index.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Liquid yeast</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"th-Report\"");

WriteLiteral("></th>\r\n");

            
            #line 79 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 80 "..\..\Views\ReportOverview\Index.cshtml"
             if (Model.Data.Max(p => p.MixtureBatchCount > 0))
            {
                
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\ReportOverview\Index.cshtml"
                  thMixture = true; 
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\ReportOverview\Index.cshtml"
                                     

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Mixture</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"th-Report\"");

WriteLiteral("></th>\r\n");

            
            #line 85 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 86 "..\..\Views\ReportOverview\Index.cshtml"
             if (Model.Data.Max(p => p.GenericBatchCount > 0))
            {
                
            
            #line default
            #line hidden
            
            #line 88 "..\..\Views\ReportOverview\Index.cshtml"
                  thGeneric = true; 
            
            #line default
            #line hidden
            
            #line 88 "..\..\Views\ReportOverview\Index.cshtml"
                                     

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" style=\"min-width: 90px;\"");

WriteLiteral(">Generic component</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"th-Report\"");

WriteLiteral("></th>\r\n");

            
            #line 91 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n");

            
            #line 94 "..\..\Views\ReportOverview\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\ReportOverview\Index.cshtml"
     for (int day = 1; day <= DateTime.DaysInMonth(year, ViewBag.month); day++)
    {
        
            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\ReportOverview\Index.cshtml"
           DateTime dayDT = new DateTime(year, ViewBag.month, day); string sDay = dayDT.DayOfWeek.ToString();  
            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\ReportOverview\Index.cshtml"
                                                                                                                
                
            
            #line default
            #line hidden
            
            #line 97 "..\..\Views\ReportOverview\Index.cshtml"
                   string colourRowClass = string.Empty;
                    if (dayDT.DayOfWeek == DayOfWeek.Saturday || dayDT.DayOfWeek == DayOfWeek.Sunday) {
                        colourRowClass = "coloured";
                    }
                    else {
                        colourRowClass = "not-coloured";
                    } 
            
            #line default
            #line hidden
            
            #line 103 "..\..\Views\ReportOverview\Index.cshtml"
                       

            
            #line default
            #line hidden
WriteLiteral("            <tr");

WriteAttribute("class", Tuple.Create(" class=\"", 3750), Tuple.Create("\"", 3773)
            
            #line 104 "..\..\Views\ReportOverview\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3758), Tuple.Create<System.Object, System.Int32>(colourRowClass
            
            #line default
            #line hidden
, 3758), false)
);

WriteLiteral(">\r\n                    <td>");

            
            #line 105 "..\..\Views\ReportOverview\Index.cshtml"
                   Write(day);

            
            #line default
            #line hidden
WriteLiteral(". ");

            
            #line 105 "..\..\Views\ReportOverview\Index.cshtml"
                         Write(sDay);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 106 "..\..\Views\ReportOverview\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 106 "..\..\Views\ReportOverview\Index.cshtml"
                 if (Model.Data.Exists(p => p.day == day))
                {
                    if (thMotherCulture == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");

            
            #line 110 "..\..\Views\ReportOverview\Index.cshtml"
                        Write(Model.Data.Where(p => p.day == day).Sum(p => p.MotherCultureAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        <td>");

            
            #line 111 "..\..\Views\ReportOverview\Index.cshtml"
                       Write(Model.Data.Where(p => p.day == day).Sum(p => p.MotherCultureBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 112 "..\..\Views\ReportOverview\Index.cshtml"
                    }
                    if (thFlour == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");

            
            #line 115 "..\..\Views\ReportOverview\Index.cshtml"
                        Write(Model.Data.Where(p => p.day == day).Sum(p => p.FlourAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        <td>");

            
            #line 116 "..\..\Views\ReportOverview\Index.cshtml"
                       Write(Model.Data.Where(p => p.day == day).Sum(p => p.FlourBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 117 "..\..\Views\ReportOverview\Index.cshtml"
                    }
                    if (thWater == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");

            
            #line 120 "..\..\Views\ReportOverview\Index.cshtml"
                        Write(Model.Data.Where(p => p.day == day).Sum(p => p.WaterAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        <td>");

            
            #line 121 "..\..\Views\ReportOverview\Index.cshtml"
                       Write(Model.Data.Where(p => p.day == day).Sum(p => p.WaterBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 122 "..\..\Views\ReportOverview\Index.cshtml"
                    }
                    if (thOldBread == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");

            
            #line 125 "..\..\Views\ReportOverview\Index.cshtml"
                        Write(Model.Data.Where(p => p.day == day).Sum(p => p.OldBreadAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        <td>");

            
            #line 126 "..\..\Views\ReportOverview\Index.cshtml"
                       Write(Model.Data.Where(p => p.day == day).Sum(p => p.OldBreadBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 127 "..\..\Views\ReportOverview\Index.cshtml"
                    }
                    if (thLiquidYeast == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");

            
            #line 130 "..\..\Views\ReportOverview\Index.cshtml"
                        Write(Model.Data.Where(p => p.day == day).Sum(p => p.LiquidYeastAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        <td>");

            
            #line 131 "..\..\Views\ReportOverview\Index.cshtml"
                       Write(Model.Data.Where(p => p.day == day).Sum(p => p.LiquidYeastBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 132 "..\..\Views\ReportOverview\Index.cshtml"
                    }
                    if (thMixture == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");

            
            #line 135 "..\..\Views\ReportOverview\Index.cshtml"
                        Write(Model.Data.Where(p => p.day == day).Sum(p => p.MixtureAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        <td>");

            
            #line 136 "..\..\Views\ReportOverview\Index.cshtml"
                       Write(Model.Data.Where(p => p.day == day).Sum(p => p.MixtureBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 137 "..\..\Views\ReportOverview\Index.cshtml"
                    }
                    if (thGeneric == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");

            
            #line 140 "..\..\Views\ReportOverview\Index.cshtml"
                        Write(Model.Data.Where(p => p.day == day).Sum(p => p.GenericAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                        <td>");

            
            #line 141 "..\..\Views\ReportOverview\Index.cshtml"
                       Write(Model.Data.Where(p => p.day == day).Sum(p => p.GenericBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 142 "..\..\Views\ReportOverview\Index.cshtml"
                    }
                }
                else
                {
                    if (thMotherCulture == true) {
            
            #line default
            #line hidden
WriteLiteral(" <td></td>");

WriteLiteral("<td></td> ");

            
            #line 146 "..\..\Views\ReportOverview\Index.cshtml"
                                                                      }
                    if (thFlour == true) {
            
            #line default
            #line hidden
WriteLiteral(" <td></td>");

WriteLiteral("<td></td> ");

            
            #line 147 "..\..\Views\ReportOverview\Index.cshtml"
                                                              }
                    if (thWater == true) {
            
            #line default
            #line hidden
WriteLiteral("<td></td>");

WriteLiteral("<td></td> ");

            
            #line 148 "..\..\Views\ReportOverview\Index.cshtml"
                                                             }
                    if (thOldBread == true) {
            
            #line default
            #line hidden
WriteLiteral("  <td></td>");

WriteLiteral("<td></td> ");

            
            #line 149 "..\..\Views\ReportOverview\Index.cshtml"
                                                                  }
                    if (thLiquidYeast == true) {
            
            #line default
            #line hidden
WriteLiteral("  <td></td>");

WriteLiteral("<td></td> ");

            
            #line 150 "..\..\Views\ReportOverview\Index.cshtml"
                                                                     }
                    if (thMixture == true) {
            
            #line default
            #line hidden
WriteLiteral(" <td></td>");

WriteLiteral("<td></td> ");

            
            #line 151 "..\..\Views\ReportOverview\Index.cshtml"
                                                                }
                    if (thGeneric == true) {
            
            #line default
            #line hidden
WriteLiteral(" <td></td>");

WriteLiteral("<td></td> ");

            
            #line 152 "..\..\Views\ReportOverview\Index.cshtml"
                                                                }
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 155 "..\..\Views\ReportOverview\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td><b>Summary</b></td>\r\n");

            
            #line 158 "..\..\Views\ReportOverview\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 158 "..\..\Views\ReportOverview\Index.cshtml"
         if (thMotherCulture == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td><b>");

            
            #line 160 "..\..\Views\ReportOverview\Index.cshtml"
               Write(Model.Data.Sum(p => p.MotherCultureAmnt)/1000);

            
            #line default
            #line hidden
WriteLiteral(" kg</b></td>\r\n");

WriteLiteral("            <td><b>");

            
            #line 161 "..\..\Views\ReportOverview\Index.cshtml"
              Write(Model.Data.Sum(p => p.MotherCultureBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n");

            
            #line 162 "..\..\Views\ReportOverview\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 163 "..\..\Views\ReportOverview\Index.cshtml"
         if (thFlour == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td><b>");

            
            #line 165 "..\..\Views\ReportOverview\Index.cshtml"
               Write(Model.Data.Sum(p => p.FlourAmnt)/1000);

            
            #line default
            #line hidden
WriteLiteral(" kg</b></td>\r\n");

WriteLiteral("            <td><b>");

            
            #line 166 "..\..\Views\ReportOverview\Index.cshtml"
              Write(Model.Data.Sum(p => p.FlourBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n");

            
            #line 167 "..\..\Views\ReportOverview\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 168 "..\..\Views\ReportOverview\Index.cshtml"
         if (thWater == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td><b>");

            
            #line 170 "..\..\Views\ReportOverview\Index.cshtml"
               Write(Model.Data.Sum(p => p.WaterAmnt)/1000);

            
            #line default
            #line hidden
WriteLiteral(" kg</b></td>\r\n");

WriteLiteral("            <td><b>");

            
            #line 171 "..\..\Views\ReportOverview\Index.cshtml"
              Write(Model.Data.Sum(p => p.WaterBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n");

            
            #line 172 "..\..\Views\ReportOverview\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 173 "..\..\Views\ReportOverview\Index.cshtml"
         if (thLiquidYeast == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td><b>");

            
            #line 175 "..\..\Views\ReportOverview\Index.cshtml"
               Write(Model.Data.Sum(p => p.LiquidYeastAmnt) / 1000);

            
            #line default
            #line hidden
WriteLiteral(" kg</b></td>\r\n");

WriteLiteral("            <td><b>");

            
            #line 176 "..\..\Views\ReportOverview\Index.cshtml"
              Write(Model.Data.Sum(p => p.LiquidYeastBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n");

            
            #line 177 "..\..\Views\ReportOverview\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 178 "..\..\Views\ReportOverview\Index.cshtml"
         if (thMixture == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td><b>");

            
            #line 180 "..\..\Views\ReportOverview\Index.cshtml"
               Write(Model.Data.Sum(p => p.MixtureAmnt)/1000);

            
            #line default
            #line hidden
WriteLiteral(" kg</b></td>\r\n");

WriteLiteral("            <td><b>");

            
            #line 181 "..\..\Views\ReportOverview\Index.cshtml"
              Write(Model.Data.Sum(p => p.MixtureBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n");

            
            #line 182 "..\..\Views\ReportOverview\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 183 "..\..\Views\ReportOverview\Index.cshtml"
         if (thGeneric == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td><b>");

            
            #line 185 "..\..\Views\ReportOverview\Index.cshtml"
               Write(Model.Data.Sum(p => p.GenericAmnt)/1000);

            
            #line default
            #line hidden
WriteLiteral(" kg</b></td>\r\n");

WriteLiteral("            <td><b>");

            
            #line 186 "..\..\Views\ReportOverview\Index.cshtml"
              Write(Model.Data.Sum(p => p.GenericBatchCount));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n");

            
            #line 187 "..\..\Views\ReportOverview\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tr>\r\n</table>\r\n");

            
            #line 190 "..\..\Views\ReportOverview\Index.cshtml"
} else { 

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n");

WriteLiteral("    <h3>No data exists for this month</h3> \r\n");

            
            #line 193 "..\..\Views\ReportOverview\Index.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591