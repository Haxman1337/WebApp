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
        public string SetCustomerName()
        {
            string name = Regex.Unescape(Request.QueryString.Get("param"));
            string id = Request.QueryString.Get("id");
            if (!Validator.isValidName(name)) return "ERRORInvalid name";
            if (!Validator.customerExists(id)) return "ERRORinvalid id";
            if (XmlWorks.setCustomerNameByCid(id, name)) return "OK";
            return "ERROR";
        }

        public string SetCustomerPhone()
        {
            string phone = Regex.Unescape(Request.QueryString.Get("param"));
            string id = Request.QueryString.Get("id");
            if (!Validator.isValidPhone(phone)) return "ERRORinvalid phone";
            if (!Validator.customerExists(id)) return "ERRORinvalid id";
            if (XmlWorks.setCustomerPhoneByCid(id, phone)) return "OK";
            return "ERROR";
        }

        public string SetCustomerEmail()
        {
            string email = Request.QueryString.Get("param");
            string id = Request.QueryString.Get("id");
            if (!Validator.isValidEmail(email)) return "ERRORinvalid email";
            if (!Validator.customerExists(id)) return "ERRORinvalid id";
            if (XmlWorks.setCustomerEmailByCid(id, email)) return "OK";
            return "ERROR";
        }

        public string SetCustomerBirdate()
        {
            string date = Request.QueryString.Get("param");
            string id = Request.QueryString.Get("id");
            if (!Validator.isValidDate(date)) return "ERRORinvalid date";
            if (!Validator.customerExists(id)) return "ERRORinvalid id";
            if (XmlWorks.setCustomerBirdateByCid(id, date)) return "OK";
            return "ERROR";
        }
        //////////////////////////////
        public string SetOrderStatus()
        {
            if (XmlWorks.setOrderStatusByOid(Request.QueryString.Get("id"), Request.QueryString.Get("param"))) return "OK";
            return "ERROR";
        }

        public string SetOrderRegdate()
        {
            string date = Request.QueryString.Get("param");
            if (!Validator.isValidDate(date)) return "ERRORinvalid date";
            if (XmlWorks.setOrderDateByOid(Request.QueryString.Get("id"), date)) return "OK";
            return "ERROR";
        }

        public string SetOrderValue()
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

        ///////
        
        public string CreateOrder()
        {
            string cid = Request.QueryString.Get("cid");
            if (!Validator.customerExists(cid)) return "ERRORinvalid id";
            string status = Request.QueryString.Get("status");
            if (!Validator.isValidStatus(status)) return "ERRORinvalid status";
            string value = Request.QueryString.Get("value");
            if (!Validator.isValidValue(value)) return "ERRORinvalid value";
            string date = Request.QueryString.Get("date");
            if (!Validator.isValidDate(date)) return "ERRORinvalid date";
            XmlWorks.createOrder(cid, status, value, date);
            return "OK";
        }

        public string CreateCustomer()
        {
            string name = Request.QueryString.Get("name");
            if (!Validator.isValidName(name)) return "ERRORinvalid name";
            string email = Request.QueryString.Get("email");
            if (!Validator.isValidEmail(email)) return "ERRORinvalid email";
            string phone = Request.QueryString.Get("phone");
            if (!Validator.isValidPhone(phone)) return "ERRORinvalid phone";
            string date = Request.QueryString.Get("date");
            if (!Validator.isValidDate(date)) return "ERRORinvalid date";
            string regdate = DateTime.Now.ToString("dd.MM.yyyy");
            XmlWorks.createCustomer(name, date, email, phone, regdate);
            return "OK";
        }

        ///////////
        
        public string RemoveCustomer()
        {
            string cid = Request.QueryString.Get("id");
            if (!Validator.customerExists(cid)) return "ERRORinvalid id";
            XmlWorks.removeCustomer(cid);
            return "OK";
        }

        public string RemoveOrder()
        {
            string oid = Request.QueryString.Get("id");
            if (!Validator.orderExists(oid)) return "ERRORinvalid id";
            XmlWorks.removeOrder(oid);
            return "OK";
        }
    }
}