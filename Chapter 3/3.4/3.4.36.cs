// #define MySymbol

// using System;
// using System.Reflection;

// public class MyClass 
// {
//     public static void Main()
//     {      
//         LoadAssembly<String>();    
//     }

//     public static Assembly LoadAssembly<T>()
//     {
//         #if !WINRT
//             Assembly assembly = typeof(T).Assembly;
//         #else
//             Assembly assembly = typeof(T).GetTypeInfo().Assembly;
//         #endif
//         return assembly;
//     }
// }