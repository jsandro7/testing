// using System;
// using System.IO;
// using System.Security.AccessControl;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         foreach (string file in Directory.GetFiles(@"C:\Windows"))
//         {
//             Console.WriteLine(file);
//         }

//         DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows");
//         foreach (FileInfo fileInfo in directoryInfo.GetFiles())
//         {
//             Console.WriteLine(fileInfo.FullName);
//         }
//     }    
// }