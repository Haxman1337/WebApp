using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WebApplication1.Tools
{
    public static class XmlWorks
    {
        /// <summary>
        /// Gets Client name using their id
        /// Returns empty string if Client not found
        /// </summary>
        /// <param name="oid">Input oid</param>
        /// <returns>Client name</returns>
        public static string getCustomerNameByCid(string cid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement customers = (XmlElement)root.GetElementsByTagName("Customers")[0];
            foreach (XmlElement elem in customers)
            {
                if (elem.GetAttribute("cid") == cid) return elem.GetAttribute("Name");
            }
            return "";
        }
        
        public static string getOrderStatusByCoid(string coid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
            foreach (XmlElement elem in orders)
            {
                if (elem.GetAttribute("oid") == coid) return elem.GetAttribute("Status");
               
            }
            return "";
        }

        public static string getOrderValueByCoid(string coid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
            foreach (XmlElement elem in orders)
            {
                if (elem.GetAttribute("oid") == coid) return elem.GetAttribute("Value");

            }
            return "";
        }

        public static string getOrderRegdateByCoid(string coid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
            foreach (XmlElement elem in orders)
            {
                if (elem.GetAttribute("oid") == coid) return elem.GetAttribute("Regdate");

            }
            return "";
        }

        public static string getCustomerNameByCoid(string coid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
            foreach (XmlElement elem in orders)
            {
                if (elem.GetAttribute("oid") == coid) return getCustomerNameByCid(elem.GetAttribute("Customer"));
            }
            return "";
        }
    }
}