// using System;
// using System.IO;
// using System.Security.Cryptography;
// using System.Text;
// using System.Linq;
// using System.Security;
// using System.Runtime.InteropServices;

// public class MyClass 
// {
//     public static void Main()
//     {
//         using (SecureString ss = new SecureString())
//         {
//             Console.Write("Please enter password: ");
//             while (true)
//             {
//                 ConsoleKeyInfo cki = Console.ReadKey(true);
//                 if (cki.Key == ConsoleKey.Enter) break;
//                     ss.AppendChar(cki.KeyChar);
//                 Console.Write("*");
//             }
//             ss.MakeReadOnly();
//         }
//     }
//     public static void ConvertToUnsecureString(SecureString securePassword)
//     {
//         IntPtr unmanagedString = IntPtr.Zero;
//         try
//         {
//             unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
//             Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
//         }
//         finally
//         {
//             Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
//         }
//     }
// }