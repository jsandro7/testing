// using System;
// using System.IO;
// using System.Net;
// using System.Threading.Tasks;
// using System.Net.Http;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//       var t = ExecuteMultipleRequestsInParallel();
//     }

//    public static async Task ExecuteMultipleRequestsInParallel()
//     {
//         HttpClient client = new HttpClient();
//         Task microsoft = client.GetStringAsync("http://www.microsoft.com");
//         Task msdn = client.GetStringAsync("http://www.microsoft.com");
//         Task blogs = client.GetStringAsync("http://www.microsoft.com");
//         await Task.WhenAll(microsoft, msdn, blogs);
//     }
// }