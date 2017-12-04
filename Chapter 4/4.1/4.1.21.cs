// using System;
// using System.IO;
// using System.Text;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         ReadAllText();
//     }    

//     private static string ReadAllText()
//     {
//         string path = @"C:\temp\test.txt";
//         try
//         {
//             return File.ReadAllText(path);
//         }
//         catch (DirectoryNotFoundException) { }
//         catch (FileNotFoundException) { }
//         return string.Empty;
//     }
// }