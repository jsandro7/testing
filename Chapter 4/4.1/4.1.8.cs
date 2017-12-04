// using System;
// using System.IO;
// using System.Security.AccessControl;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         string path = @"c:\temp\test.txt";
//         if (File.Exists(path))
//         {
//             File.Delete(path);
//         }

//         FileInfo fileInfo = new FileInfo(path);
//         if (fileInfo.Exists)
//         {
//             fileInfo.Delete();
//         }
//     }    
// }