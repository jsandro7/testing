﻿// using System;
// using System.Diagnostics;
// using System.IO;

// public class MyClass 
// {
//     public static void Main()
//     {      
//         Stream outputFile = File.Create("tracefile.txt");
//         TextWriterTraceListener textListener =
//         new TextWriterTraceListener(outputFile);
//         TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);
//         traceSource.Listeners.Clear();
//         traceSource.Listeners.Add(textListener);
//         traceSource.TraceInformation("Trace output");
//         traceSource.Flush();
//         traceSource.Close();
//     }    
// }