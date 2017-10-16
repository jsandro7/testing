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
    //        Pub p = new Pub();
    //         p.OnChange += (sender,e ) => Console.WriteLine("Subscriber 1 called");
    //         p.OnChange += (sender, e) => { throw new Exception(); };
    //         p.OnChange += (sender,e ) => Console.WriteLine("Subscriber 3 called");
    //         p.Raise(); 
    //     }        
    // }

    // public class Pub
    // {
    //     public event EventHandler OnChange = delegate { };
    //     public void Raise()
    //     {
    //         OnChange(this, EventArgs.Empty);
    //     }       
    // }
}