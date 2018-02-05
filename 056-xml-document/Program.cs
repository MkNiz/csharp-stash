using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _056_xml_document
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an XmlDocument and use it to load items.xml
            XmlDocument doc = new XmlDocument();
            doc.Load("items.xml");
            
            // Create an XmlNodeList to allow iteration through every item that is a weapon element
            XmlNodeList weapons = doc.SelectNodes("/items/weapon");

            // Iterate through and output the results
            Console.WriteLine("Weapons:");
            foreach (XmlNode node in weapons)
                Console.WriteLine("\t- " + node.Attributes["name"].Value + ": " + node.Attributes["description"].Value);

            Console.ReadKey();
        }
    }
}
