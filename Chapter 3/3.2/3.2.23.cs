// using System;
// using System.IO;
// using System.Security.Cryptography;
// using System.Text;
// using System.Linq;

// public class MyClass 
// {
//     public static void Main()
//     {
//         UnicodeEncoding byteConverter = new UnicodeEncoding();
//         SHA256 sha256 = SHA256.Create();
//         string data = "A paragraph of text";
//         byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data));

//         data = "A paragraph of changed text";
//         byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data));
//         data = "A paragraph of text";
//         byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data));
//         Console.WriteLine(hashA.SequenceEqual(hashB)); // Displays: false
//         Console.WriteLine(hashA.SequenceEqual(hashC)); // Displays: true
//     }
// }