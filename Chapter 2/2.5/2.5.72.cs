// using System;
// using System.Diagnostics;
// using System.Reflection;
// using System.Linq;


// public static class Program
//     {           
//         public static void Main()
//         {   
            
//             testme t = new testme("Sandro", 2);

//             DumpObject(t);
        
           
//         } 
//         static void DumpObject(object obj)
//         {
//             FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
//             foreach (FieldInfo field in fields)
//             {
//                 if (field.FieldType == typeof(int))
//                 {
//                     Console.WriteLine(field.GetValue(obj));
//                 }
//             }
//         }    
//     }


//     class testme
//     {
//         private string Me;
//         private int You;

//         public testme(string me, int you)
//         {
//             this.Me = me;
//             this.You = you;
//         }

//     }