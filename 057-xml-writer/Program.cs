using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _057_xml_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an XmlWriter utilizing a new file named output.xml
            XmlWriter writer = XmlWriter.Create("output.xml");

            // Start writing the XML document
            writer.WriteStartDocument();

            // Create a root element
            writer.WriteStartElement("foos");

            // Since it's still 'open', the following is a child of the element above
            writer.WriteStartElement("foo");
            writer.WriteAttributeString("bar", "true");
            writer.WriteString("Yabba dabba donk");
            writer.WriteEndElement();

            // As is the following
            writer.WriteStartElement("foo");
            writer.WriteAttributeString("bar", "false");
            writer.WriteString("honk");

            // Close all tags and end writing
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
