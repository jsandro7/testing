﻿// using System;
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

//         XElement newTree = new XElement("People",
//                                 from p in root.Descendants("Person")
//                                 let name = (string)p.Attribute("firstName") + (string)p.Attribute("lastName")
//                                 let contactDetails = p.Element("ContactDetails")
//                                 select new XElement("Person",
//                                 new XAttribute("IsMale", name.Contains("John")),
//                                 p.Attributes(),
//                                 new XElement(
//                                         "ContactDetails", 
//                                         contactDetails.Element("EmailAddress"), 
//                                         contactDetails.Element("PhoneNumber") ?? new XElement("PhoneNumber", "112233455")
//                                 )));
//     }
// }