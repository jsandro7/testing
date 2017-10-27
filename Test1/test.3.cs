// using System;
// using System.Text;
// public static class Program
// {           
//     public static void Main()
//     {
        
//         RefrenceType("hello");
//         ValueType(5);
//     }

//     private static void RefrenceType(string arg)
//     {
//             StringBuilder first = new StringBuilder();

//         first.Append(arg);
//         StringBuilder second = first;
//         first.Append(" world");
//         first = new StringBuilder("goodbye");

//         Console.WriteLine("RefrenceType 1st: {0}",first); 
//         Console.WriteLine("RefrenceType 2nd: {0}", second);
//     }

//     private static void ValueType(int arg)
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