// using System;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {           
//             IReadOnlyInterface imp1 = new ReadAndWriteImplementation();
//             int test = imp1.Value;

//             ReadAndWriteImplementation imp2 = new ReadAndWriteImplementation();
//             imp2.Value = 2;
//         }
//     } 
//     interface IReadOnlyInterface
//     {
//         int Value { get; }
//     }
//     struct ReadAndWriteImplementation:IReadOnlyInterface
//     {
//         public int Value { get; set; }
//     }
// }