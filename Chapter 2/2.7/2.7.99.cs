// using System;
// using System.Globalization;

// public class MyClass 
// {
//     public static void Main()
//     {
//         Person p = new Person("John", "Doe");

//         Console.WriteLine(p.ToString("G")); // Displays John Doe
//         Console.WriteLine(p.ToString("LSF")); // Displays Doe, John
//         Console.WriteLine(p.ToString("FL")); // Displays John Doe
//     }

//     class Person
//     {
//         public Person(string firstName, string lastName)
//         {
//             this.FirstName = firstName;
//             this.LastName = lastName;
//         }
//         public string FirstName { get; set; }
//         public string LastName { get; set; }

//         public override string ToString()
//         {
//             return FirstName + LastName;
//         }

//         public string ToString(string format)
//         {
//             if (string.IsNullOrWhiteSpace(format) || format == "G")
//                 format = "FL";
            
//             format = format.Trim().ToUpperInvariant();

//             switch (format)
//             {
//                 case "FL":
//                     return FirstName + " " + LastName;
//                 case "LF":
//                     return LastName + " " + FirstName;
//                 case "FSL":
//                     return FirstName + ", " + LastName;
//                 case "LSF":
//                     return LastName + ", " + FirstName;
//                 default:
//                 throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
//             }
//         }
//     }
// }