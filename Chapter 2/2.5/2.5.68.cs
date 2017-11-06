// using System;
// using System.Diagnostics;
// using System.Reflection;


// public static class Program
//     {           
//         public static void Main()
//         {   
           
//         }     
//     }

//     [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple=true)]
//     class CompleteCustomAttribute : Attribute
//     {
//         public CompleteCustomAttribute(string description)
//         {
//         Description = description;
//         }
//     public string Description { get; set; }
//     }


//     [CompleteCustomAttribute("test")]
//     [CompleteCustomAttribute("test2")]
//     class test{
//     }