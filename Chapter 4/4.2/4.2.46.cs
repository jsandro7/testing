// using System;
// using System.Xml;
// using System.IO;
// using System.Xml.XPath;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         DO("");
//     } 

//     public static void DO(string xml)
//     {
//         XmlDocument doc = new XmlDocument();
//         doc.LoadXml(xml); // Can be found in Listing 4-43
//         XPathNavigator nav = doc.CreateNavigator();
//         string query = "//People/Person[@firstName='Jane']";
//         XPathNodeIterator iterator = nav.Select(query);
//         Console.WriteLine(iterator.Count); // Displays 1
//         while(iterator.MoveNext())
//         {
//             string firstName = iterator.Current.GetAttribute("firstName","");
//             string lastName = iterator.Current.GetAttribute("lastName","");
//             Console.WriteLine("Name: {0} {1}", firstName, lastName);
//         }
//     }
// }
