// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {            
//             var r = new Rectangle(4,5);
//             var area = r.Area;

//             Console.WriteLine(area);
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
// }