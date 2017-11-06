// using System;
// using System.IO;

// public class MyClass 
//     {
//         public static void Main()
//         {
//             StreamWriter stream = File.CreateText("temp.dat");
//             stream.Write("some data");
//             GC.Collect();
//             GC.WaitForPendingFinalizers();  //makes sure that all finalizers have run before the code continues
//             File.Delete("temp.dat"); 
//         }
//     }
