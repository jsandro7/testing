// using System;
// using System.Xml;
// using System.Linq;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         var pageIndex = 1;
//         var pageSize = 2;

//         var products = new List<Product>
//         {
//             new Product{ Description = "Test", Price=  250.55M},
//             new Product{ Description = "Test2", Price=  26.61M},
//             new Product{ Description = "Test3", Price=  9.85M}
//         };

//         var pages = Convert.ToInt32(Math.Ceiling((decimal) products.Count / (decimal)pageSize));
       

//         var pagedOrders = 
//                 products.Skip((pageIndex - 1) * pageSize)
//                         .Take(pageSize);

//         for(int i = 0; i < pages; i++)
//         {
//             Console.WriteLine(string.Join(", ", pagedOrders));
//             pageIndex += pageSize;
//         }       
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