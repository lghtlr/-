using System.Xml;

namespace HelloApp
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // изменение XML-документа. удаление первого элемента СТРАНИЦВ 45 ОСТАНОВИЛАСЬ!

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C://Users//1//Desktop//text2.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode firstNode = xRoot.FirstChild;
            xRoot.RemoveChild(firstNode);
            xDoc.Save("C://Users//1//Desktop//text2.xml");


        }
    }
}
