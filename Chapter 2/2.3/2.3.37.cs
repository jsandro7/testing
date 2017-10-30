// using System;
// using System.Dynamic;


// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//              var per = new Person();
//         }
//     }   

//     class Person
//     {
//     private string _firstName;
//         public string FirstName
//         {
//             get { return _firstName; }
//             set
//             {
//                 if (string.IsNullOrWhiteSpace(value))
//                     throw new ArgumentException();
//                 _firstName = value;
//             }
//         }
//     }
// }