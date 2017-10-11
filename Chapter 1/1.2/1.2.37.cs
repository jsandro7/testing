using System;
using System.Threading;
using System.Threading.Tasks;


namespace test2
{
    // public static class Program
    // {       
    //     public static void Main()
    //     {
    //         object lockA = new object();
    //         object lockB = new object();

    //         var up = Task.Run(() =>{
    //             lock(lockA){
    //                 Thread.Sleep(1000);
    //                 lock(lockB){
    //                     Console.WriteLine("Locked A and B");
    //                 }
    //             }
    //         });

    //         lock(lockB){
    //             lock(lockA){
    //                 Console.WriteLine("Locked B and A");
    //             }
    //         }

    //         up.Wait();            
    //     } 
    // }
}