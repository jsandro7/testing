using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Windows;
using System.Text;
using System.Collections.Concurrent;

namespace test2
{
    // public static class Program
    // {       
    //     public static void Main()
    //     {
    //         BlockingCollection<string> col = new BlockingCollection<string>();
    //         Task read = Task.Run(() =>
    //         {
    //             while (true)
    //             {
    //              Console.WriteLine(col.Take());
    //             }
    //         });

    //         Task write = Task.Run(() =>
    //         {
    //             while (true)
    //             {
    //                 string s = Console.ReadLine();
    //                 if (string.IsNullOrWhiteSpace(s)) break;
    //                     col.Add(s);
    //             }
    //         });

    //         write.Wait();
    //     }   

    // }
}
