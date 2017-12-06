// using System;
// using System.Xml;
// using System.IO;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         DO();
//     } 

//     public static void DO()
//     {
//         StringWriter stream = new StringWriter();
//         using (XmlWriter writer = XmlWriter.Create(stream,new XmlWriterSettings() { Indent = true }))
//         {
//             writer.WriteStartDocument();
//             writer.WriteStartElement("People");
//             writer.WriteStartElement("Person");
//             writer.WriteAttributeString("firstName", "John");
//             writer.WriteAttributeString("lastName", "Doe");
//             writer.WriteStartElement("ContactDetails");
//             writer.WriteElementString("EmailAddress", "john@unknown.com");
//             writer.WriteEndElement();
//             writer.WriteEndElement();
//             writer.Flush();
//         }

//         Console.WriteLine(stream.ToString());
//     }
// }
