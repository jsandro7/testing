// using System;
// using System.Diagnostics;
// class MySample
// {
//     public static void Main()
//     {
//         EventLog log = new EventLog("MyNewLog");
//         Console.WriteLine("Total entries: " + log.Entries.Count);
//         EventLogEntry last = log.Entries[log.Entries.Count - 1];
//         Console.WriteLine("Index: " + last.Index);
//         Console.WriteLine("Source: " + last.Source);
//         Console.WriteLine("Type: " + last.EntryType);
//         Console.WriteLine("Time: " + last.TimeWritten);
//         Console.WriteLine("Message: " + last.Message);
//     }
// }