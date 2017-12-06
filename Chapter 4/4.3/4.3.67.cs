// using System;
// using System.Xml;
// using System.Linq;
// using System.Collections.Generic;
// using System.Xml.Linq;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
      
//         XElement root = new XElement("Root",
//             new List<XElement>
//             {
//             new XElement("Child1"),
//             new XElement("Child2"),
//             new XElement("Child3")
//             },
//             new XAttribute("MyAttribute", 42));
//         root.Save("test.xml");
        
//        /*Outputs:
//         <Root MyAttribute="42">
//         <Child1 />
//         <Child2 />
//         <Child3 />
//         </Root>
//       */
//     }
// }