// using System;
// using System.Globalization;

// public class MyClass 
// {
//     public static void Main()
//     {
//         CultureInfo english = new CultureInfo("En");
//         CultureInfo dutch = new CultureInfo("Nl");
//         string value = "€19,95";
//         decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
//         Console.WriteLine(d.ToString(english)); // Displays 19.95
//     }    
// }