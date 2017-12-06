// using System.Linq;
// using System.Collections;
// using System.Collections.Generic;
// using System;

// public static class LinqExtensions
// {
//     public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
//     {
//         foreach (TSource item in source)
//         {
//             if (predicate(item))
//             {
//                 yield return item;
//             }
//         }
//     }
// }