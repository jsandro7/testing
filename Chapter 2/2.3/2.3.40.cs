// using System;
// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             MoveableOject imp = new MoveableOject();
//             ((ILeft)imp).Move();
//             ((IRight)imp).Move();
//         }
//     } 
//     class MoveableOject : ILeft, IRight
//     {
//         void ILeft.Move() { }
//         void IRight.Move() { }
//     }    
//     interface IRight
//     {
//         void Move();
//     }
//     interface ILeft
//     {
//         void Move();
//     }
// }