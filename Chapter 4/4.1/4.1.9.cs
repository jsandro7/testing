// using System;
// using System.IO;
// using System.Security.AccessControl;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         string path = @"c:\temp\test.txt";
//         string destPath = @"c:\temp\destTest.txt";

//         File.CreateText(path).Close();
//         File.Move(path, destPath);

//         FileInfo fileInfo = new FileInfo(path);
//         fileInfo.MoveTo(destPath);
//     }    
// }