using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Tools;

namespace WebApplication1.Controllers
{
    public class APIController : Controller
    {
        // GET: API
        public string Index()
        {
            return "OOGA BOOGA";
        }
        public string SetCustomerName(ControllerContext controllerContext)
        {
            if (XmlWorks.setCustomerNameByCid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }

        public string SetCustomerPhone(ControllerContext controllerContext)
        {
            if (XmlWorks.setCustomerPhoneByCid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }

        public string SetCustomerEmail(ControllerContext controllerContext)
        {
            if (XmlWorks.setCustomerEmailByCid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }

        public string SetCustomerBirdate(ControllerContext controllerContext)
        {
            if (XmlWorks.setCustomerBirdateByCid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }
        //////////////////////////////
        public string SetOrderStatus(ControllerContext controllerContext)
        {
            if (XmlWorks.setOrderStatusByOid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }

        public string SetOrderRegdate(ControllerContext controllerContext)
        {
            if (XmlWorks.setOrderDateByOid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }

        public string SetOrderValue(ControllerContext controllerContext)
        {
            if (XmlWorks.setOrderValueByOid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }
    }
}