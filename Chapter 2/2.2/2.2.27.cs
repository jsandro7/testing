// using System;
// using System.IO;
// using System.Data.SqlClient;
// using System.Data.Common;


// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//             int value = Convert.ToInt32("42");
//             value = int.Parse("42");
//             bool success = int.TryParse("42", out value);
//         }

//         static void OpenConnection(DbConnection connection)
//         {
//             if (connection is SqlConnection)
//             {
//             // run some special code
//             }
//         }
//         static void LogStream(Stream stream)
//         {
//             MemoryStream memoryStream = stream as MemoryStream;
//             if (memoryStream != null)
//             {
//             // ....
//             }
//         }
//     }
// }