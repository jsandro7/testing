// using System;
// using System.Xml.Serialization;
// using System.Security.Permissions;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Json;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         Person p = new Person
//         {
//             Id = 1,
//             Name = "John Doe"
//         };
        
//         using (MemoryStream stream = new MemoryStream())
//         {
//             DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
//             ser.WriteObject(stream, p);
//             stream.Position = 0;
//             StreamReader streamReader = new StreamReader(stream);
//             Console.WriteLine(streamReader.ReadToEnd()); // Displays {“Id”:1,”Name”:”John Doe”}
//             stream.Position = 0;
//             Person result = (Person)ser.ReadObject(stream);
//         }
//     }
// }

// [DataContract]
// public class Person
// {
// [DataMember]
// public int Id { get; set; }
// [DataMember]
// public string Name { get; set; }
// }