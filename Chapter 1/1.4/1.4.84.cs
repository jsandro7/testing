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
    //         p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);
    //         p.Raise();    
    //     }        
    // }

    // public class MyArgs : EventArgs
    // {
    //     public MyArgs(int value)
    //     {
    //     Value = value;
    //     }
    //     public int Value { get; set; }
    // }

    // public class Pub
    // {
    //     public event EventHandler<MyArgs> OnChange = delegate { };
    //     public void Raise()
    //     {
    //         OnChange(this, new MyArgs(42));
    //     }
    // }
}