// using System;
// using System.Text;
// public static class Program
// {           
//     public static void Main()
//     {
        
//         RefrenceType();
//         ValueType();
//     }

//     private static void RefrenceType()
//     {
//             StringBuilder first = new StringBuilder();

//         first.Append("hello");
//         StringBuilder second = first;
//         first.Append(" world");
//         first = new StringBuilder("goodbye");

//         Console.WriteLine("RefrenceType 1st: {0}",first); 
//         Console.WriteLine("RefrenceType 2nd: {0}", second);
//     }

//     private static void ValueType()
//     {
//         IntHolder first = new IntHolder();
//         first.i = 5;
//         IntHolder second = first;
//         first.i = 6;

//         Console.WriteLine("ValueType 1st: {0}",first.i);
//         Console.WriteLine ("ValueType 2nd: {0}",second.i);
//     }
// }    

// public class IntHolder
// {
//     public int i;
// }