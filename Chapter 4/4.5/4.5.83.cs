// using System;
// using System.Collections;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
       
//     }
// }

// public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
// {
//     T this[int index] { get; set; }
//     int IndexOf(T item);
//     void Insert(int index, T item);
//     void RemoveAt(int index);
// }
// public interface ICollection<T> : IEnumerable<T>, IEnumerable
// {
//     int Count { get; }
//     bool IsReadOnly { get; }
//     void Add(T item);
//     void Clear();
//     bool Contains(T item);
//     void CopyTo(T[] array, int arrayIndex);
//     bool Remove(T item);
// }