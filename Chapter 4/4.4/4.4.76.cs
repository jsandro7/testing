// using System;
// using System.Xml.Serialization;
// using System.Security.Permissions;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {

//     }
// }

// [Serializable]
// public class PersonComplex : ISerializable
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     private bool isDirty = false;
//     public PersonComplex() { }

//     protected PersonComplex(SerializationInfo info, StreamingContext context)
//     {
//         Id = info.GetInt32("Value1");
//         Name = info.GetString("Value2");
//         isDirty = info.GetBoolean("Value3");
//     }

//     [System.Security.Permissions.SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
//     public void GetObjectData(SerializationInfo info, StreamingContext context)
//     {
//         info.AddValue("Value1", Id);
//         info.AddValue("Value2", Name);
//         info.AddValue("Value3", isDirty);
//     }
// }
