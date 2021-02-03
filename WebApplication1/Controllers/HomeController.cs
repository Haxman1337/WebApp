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
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory")+"/test.xml");

            return View("Customers", xDoc.DocumentElement);
        }

        public ActionResult Orders()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppDomain.CurrentDomain.GetData("DataDirectory") + "/test.xml");
            return View("Orders", (XmlElement)xDoc.SelectSingleNode("root/Orders"));
        }
    }
}