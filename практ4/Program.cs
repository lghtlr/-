using System;
using System.Xml;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // XPath представляет язык запросов в XML. Он позволяет выбирать элементы, соответствующие определенному селектору.

            //Теперь выберем все узлы корневого элемента, то есть все элементы user:
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C://Users//1//Desktop//text3.xml");
            XmlElement xRoot = xDoc.DocumentElement;

          //  Выведем на консоль значения атрибутов name у элементов user:
        XmlNodeList childnodes = xRoot.SelectNodes("user");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.SelectSingleNode("@name").Value);
                       
        }
    }
}
