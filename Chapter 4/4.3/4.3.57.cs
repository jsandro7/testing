// using System;
// using System.Xml;
// using System.Linq;
// using System.Collections.Generic;
// using System.Linq.Expressions;

// public class MyClass
// {
//     delegate int del(int i);  

//     public static void Main(string[] args)
//     {
//         int[] data = { 1, 2, 5, 8, 11 };
//         var result = 
//             from d in data
//             where d > 5
//             orderby d descending
//             select d;

//         Console.WriteLine(string.Join(", ", result)); // Displays 11, 8

//         //LINQ Expression 
//         Expression<del> myET = x => x * x;  

//         var t = myET.Compile();
//         var tt = t(6);
//     }
// }