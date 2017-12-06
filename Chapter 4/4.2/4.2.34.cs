// using System;
// using System.Data.SqlClient;
// using System.Data;
// using System.Configuration;
// using System.Threading.Tasks;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         var t = UpdateRows();
//     }  


//     public static async Task UpdateRows()
//     {
//         string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             SqlCommand command = new SqlCommand("UPDATE People SET FirstName='John'",connection);
           
//             await connection.OpenAsync();

//             int numberOfUpdatedRows = await command.ExecuteNonQueryAsync();
//             Console.WriteLine("Updated {0} rows", numberOfUpdatedRows);
//         }
//     }


// }