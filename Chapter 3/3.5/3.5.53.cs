//using System;
//using System.Diagnostics;


//class MySample
//{

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Press escape key to stop");
//        using (PerformanceCounter pc = new PerformanceCounter("Memory", "Available Bytes"))
//        {
//            string text = "Available memory: ";
//            Console.Write(text);
//            do
//            {
//                while (!Console.KeyAvailable)
//                {
//                    Console.Write(pc.RawValue);
//                    Console.SetCursorPosition(text.Length, Console.CursorTop);
//                }
//            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
//        }
//    }
//}

//// Displays
//// 00:00:00.0007635
//// 00:00:01.4071420