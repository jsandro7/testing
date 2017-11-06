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

//         static object LoadLargeList()
//         {
//             return null;
//         }

//         static WeakReference data;
//         public static void Run()
//         {
//             object result = GetData();
//             // GC.Collect(); Uncommenting this line will make data.Target null
//             result = GetData();
//         }
//         private static object GetData()
//         {
//             if (data == null)
//             {
//                 data = new WeakReference(LoadLargeList());
//             }

//             if (data.Target == null)
//             {
//                 data.Target = LoadLargeList();
//             }

//             return data.Target;
//         }
//     }