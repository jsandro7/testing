// using System;
// using System.Data.SqlClient;
// using System.Data;
// using System.Configuration;
// using System.Threading.Tasks;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         var t = SelectDataFromTable();
//     }  


//     public static async Task SelectDataFromTable()
//     {
//         string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             SqlCommand command = new SqlCommand("SELECT * FROM People", connection);
           
//             await connection.OpenAsync();
            
//             SqlDataReader dataReader = await command.ExecuteReaderAsync();
            
//             while (await dataReader.ReadAsync())
//             {
//                 string formatStringWithMiddleName = "Person ({0}) is named {1} {2} {3}";
//                 string formatStringWithoutMiddleName = "Person ({0}) is named {1} {3}";
//                 if ((dataReader["middlename"] == null))
//                 {
//                     Console.WriteLine(formatStringWithoutMiddleName,
//                     dataReader["id"],
//                     dataReader["firstname"],
//                     dataReader["lastname"]);
//                 }
//                 else
//                 {
//                     Console.WriteLine(formatStringWithMiddleName,
//                     dataReader["id"],
//                     dataReader["firstname"],
//                     dataReader["middlename"],
//                     dataReader["lastname"]);
//                 }
//             }

//             dataReader.Close();
//         }
//     }
// }