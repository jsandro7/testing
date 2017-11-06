// using System;
// using System.Text.RegularExpressions;

// public class MyClass 
// {
//     public static void Main()
//     {
//        Console.WriteLine(ValidateZipCodeRegEx("1234AB"));       
//        Console.WriteLine(ValidateZipCodeRegEx("1234"));
//     }    

//     static bool ValidateZipCodeRegEx(string zipCode)
//     {
//         Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
//         return match.Success;
//     }
// }