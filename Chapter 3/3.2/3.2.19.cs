// using System;
// using System.IO;
// using System.Security.Cryptography;
// using System.Text;

// public class MyClass 
// {
//     public static void Main()
//     {
//         RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
//         string publicKeyXML = rsa.ToXmlString(false);
//         string privateKeyXML = rsa.ToXmlString(true);

//         UnicodeEncoding ByteConverter = new UnicodeEncoding();
//         byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");
//         byte[] encryptedData;
//         using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
//         {
//             RSA.FromXmlString(publicKeyXML);
//             encryptedData = RSA.Encrypt(dataToEncrypt, false);
//         }
//         byte[] decryptedData;
//         using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
//         {
//             RSA.FromXmlString(privateKeyXML);
//             decryptedData = RSA.Decrypt(encryptedData, false);
//         }

//         string decryptedString = ByteConverter.GetString(decryptedData);
//         Console.WriteLine(decryptedString); // Displays: My Secret Data!
//     } 

// }