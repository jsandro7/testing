// using System;
// using System.Data.SqlClient;
// using System.Data;
// using System.Configuration;
// using System.Threading.Tasks;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

//         using (TransactionScope transactionScope = new TransactionScope())
//         {
//             using (SqlConnection connection = new SqlConnection(connectionString))
//             {
//                 connection.Open();
//                 SqlCommand command1 = new SqlCommand("INSERT INTO People ([FirstName], [LastName], [MiddleInitial]) VALUES('John', 'Doe', null)", connection);
//                 SqlCommand command2 = new SqlCommand("INSERT INTO People ([FirstName], [LastName], [MiddleInitial]) VALUES('Jane', 'Doe', null)", connection);
//                 command1.ExecuteNonQuery();
//                 command2.ExecuteNonQuery();
//             }
//             transactionScope.Complete();
//         }
//     } 
// }