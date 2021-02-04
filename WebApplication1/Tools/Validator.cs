using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebApplication1.Tools
{
    public static class Validator
    {
        public static bool customerExists(string id)
        {
            if (Regex.IsMatch(id, @"\d{1,}"))
            {
                if (XmlWorks.getCustomerNodeById(id) != null) return true;
            }
            return false;
        }

        public static bool orderExists(string id)
        {
            if (Regex.IsMatch(id, @"^\d{1,}$"))
            {
                if (XmlWorks.getOrderNodeById(id) != null) return true;
            }
            return false;
        }
        public static bool isValidDate(string date)
        {
            DateTime r;
            if (DateTime.TryParse(date, out r))
            {
                if (Regex.IsMatch(date, @"^\d{2}[.]\d{2}[.]\d{4}$")) return true;
            }
            return false;
        }
        public static bool isValidName(string name)
        {
            if (name.Length < 51)
            {
                if (Regex.IsMatch(name, @"^[а-яА-ЯёЁa-zA-Z ]+$")) return true;
            }
            return false;
        }

        public static bool isValidPhone(string phone)
        { 
            if (Regex.IsMatch(phone, @"^[+][7][(]\d{3}[)]\d{3}[-]\d{2}[-]\d{2}$")) return true;
            return false;
        }

        public static bool isValidEmail(string email)
        {
            //регулярные выражения для мыла - глупость какая-то (но это не точно)
            if (email.Contains("@") && email.Contains(".")) //если в сроке есть собака и точка
            {
                if (email.Count(f => f == '@') == 1) //если собака только одна
                {
                    string afterAt = email.Substring(email.LastIndexOf('@')); //все, что после собаки
                    if (afterAt.Length > 2) //исключаю вероятность появления пустой строки, и строки невалидного домена (очевидно, что в два символа не уместить имя, точку и зону) 
                    {
                        if (afterAt.Contains('.')) //содержит точку
                        {
                            if (afterAt.LastIndexOf('.') < afterAt.Length - 1) //точка не является последним
                            {
                                if (!afterAt.Contains("..") && afterAt.IndexOf('.') > 0) //и первым символом, и нет нескольких точек подряд
                                {
                                    return true;
                                }
                            }
                        }
                    }

                }
            }
            return false;
        }

        public static bool isValidStatus(string status)
        {
            if (status != "Куплен" && status != "Возвращен" && status != "Заблокирован") return false;
            return true;
        }

        public static bool isValidValue(string value)
        {
            if (Regex.IsMatch(value, @"^\d{1,}[.]\d{2}$")) { return true; }
            else return false;
        }

        public static string makeValueValid(string value) //автоисправление строки при незначительных ошибках
        {
            if (Regex.IsMatch(value, @"^\d{1,}[.]\d$")) return value += "0";
            if (Regex.IsMatch(value, @"^\d{1,}[.]$")) return value += "00";
            if (Regex.IsMatch(value, @"^\d{1,}$")) return value += ".00";
            return value;
        }
    }
}