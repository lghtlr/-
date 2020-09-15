using System;
using System.Xml;
using System.Xml.Linq;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Переберем элементы xml-файла и выведем их значения на консоль
            XDocument xdoc = XDocument.Load("C://Users//1//Desktop//phones.xml");
            foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");

                if (nameAttribute != null && companyElement != null && priceElement != null)
                {
                    Console.WriteLine($"Смартфон: {nameAttribute.Value}");
                    Console.WriteLine($"Компания: {companyElement.Value}");
                    Console.WriteLine($"Цена: {priceElement.Value}");
                }
                Console.WriteLine();
            }




        }
    }
}
