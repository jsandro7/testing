using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Windows;
using System.Text;

namespace test2
{
    // public static class Program
    // {       
    //     public static void Main()
    //     {
    //        Button_Click(null,null);
    //     }

    //     private static async void Button_Click(object sender, EventArgs e)
    //     {
    //         HttpClient httpClient = new HttpClient();
    //         /*Both awaits use the ConfigureAwait(false) method because if the first method is already
    //             finished before the awaiter checks, the code still runs on the UI thread. */
    //         string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);  
           
    //        using (FileStream sourceStream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
    //         {
    //             byte[] encodedText = Encoding.Unicode.GetBytes(content);
    //             await sourceStream.WriteAsync(encodedText, 0, encodedText.Length).ConfigureAwait(false);
    //         };
    //     }
        
    // }
}
