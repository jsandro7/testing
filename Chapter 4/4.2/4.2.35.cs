// using System;
// using System.Data.SqlClient;
// using System.Data;
// using System.Configuration;
// using System.Threading.Tasks;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         var t = InsertRowWithParameterizedQuery();
//     }  

//     public static async Task InsertRowWithParameterizedQuery()
//     {
//         string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             SqlCommand command = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleName]) VALUES(@firstName, @lastName, @middleName)",connection);
           
//             await connection.OpenAsync();

//             command.Parameters.AddWithValue("@firstName", "John");
//             command.Parameters.AddWithValue("@lastName", "Doe");
//             command.Parameters.AddWithValue("@middleName", "Little");
//             int numberOfInsertedRows = await command.ExecuteNonQueryAsync();
//             Console.WriteLine("Inserted {0} rows", numberOfInsertedRows);
//         }
//     }
// }