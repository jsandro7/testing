// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;


// public class MyClass 
// {
//     public static void Main()
//     {
//        var cust = new Customer();

//        var val = GenericValidator<Customer>.Validate(cust);
//     } 

//     public static class GenericValidator<T>
//     {
//         public static IList<ValidationResult> Validate(T entity)
//         {
//             var results = new List<ValidationResult>();
//             var context = new ValidationContext(entity, null, null);
//             Validator.TryValidateObject(entity, context, results);
//             return results;
//         }
//     } 

//     public class Customer
//     {
//         public int Id { get; set; }

//         [Required, MaxLength(20)]
//         public string FirstName { get; set; }

//         [Required, MaxLength(20)]
//         public string LastName { get; set; }

//         [Required]
//         public Address ShippingAddress { get; set; }

//         [Required]
//         public Address BillingAddress { get; set; }
//     }

//     public class Address
//     {
//         public int Id { get; set; }
//         [Required, MaxLength(20)]
//         public string AddressLine1 { get; set; }

//         [Required, MaxLength(20)]
//         public string AddressLine2 { get; set; }

//         [Required, MaxLength(20)]
//         public string City { get; set; }

//         [RegularExpression(@"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$")]
//         public string ZipCode { get; set; }
//     }  
// }