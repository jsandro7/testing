// using System;
// using System.Collections;
// using System.Collections.Generic;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         HashSet<int> oddSet = new HashSet<int>();
//         HashSet<int> evenSet = new HashSet<int>();

//         for (int x = 1; x <= 10; x++)
//         {
//             if (x % 2 == 0)
//                 evenSet.Add(x);
//             else
//                 oddSet.Add(x);
//         }

//         DisplaySet(oddSet);
//         DisplaySet(evenSet);
//         oddSet.UnionWith(evenSet);
//         DisplaySet(oddSet);
//     }

//     private static void DisplaySet(HashSet<int> set)
//     {
//         Console.Write("{");

//         foreach (int i in set)
//         {
//             Console.Write(" {0}", i);
//         }
        
//         Console.WriteLine(" }");
//     }
// }

