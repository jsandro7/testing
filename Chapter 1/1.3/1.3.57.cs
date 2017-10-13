using System;
using System.Threading;
using System.Threading.Tasks;


namespace test2
{
    // public static class Program
    // {    
    //     public static void Main()
    //     {
    //         bool x = true, y = false;

    //         /* BAD practice to write conditional statments */
    //         if (x) if (y) F(); else G();    

    //         /* Preffered practice */
    //         if (x)
    //         {
    //             if (y)
    //             {
    //                 F();
    //             }
    //             else
    //             {
    //                 G();
    //             }
    //         }

    //         /*Also acceptable */
    //         if (x) {
    //             if (y)                
    //                 F();                
    //             else                
    //                 G();                
    //         }
    //     } 

    //     public static void F()  {
    //         Console.WriteLine("F");
    //     }

    //     public static void G(){
    //         Console.WriteLine("G");
    //     }
    // }
}