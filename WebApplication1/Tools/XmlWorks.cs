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
        ////////////////////////////////////
        public static bool setCustomerNameByCid(string cid, string input)
        {
            if (input.Length > 50) return false;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement customers = (XmlElement)root.GetElementsByTagName("Customers")[0];
            foreach (XmlElement elem in customers)
            {
                if (elem.GetAttribute("cid") == cid) 
                {
                    elem.SetAttribute("Name", input);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    if (elem.GetAttribute("Name") == input) return true;
                }
            }
            return false;
        }

        public static bool setCustomerPhoneByCid(string cid, string input)
        {
            if (input.Length > 16) return false;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement customers = (XmlElement)root.GetElementsByTagName("Customers")[0];
            foreach (XmlElement elem in customers)
            {
                if (elem.GetAttribute("cid") == cid)
                {
                    elem.SetAttribute("Phone", input);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    if (elem.GetAttribute("Phone") == input) return true;
                }
            }
            return false;
        }

        public static bool setCustomerEmailByCid(string cid, string input)
        {
            if (input.Length > 50) return false;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement customers = (XmlElement)root.GetElementsByTagName("Customers")[0];
            foreach (XmlElement elem in customers)
            {
                if (elem.GetAttribute("cid") == cid)
                {
                    elem.SetAttribute("Email", input);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    if (elem.GetAttribute("Email") == input) return true;
                }
            }
            return false;
        }

        public static bool setCustomerBirdateByCid(string cid, string input)
        {
            if (input.Length > 10) return false;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement customers = (XmlElement)root.GetElementsByTagName("Customers")[0];
            foreach (XmlElement elem in customers)
            {
                if (elem.GetAttribute("cid") == cid)
                {
                    elem.SetAttribute("Birdate", input);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    if (elem.GetAttribute("Birdate") == input) return true;
                }
            }
            return false;
        }

        ///////////////////////

        public static bool setOrderStatusByOid(string oid, string input)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
            foreach (XmlElement elem in orders)
            {
                if (elem.GetAttribute("oid") == oid)
                {
                    elem.SetAttribute("Status", input);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    if (elem.GetAttribute("Status") == input) return true;

                }
            }
            return false;
        }

        public static bool setOrderValueByOid(string oid, string input)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
            foreach (XmlElement elem in orders)
            {
                if (elem.GetAttribute("oid") == oid)
                {
                    elem.SetAttribute("Value", input);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    if (elem.GetAttribute("Value") == input) return true;
                }

            }
            return false;
        }

        public static bool setOrderDateByOid(string oid, string input)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            XmlElement root = xDoc.DocumentElement;
            XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
            foreach (XmlElement elem in orders)
            {
                if (elem.GetAttribute("oid") == oid)
                {
                    elem.SetAttribute("Regdate", input);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    if (elem.GetAttribute("Regdate") == input) return true;
                }

            }
            return false;
        }



    }
}