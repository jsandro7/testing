// using System;
// using System.Text;
// using System.Xml;
// using System.IO;
// using System.Globalization;

// public class MyClass 
//     {
//         public static void Main()
//         {

//             string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?><book><price>19.95</price></book>";

//             var stringReader = new StringReader(xml);
//             using (XmlReader reader = XmlReader.Create(stringReader))
//             {
//                 reader.ReadToFollowing("price");
//                 decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US")); 
//                                                                     // Make sure that you read the decimal part correctly

//                 Console.WriteLine(price);
//             }
//         }
//     }
