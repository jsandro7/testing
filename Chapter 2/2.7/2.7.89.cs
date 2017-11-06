// using System;
// using System.Text;
// using System.Xml;
// using System.IO;

// public class MyClass 
//     {
//         public static void Main()
//         {
//             var stringWriter = new StringWriter();
//             using (XmlWriter writer = XmlWriter.Create(stringWriter))
//             {
//                 writer.WriteStartElement("book");
//                 writer.WriteElementString("price", "19.95");
//                 writer.WriteEndElement();
//                 writer.Flush();
//             }
//             string xml = stringWriter.ToString();

//             /* <?xml version=\”1.0\” encoding=\”utf-16\”?>
//                 <book>
//                     <price>19.95</price>
//                 </book> 
//             */
//         }
//     }
