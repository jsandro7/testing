// using System;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             ReadAndWriteImplementation imp = new ReadAndWriteImplementation();
//             int test = imp.Value;
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