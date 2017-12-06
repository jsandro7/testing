// using System;
// using System.Xml;
// using System.Linq;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         int[] data1 = { 1, 2, 5 };
//         int[] data2 = { 2, 4, 6};

//         var result = 
//                 from d1 in data1
//                 from d2 in data2
//                 select d1 * d2;

//         Console.WriteLine(string.Join(", ", result)); // Displays 2, 4, 6, 4, 8, 12, 10, 20, 30
//     }
// }