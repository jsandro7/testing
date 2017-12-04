// using System;
// using System.IO;
// using System.Net;
// using System.Threading.Tasks;
// using System.Net.Http;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//        ExecuteMultipleRequests();
//     }

//     public async Task ExecuteMultipleRequests()
//     {
//         HttpClient client = new HttpClient();
//         string microsoft= await client.GetStringAsync("http://www.microsoft.com");
//         string msdn = await client.GetStringAsync("http://www.microsoft.com");
//         string blogs = await client.GetStringAsync("http://www.microsoft.com");
//     }
// }