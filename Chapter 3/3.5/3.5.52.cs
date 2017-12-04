// using System;
// using System.Diagnostics;
// using System.Text;

// class MySample
// {
//     const int numberOfIterations = 1000000;
//     public static void Main()
//     {
//        Stopwatch sw = new Stopwatch();
//         sw.Start();
//         Algorithm1();
//         sw.Stop();
//         Console.WriteLine(sw.Elapsed);
//         sw.Reset();
//         sw.Start();
//         Algorithm2();
//         sw.Stop();

//         Console.WriteLine(sw.Elapsed);
//         Console.WriteLine("Ready…");
//         Console.ReadLine(); 
//     }

//     private static void Algorithm1()
//     {
//         StringBuilder sb = new StringBuilder();
//         for (int x = 0; x < numberOfIterations; x++)
//         {
//             sb.Append('a');
//         }
//         string result = sb.ToString();
//     }

//     private static void Algorithm2()
//     {
//         string result = "";
//         for (int x = 0; x < numberOfIterations; x++)
//         {
//             result += 'a';
//         }
//     }
  
// }

// // Displays
// // 00:00:00.0007635
// // 00:00:01.4071420