using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace test2
{
    // public static class Program
    // {    
    //     public static void Main()
    //     {
    //         CreateAndRaise();
    //     } 

    //     /* You can subscribe to an event and then you are notified
    //         when the publisher of the event raises a new event */
    //     public static void CreateAndRaise()
    //     {
    //         Pub p = new Pub();
    //         p.OnChange += () => Console.WriteLine("Event raised to method 1");
    //         p.OnChange += () => Console.WriteLine("Event raised to method 2");
    //         p.Raise();    
    //     }        
    // }

    // public class Pub
    // {
    //     public Action OnChange { get; set; }
    //     public void Raise()
    //     {
    //         if (OnChange != null)
    //         {
    //             OnChange();
    //         }
    //     }
    // }
}