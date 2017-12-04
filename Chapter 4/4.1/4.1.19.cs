// using System;
// using System.IO;
// using System.Text;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         string path = @"c:\temp\bufferedStream.txt";
//         using (FileStream fileStream = File.Create(path))
//         {
//             using (BufferedStream bufferedStream = new BufferedStream(fileStream))
//             {
//                 using (StreamWriter streamWriter = new StreamWriter(bufferedStream))
//                 {
//                     streamWriter.WriteLine("A line of text.");
//                 }
//             }
//         }
//     }    
// }