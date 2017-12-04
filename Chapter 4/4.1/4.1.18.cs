// using System;
// using System.IO;
// using System.Text;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         string folder = @"c:\temp";
//         string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
//         string compressedFilePath = Path.Combine(folder, "compressed.gz");
//         byte[] dataToCompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();
//         using (FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
//         {
//             uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
//         }
//         using (FileStream compressedFileStream = File.Create(compressedFilePath))
//         {
//             using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
//             {
//                 compressionStream.Write(dataToCompress, 0, dataToCompress.Length);
//             }
//         }
//     }    
// }