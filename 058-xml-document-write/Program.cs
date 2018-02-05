using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _058_xml_document_write
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an XmlDocument
            XmlDocument doc = new XmlDocument();

            // Make and append the root node
            XmlNode root = doc.CreateElement("People");
            doc.AppendChild(root);

            // Make and append child nodes to the root
            XmlNode person = doc.CreateElement("Person");
            XmlAttribute name = doc.CreateAttribute("name");
            name.Value = "Joe Seth";
            person.Attributes.Append(name);
            root.AppendChild(person);

            person = doc.CreateElement("Person");
            name = doc.CreateAttribute("name");
            name.Value = "Annie Ware";
            person.Attributes.Append(name);
            root.AppendChild(person);

            // Save the document as a file
            doc.Save("output.xml");
        }
    }
}
