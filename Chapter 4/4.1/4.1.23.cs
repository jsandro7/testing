// using System;
// using System.IO;
// using System.Net;
// using System.Threading.Tasks;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//        CreateAndWriteAsyncToFile();
//     }

//     public static async Task CreateAndWriteAsyncToFile()
//     {
//         using (FileStream stream = new FileStream("test.dat", FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
//         {
//             byte[] data = new byte[100000];
//             new Random().NextBytes(data);
//             await stream.WriteAsync(data, 0, data.Length);
//         }
//     }  
// }