// using System;
// using System.Xml;
// using System.Linq;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {

//         var products = new List<Product>
//         {
//             new Product{ Description = "Test", Price=  250.55M},
//             new Product{ Description = "Test2", Price=  26.61M},
//             new Product{ Description = "Test3", Price=  9.85M}
//         };

//         var popularProductNames = new List<Product>
//         {
//             new Product{ Description = "Test", Price=  250.55M}
//         };  

//         var popularProducts = 
//                             from p in products
//                             join n in popularProductNames on p.Description equals n.Description
//                             select p.Description;

//         Console.WriteLine(string.Join(", ", popularProducts));
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