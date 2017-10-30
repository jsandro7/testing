// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             var list = new List<IEntity>();
//             list.Add(new Entity());
//             Repository<IEntity> animal = new Repository<IEntity>(list);
//             var result = animal.FindById(1);
//         }
//     } 
    
//     interface IEntity
//     {
//         int Id { get; }
//     }

//     class Entity: IEntity
//     {
//         int IEntity.Id => 1;
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