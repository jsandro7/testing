// using System;
// using System.Collections.Generic;
// using System.Linq;

//     public static class Program
//     {           
//         public static void Main()
//         {   
//             List<Order> orders = new List<Order>
//             {
//                 new Order { Created = new DateTime(2012, 12, 1 )},
//                 new Order { Created = new DateTime(2012, 1, 6 )},
//                 new Order { Created = new DateTime(2012, 7, 8 )},
//                 new Order { Created = new DateTime(2012, 2, 20 )},
//             };      

//             orders.Sort();               
//         }
//     }

//     //Standard .NET interface
//     class Order : IComparable
//     {
//         public DateTime Created { get; set; }

//         /// less than 0 means current instance precedes the object
//         /// 0 means current instance is in same position as the object
//         /// greater then 0 means current instance follows the objects 
//         public int CompareTo(object obj)
//         {
//             if (obj == null) return 1;

//             Order o = obj as Order;

//             /*Alternative syntax */
//             //var o =  Convert.ChangeType(obj, obj.GetType());

//             if (o == null)
//             {
//                 throw new ArgumentException("Object is not an Order");
//             }
//             return this.Created.CompareTo(o.Created);
//         }
//     }

