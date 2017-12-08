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
//         PersonDataContract p = new PersonDataContract
//         {
//             Id = 1,
//             Name = "John Doe"
//         };
        
//         using (Stream stream = new FileStream("data.xml", FileMode.Create))
//         {
//             DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
//             ser.WriteObject(stream, p);
//         }

//         using (Stream stream = new FileStream("data.xml", FileMode.Open))
//         {
//             DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
//             PersonDataContract result = (PersonDataContract)ser.ReadObject(stream);
//         }
//     }
// }

// [DataContract]
// public class PersonDataContract
// {
//     [DataMember]
//     public int Id { get; set; }
//     [DataMember]
//     public string Name { get; set; }
//     private bool isDirty = false;
// }