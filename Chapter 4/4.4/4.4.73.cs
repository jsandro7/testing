// using System;
// using System.Xml.Serialization;
// using System.Collections.Generic;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Formatters.Binary;

// public class MyClass
// {
//     public static void Main(string[] args)
//     {
//         Person p = new Person
//         {
//             Id = 1,
//             Name = "John Doe"
//         };

//         IFormatter formatter = new BinaryFormatter();
//         using (Stream stream = new FileStream("data.bin", FileMode.Create))
//         {
//             formatter.Serialize(stream, p);
//         }

//         using (Stream stream = new FileStream("data.bin", FileMode.Open))
//         {
//             Person dp = (Person)formatter.Deserialize(stream);
//         }
//     }

// }

// [Serializable]
// public class Person
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     private bool isDirty = false;
// }
