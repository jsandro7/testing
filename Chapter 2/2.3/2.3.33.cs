// using System;
// using System.Dynamic;


// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//              var acc = new Accessibility();
//              acc.MyProperty = "test";
//         }

//     }   

//     public class Accessibility
//     {
//         // initialization code and error checking omitted
//         private string[] _myField;
//         public string MyProperty
//         {
//             get { return _myField[0]; }
//             set { _myField[0] = value; }
//         }
//     }
// }