// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             var list = new List<Order>();

//             list.Add(new Order());

//             OrderRepository ord = new OrderRepository(list);

//             var result = ord.FindById(1);
//         }
//     } 
    
//     interface IEntity
//     {
//         int Id { get; }
//     }

//    class Order : IEntity
//     {
//         public int Id { get; }
//         Other implementation details omitted
//         …
//     }

//     class OrderRepository : Repository<Order>
//     {
//         public OrderRepository(IEnumerable<Order> orders) : base(orders) { }

//         public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
//         {
//             List<Order> result = null;
//             Some filtering code
//             return result;
//         }
//     }

//     class Repository<T>
//     where T : IEntity
//     {
//         protected IEnumerable<T> _elements;
//         public Repository(IEnumerable<T> elements)
//         {
//             _elements = elements;
//         }
//         public T FindById(int id)
//         {
//             return _elements.SingleOrDefault(e => e.Id == id);
//         }
//     }
// }