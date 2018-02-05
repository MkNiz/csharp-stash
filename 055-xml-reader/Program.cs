using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _055_xml_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            int invCounter = 1;

            Console.WriteLine("Inventory:");

            // Create the XmlReader and direct it to the inventory.xml file
            XmlReader reader = XmlReader.Create("inventory.xml");

            // Run loop while file is still being read
            while (reader.Read())
            {
                // When reading encounters an element with the element name item...
                if((reader.NodeType == XmlNodeType.Element) && (reader.Name == "item"))
                {
                    // Print the item's name and description (while incrementing the invCounter variable)
                    Console.WriteLine("\t" + invCounter++ + ".) " + reader.GetAttribute("name") +
                        " - " + reader.GetAttribute("description"));
                }
            }

            Console.ReadKey();
        }
    }
}
