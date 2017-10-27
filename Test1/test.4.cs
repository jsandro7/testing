// using System;
// using System.Text;
// public static class Program
// {           
//     public static void Main()
//     {
//         string first = "hello";
//         int second = 5;
//         RefrenceType(ref first);
//         ValueType(ref second);
//     }

//     private static void RefrenceType(ref string arg)
//     {
//         StringBuilder first = new StringBuilder();

//         first.Append(arg);
//         StringBuilder second = first;
//         first.Append(" world");
//         first = new StringBuilder("goodbye");

//         Console.WriteLine("RefrenceType 1st: {0}",first); 
//         Console.WriteLine("RefrenceType 2nd: {0}", second);
//     }

//     private static void ValueType(ref int arg)
//     {
//         IntHolder first = new IntHolder();
//         first.i = arg;
//         IntHolder second = first;
//         first.i = 6;

//         Console.WriteLine("ValueType 1st: {0}",first.i);
//         Console.WriteLine ("ValueType 2nd: {0}",second.i);
//     }
// }    

// public struct IntHolder
// {
//     public int i;
// }