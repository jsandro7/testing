// using System;
// using System.Diagnostics;

// public class MyClass 
// {
//     public static void Main()
//     {      
//         TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);
//         traceSource.TraceInformation("Tracing application..");
//         traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
//         traceSource.TraceData(TraceEventType.Information, 1, new object[] { "a", "b", "c" });
//         traceSource.Flush();
//         traceSource.Close();
//         // Outputs:
//         // myTraceSource Information: 0 : Tracing application..
//         // myTraceSource Critical: 0 : Critical trace
//         // myTraceSource Information: 1 : a, b, c
//     }    
// }
