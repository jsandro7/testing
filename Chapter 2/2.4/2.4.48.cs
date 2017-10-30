// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             Base b = new Base();
//             b.Execute();
//             b = new Derived();
//             b.Execute();
//         }
//     } 

//     class Base
//     {
//         public void Execute() { Console.WriteLine("Base.Execute"); }
//     }
//     class Derived : Base
//     {
//         public new void Execute() { Console.WriteLine("Derived.Execute"); }
//     }    
// }