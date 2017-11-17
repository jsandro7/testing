// using System;
// using System.IO;
// using System.Security.Cryptography;
// using System.Text;
// using System.Linq;
// using System.Security.Permissions;

// public class MyClass 
// {
//     public static void Main()
//     {
//         FileIOPermission f = new FileIOPermission(PermissionState.None);
//         f.AllLocalFiles = FileIOPermissionAccess.Read;
//         try
//         {
//             f.Demand();
//         }
//         catch (SecurityException s)
//         {
//             Console.WriteLine(s.Message);
//         }
//     }

// }