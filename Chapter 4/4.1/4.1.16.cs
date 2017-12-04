// using System;
// using System.IO;
// using System.Text;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         var path = @"C:\temp\test.txt";
//         using (FileStream fileStream = File.OpenRead(path))
//         {
//             byte[] data = new byte[fileStream.Length];
//             for (int index = 0; index < fileStream.Length; index++)
//             {
//                 data[index] = (byte)fileStream.ReadByte();
//             }

//             Console.WriteLine(Encoding.UTF8.GetString(data)); // Displays: MyValue
//         }
//     }    
// }