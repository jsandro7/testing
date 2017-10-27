using System;
using System.Collections.Generic;


namespace test2
{
    // public static class Program
    // {           
    //     public static void Main()
    //     {
    //        var t = new Nullable<int>().Value;

    //         if(t == null)  // this will error out
    //             Console.WriteLine("Null int");
           
    //     }
    // } 

    // struct Nullable<T> where T : struct
    // {
    //     private bool hasValue;
    //     private T value;
    //     public Nullable(T value)
    //     {
    //         this.hasValue = true;
    //         this.value = value;
    //     }
    //     public bool HasValue { get { return this.hasValue; } }
    //     public T Value
    //     {
    //         get
    //         {
    //             if (!this.HasValue) throw new ArgumentException();
    //                 return this.value;
    //         }
    //     }
    //     public T GetValueOrDefault()
    //     {
    //         return this.value;
    //     }
    // }    
}