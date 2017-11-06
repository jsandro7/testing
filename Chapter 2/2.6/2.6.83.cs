// using System;
// using System.IO;

// public class MyClass 
//     {
//         public static void Main()
//         {
//             StreamWriter stream = File.CreateText("temp.dat");
//             stream.Write("some data");
//             stream.Dispose();
//             File.Delete("temp.dat");


//             using (StreamWriter sw = File.CreateText("temp.dat"))
//             {};
//         }

//         public interface IDisposable
//         {
//             void Dispose();
//         }
//     }
