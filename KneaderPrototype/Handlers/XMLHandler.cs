﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace KneaderPrototype
{
    public class XMLHandler
    {
        public static String path = Path.PhysicalPath + @"\Config";

        public static List<String> readTag(String tag, int ProjectNumber)
        {
            List<String> XMLcontentList = new List<string>();
            XmlDocument xml = new XmlDocument();
            String search_pattern = "config_" + ProjectNumber + "*";
            string[] absoulte_path = Directory.GetFiles(path, search_pattern);
            xml.Load(absoulte_path[0]);
            XmlNodeList xnList = xml.SelectNodes("//" + tag);

            foreach (XmlNode xn in xnList)
            {
                XMLcontentList.Add(xn.InnerText);
            }

            return XMLcontentList;
        }
    }
}