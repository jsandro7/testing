// using System;
// using System.Xml;
// using System.Linq;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         int[] data = { 1, 2, 5, 8, 11 };

//         var result =  
//                     from d in data
//                     where d % 2 == 0
//                     select d;

//         foreach (int i in result)
//         {
//             Console.WriteLine(i);
//         }
//         // Displays 2 8

//         var result2 = data.Where(d => d % 2 == 0);
//     }
// }