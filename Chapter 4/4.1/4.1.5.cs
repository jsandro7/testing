// using System;
// using System.IO;
// using System.Security.AccessControl;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         var dir = new DirectoryInfo(@"C:\Temp");

//         ListDirectories(dir,"*", 3, 0);
//     }

//     private static void ListDirectories(DirectoryInfo directoryInfo, string searchPattern, int maxLevel, int currentLevel)
//     {
//         if (currentLevel >= maxLevel )
//         {
//             return;
//         }

//         string indent = new string('-', currentLevel);
//         try
//         {
//             DirectoryInfo[] subDirectories = directoryInfo.GetDirectories(searchPattern);
//             foreach (DirectoryInfo subDirectory in subDirectories)
//             {
//                 Console.WriteLine(indent + subDirectory.Name);
//                 ListDirectories(subDirectory, searchPattern,maxLevel, currentLevel + 1);
//             }
//         }
//         catch (UnauthorizedAccessException)
//         {
//             // You don't have access to this folder.
//             Console.WriteLine(indent + "Can't access: " + directoryInfo.Name);
//             return;
//         }
//         catch (DirectoryNotFoundException)
//         {
//             // The folder is removed while iterating
//             Console.WriteLine(indent + "Can't find: " + directoryInfo.Name);
//             return;
//         }
//     }
// }