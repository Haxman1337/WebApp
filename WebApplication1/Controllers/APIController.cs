using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            string name = Regex.Unescape(Request.QueryString.Get("param"));
            if (!Validator.isValidName(name)) return "ERRORInvalid name";
            if (XmlWorks.setCustomerNameByCid(Request.QueryString.Get("id"), name)) return "OK";
            return "ERROR";
        }

        public string SetCustomerPhone(ControllerContext controllerContext)
        {
            string phone = Regex.Unescape(Request.QueryString.Get("param"));
            if (!Validator.isValidPhone(phone)) return "ERRORinvalid phone";
            if (XmlWorks.setCustomerPhoneByCid(Request.QueryString.Get("id"), phone)) return "OK";
            return "ERROR";
        }

        public string SetCustomerEmail(ControllerContext controllerContext)
        {
            string email = Request.QueryString.Get("param");
            if (!Validator.isValidEmail(email)) return "ERRORinvalid email";
            if (XmlWorks.setCustomerEmailByCid(Request.QueryString.Get("id"), email)) return "OK";
            return "ERROR";
        }

        public string SetCustomerBirdate(ControllerContext controllerContext)
        {
            string date = Request.QueryString.Get("param");
            if (Validator.isValidDate(date)) return "ERRORinvalid date";
            if (XmlWorks.setCustomerBirdateByCid(Request.QueryString.Get("id"), date)) return "OK";
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
            string date = Request.QueryString.Get("param");
            if (!Validator.isValidDate(date)) return "ERRORinvalid date";
            if (XmlWorks.setOrderDateByOid(Request.QueryString.Get("id"), date)) return "OK";
            return "ERROR";
        }

        public string SetOrderValue(ControllerContext controllerContext)
        {
            string value = Request.QueryString.Get("param");
            bool parseOk = false;
            bool makeValid = bool.TryParse(Request.QueryString.Get("makevalid"), out parseOk);
            if (!parseOk && !Validator.isValidValue(value)) return "ERRORmakevalid is not valid";
            if (parseOk && makeValid &&!Validator.isValidValue(value)) value = Validator.makeValueValid(value);
            if (!Validator.isValidValue(value)) return "ERRORinvalid value";
            if (XmlWorks.setOrderValueByOid(Request.QueryString.Get("id"), value)) return "OK";
            return "ERROR";
        }
    }
}