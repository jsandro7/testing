// using System;
// using System.Xml;
// using System.Linq;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {

//         var orders = new List<Order> {
//             new Order
//             {
//                 OrderLines = new List<OrderLine>(){
//                     new OrderLine{
//                         Amount = 2,
//                         Product = new Product{ Description = "Test", Price=  250.55M}
//                     },
//                       new OrderLine{
//                         Amount = 77,
//                         Product = new Product{ Description = "Test2", Price=  26.61M}
//                     },
//                      new OrderLine{
//                         Amount = 2,
//                         Product = new Product{ Description = "Test", Price=  250.55M}
//                     }
//                 }
//             },
//             new Order
//             {
//                 OrderLines = new List<OrderLine>(){
//                     new OrderLine{
//                         Amount = 2,
//                         Product = new Product{ Description = "Test", Price=  250.55M}
//                     }
//                 }
//             }
//         };

//         var result = 
//                 from o in orders
//                 from l in o.OrderLines
//                 group l by l.Product.Description into p
//                 select new
//                 {
//                     Product = p.Key,
//                     Amount = p.Sum(x => x.Amount)
//                 };


//         Console.WriteLine(string.Join(", ", result));
//     }
// }

// public class Product
// {
//     public string Description { get; set; }
//     public decimal Price { get; set; }
// }

// public class OrderLine
//     {
//     public int Amount { get; set; }
//     public Product Product { get; set; }
// }

// public class Order
// {
//     public List<OrderLine> OrderLines { get; set; }
// }