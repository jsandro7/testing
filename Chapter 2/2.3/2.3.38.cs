// using System;
// using System.Data.Objects;


// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             DbContext ctx = new DbContext(); // create a new context 
//             var context = ctx.ObjectContext; // will not compile

//             var adaptedContext = ((IObjectContextAdapter)ctx).ObjectContext; //will compile
//         }
//     }   

//     public interface IObjectContextAdapter
//     {
//         ObjectContext ObjectContext { get;}
//     }
// // }