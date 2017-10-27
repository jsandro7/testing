// using System;
// using System.IO;


// namespace test2
// {
//     public static class Program
//     {     
//         static void Main (string[] args)    
//         {
//             Money m = new Money(42.42M);
//             decimal amount = m;
//             int truncatedAmount = (int)m;
//         }
//     } 
//     class Money
//     {
//         public Money(decimal amount)
//         {
//             Amount = amount;
//         }
//         public decimal Amount { get; set; }

//         public static implicit operator decimal(Money money)
//         {
//             return money.Amount;
//         }

//         public static explicit operator int(Money money)
//         {
//             return (int)money.Amount;
//         }
//     }
// }