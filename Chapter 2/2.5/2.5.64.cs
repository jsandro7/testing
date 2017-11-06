// using System;
// using System.Diagnostics;
// using System.Reflection;


// public static class Program
//     {           
//         public static void Main()
//         {   
           
//         }     
       
//     }

//      [Conditional("test")]
//      public class TraitAttribute : Attribute 
//      {
//          public TraitAttribute(string category, string value)
//          {

//          }
//      }

//     public class CategoryAttribute : TraitAttribute
//     {
//         public CategoryAttribute(string value)
//         : base("Category", value)
//         { }
//     }


//     public class UnitTestAttribute : CategoryAttribute
//     {
//         public UnitTestAttribute()
//         : base("Unit Test")
//         { }
//     }