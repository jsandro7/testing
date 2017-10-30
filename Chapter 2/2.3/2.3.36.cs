// using System;
// using System.Dynamic;


// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//              var acc = new MyInternalClass();
//         }
//     }   

//     internal class MyInternalClass
//     {
//         /* old way of create properties */
//         private int _field;
//         public void SetValue(int value) { _field = value; }
//         public int GetValue() { return _field; }
//     }
// }