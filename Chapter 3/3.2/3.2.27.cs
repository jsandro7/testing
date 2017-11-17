// using System;
// using System.IO;
// using System.Security.Cryptography;
// using System.Text;
// using System.Linq;
// using System.Security;

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

// }