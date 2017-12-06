// using System;
// using System.Xml;
// using System.IO;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         DO()
//     } 


//     public static void DO()
//     {
//         string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
//                         <people>
//                         <person firstname=""john"" lastname=""doe"">
//                         <contactdetails>
//                         <emailaddress>john@unknown.com</emailaddress>
//                         </contactdetails>
//                         </person>
//                         <person firstname=""jane"" lastname=""doe"">
//                         <contactdetails>
//                         <emailaddress>jane@unknown.com</emailaddress>
//                         <phonenumber>001122334455</phonenumber>
//                         </contactdetails>
//                         </person>
//                         </people>";
//         using (StringReader stringReader = new StringReader(xml))
//         {
//             using (XmlReader xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings() { IgnoreWhitespace = true }))
//             {
//                 xmlReader.MoveToContent();
//                 xmlReader.ReadStartElement("People");
//                 string firstName = xmlReader.GetAttribute("firstName");
//                 string lastName = xmlReader.GetAttribute("lastName");
//                 Console.WriteLine("Person: {0} {1}", firstName, lastName);
//                 xmlReader.ReadStartElement("person");
//                 Console.WriteLine("ContactDetails");
//                 xmlReader.ReadStartElement("contactdetails");
//                 string emailAddress = xmlReader.ReadString();
//                 Console.WriteLine("Email address: {0}", emailAddress);
//             }
//         }
//     }
// }
