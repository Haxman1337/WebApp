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
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static string getOrderStatusByCoid(string coid)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static string getOrderValueByCoid(string coid)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static string getOrderRegdateByCoid(string coid)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static string getCustomerNameByCoid(string coid)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static string getCustomerIdByCoid(string coid)
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement root = xDoc.DocumentElement;
                    XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
                    foreach (XmlElement elem in orders)
                    {
                        if (elem.GetAttribute("oid") == coid) return elem.GetAttribute("Customer");
                    }
                    return "";

                }
                catch
                {

                }
            }
        }
        ////////////////////////////////////
        public static bool setCustomerNameByCid(string cid, string input)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static bool setCustomerPhoneByCid(string cid, string input)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static bool setCustomerEmailByCid(string cid, string input)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static bool setCustomerBirdateByCid(string cid, string input)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        ///////////////////////

        public static bool setOrderStatusByOid(string oid, string input)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static bool setOrderValueByOid(string oid, string input)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }

        public static bool setOrderDateByOid(string oid, string input)
        {
            while (true)
            {
                try
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
                catch
                {

                }
            }
        }
        /////////

        public static void createOrder(string cid, string orderStatus, string orderValue, string orderDate)
        {
            while (true)
            {
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement root = xDoc.DocumentElement;
                    XmlElement orders = (XmlElement)root.GetElementsByTagName("Orders")[0];
                    XmlElement customers = (XmlElement)root.GetElementsByTagName("Customers")[0];
                    XmlElement neededToGetId = (XmlElement)orders.LastChild;
                    string orderId = (int.Parse(neededToGetId.GetAttribute("oid")) + 1).ToString();
                    string order = "<Order oid=\"" + orderId + "\" Customer=\"" + cid + "\" Value=\"" + orderValue + "\" Regdate=\"" + orderDate + "\" Status=\"" + orderStatus + "\" />";
                    orders.InnerXml += order;
                    foreach (XmlElement customer in customers)
                    {
                        if (customer.GetAttribute("cid") == cid)
                        {
                            customer.GetElementsByTagName("COrders")[0].InnerXml += "<Corder coid=\"" + orderId + "\" />"; ;
                        }
                    }
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    break;
                }
                catch
                {

                }
            }
        }

        public static void createCustomer(string name, string birdate, string email, string phone, string regdate)
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement customers = (XmlElement)xDoc.SelectSingleNode("root/Customers"); ;
                    XmlElement neededToGetId = (XmlElement)customers.LastChild;
                    string cid = (int.Parse(neededToGetId.GetAttribute("cid")) + 1).ToString();
                    customers.InnerXml += "<Customer cid=\"" + cid + "\" Name=\"" + name + "\" Birdate=\"" + birdate + "\" Email=\"" + email + "\" Phone=\"" + phone + "\" Regdate=\"" + regdate + "\"><COrders></COrders></Customer>";
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    break;
                }
                catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }

        public static void removeOrder(string oid)
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement root = xDoc.DocumentElement;
                    string cid = "undefined";
                    XmlNode order = root.SelectSingleNode("Orders/Order[@oid='" + oid + "']");
                    if (order != null)
                    {
                        cid = (order as XmlElement).GetAttribute("Customer");
                        XmlNode parent = order.ParentNode;
                        parent.RemoveChild(order);
                    }
                    XmlNode customerOrd = root.SelectSingleNode("Customers/Customer[@cid='" + cid + "']/COrders/Corder[@coid='" + oid + "']");
                    if (customerOrd != null)
                    {
                        XmlNode parent = customerOrd.ParentNode;
                        parent.RemoveChild(customerOrd);
                    }
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    break;
                }
                catch
                {

                }
            }
        }

        public static void removeCustomer(string cid)
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement root = xDoc.DocumentElement;
                    List<string> ordersid = new List<string>();
                    List<XmlElement> ordersToRemove = new List<XmlElement>();
                    XmlNode customer = root.SelectSingleNode("Customers/Customer[@cid='" + cid + "']");
                    if (customer != null)
                    {
                        XmlNode COrders = root.SelectSingleNode("Customers/Customer[@cid='" + cid + "']/COrders");
                        foreach (XmlElement order in COrders)
                        {
                            ordersid.Add(order.GetAttribute("coid"));
                        }
                        XmlNode parent = customer.ParentNode;
                        parent.RemoveChild(customer);
                    }
                    XmlNode orders = root.SelectSingleNode("Orders");
                    if (orders != null)
                    {
                        foreach (XmlElement order in orders)
                        {
                            if (ordersid.Contains(order.GetAttribute("oid"))) ordersToRemove.Add(order);
                        }
                        foreach (XmlElement order in ordersToRemove)
                        {
                            orders.RemoveChild(order);
                        }
                    }
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    break;
                }
                catch
                {

                }
            }
        }

        ///////////////

        public static XmlNode getCustomerNodeById(string cid)
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement root = xDoc.DocumentElement;
                    return root.SelectSingleNode("Customers/Customer[@cid='" + cid + "']");

                }
                catch
                {

                }
            }
        }

        public static XmlNode getOrderNodeById(string oid)
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement root = xDoc.DocumentElement;
                    return root.SelectSingleNode("Orders/Order[@oid='" + oid + "']");
                }
                catch
                {

                }
            }
        }

        /////////////

        public static void changeOrderCustomer(string oid, string cid)
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    XmlElement root = xDoc.DocumentElement;
                    XmlNode customer = root.SelectSingleNode("Customers/Customer[@cid='" + getCustomerIdByCoid(oid) + "']");
                    XmlNode neededCOrder = customer.SelectSingleNode("COrders/Corder[@coid='" + oid + "']");
                    XmlNode neededOrder = root.SelectSingleNode("Orders/Order[@oid='" + oid + "']");
                    XmlNode neededCOrders = root.SelectSingleNode("Customers/Customer[@cid='" + cid + "']/COrders");
                    neededCOrders.AppendChild(neededCOrder);
                    (neededOrder as XmlElement).SetAttribute("Customer", cid);
                    xDoc.Save(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    break;
                }
                catch
                {

                }
            }
        }
    }
}