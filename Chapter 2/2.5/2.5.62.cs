// using System;
// using System.Diagnostics;

// public static class Program
//     {           
//         public static void Main()
//         {   
//               ConditionalAttribute conditionalAttribute = (ConditionalAttribute)Attribute.GetCustomAttribute(
//                                                                                         typeof(ConditionalClass),
//                                                                                         typeof(ConditionalAttribute));

//                 string condition = conditionalAttribute.ConditionString; // returns CONDITION1

//                 Console.WriteLine(condition);
//         }
       
//     }

//     [Conditional("test")]
//     internal class ConditionalClass : Attribute 
//     {
//     }