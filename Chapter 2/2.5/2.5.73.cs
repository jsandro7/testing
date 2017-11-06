// using System;
// using System.Diagnostics;
// using System.Reflection;
// using System.Linq;


// public static class Program
//     {           
//         public static void Main()
//         {   
//            int i = 42;
//             MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
//             int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
//         }         
//     }