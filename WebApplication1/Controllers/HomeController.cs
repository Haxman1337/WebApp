using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Tools;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            while (true)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");

                    return View("Customers", xDoc.DocumentElement);
                }
                catch (Exception e)
                {
                }
            }
        }

        public ActionResult Orders()
        {
            while (true)
            {
                try 
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
                    return View("Orders", (XmlElement)xDoc.SelectSingleNode("root/Orders"));
                } 
                catch (Exception e) 
                {
                }
            }
        }
    }
}