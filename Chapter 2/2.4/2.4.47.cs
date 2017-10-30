// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             var test = new Derived();
//         }
//     } 

//     class Base
//     {
//         protected virtual void Execute()
//         {}
//     }
//     class Derived : Base
//     {
//         protected override void Execute()
//         {
//             Log("Before executing");
//             base.Execute();
//             Log("After executing");
//         }
//     private void Log(string message) { /* some logging code */ }
//     }
    
// }