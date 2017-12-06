// using System;
// using System.Xml.Linq;
// using System.Linq;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         String xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
//                     <people>
//                         <person firstname=""john"" lastname=""doe"">
//                             <contactdetails>
//                                 <emailaddress>john@unknown.com</emailaddress>
//                             </contactdetails>
//                         </person>
//                         <person firstname=""jane"" lastname=""doe"">
//                             <contactdetails>
//                                 <emailaddress>jane@unknown.com</emailaddress>
//                                 <phonenumber>001122334455</phonenumber>
//                             </contactdetails>
//                         </person>
//                     </people>";

//         XElement root = XElement.Parse(xml);

//         foreach (XElement p in root.Descendants("person"))
//         {
//             string name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname");
//             p.Add(new XAttribute("IsMale", name.Contains("John")));
//             XElement contactDetails = p.Element("contactdetails");

//             if (!contactDetails.Descendants("phonenumber").Any())
//             {
//                 contactDetails.Add(new XElement("phonenumber", "001122334455"));
//             }
//         }
//     }
// }