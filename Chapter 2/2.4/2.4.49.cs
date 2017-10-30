// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {            
//             var b = new Derived();
//             b.AbstractMethod();
//         }
//     } 

//     abstract class Base
//     {
//         public virtual void MethodWithImplementation() {/*Method with implementation*/}
//         public abstract void AbstractMethod();
//     }
//     class Derived : Base
//     {
//         public override void AbstractMethod() { }
//     }  
// }