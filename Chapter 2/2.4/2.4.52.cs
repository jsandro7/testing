// using System;
// using System.Collections.Generic;
// using System.Linq;


//     public static class Program
//     {           
//         public static void Main()
//         {            
//             Rectangle rectangle = new Square(4);
//             rectangle.Width = 10;
//             rectangle.Height = 5;
//             Console.WriteLine(rectangle.Area);
//         }
//     }


//     class Square : Rectangle
//     {
//         public Square(int size) : base(size, size) {}
//         public override int Width
//         {
//             get { return base.Width; }
//             set
//             {
//                 base.Width = value;
//                 base.Height = value;
//             }
//         }
//         public override int Height
//         {
//             get { return base.Height; }
//             set
//             {
//                 base.Height = value;
//                 base.Width = value;
//             }
//         }
//     }

//     class Rectangle
//     {
//         public Rectangle(int width, int height)
//         {
//             Width = width;
//             Height = height;
//         }
//         public virtual int Height { get; set; }
//         public virtual int Width { get; set; }
//         public int Area
//         {
//             get { return Height*Width; }
//         }
//     }
