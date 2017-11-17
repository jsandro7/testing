// using System;
// using System.Text.RegularExpressions;

// public class MyClass 
// {
//     public static void Main()
//     {
//         var test = IsJson("{test}");

//         Console.WriteLine(test);
//     }   
//     public static bool IsJson(string input)
//     {
//         input = input.Trim();

//         return input.StartsWith("{") && input.EndsWith("}") || input.StartsWith("[") && input.EndsWith("]");
//     }
// }