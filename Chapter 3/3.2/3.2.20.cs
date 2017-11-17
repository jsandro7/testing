// using System;
// using System.IO;
// using System.Security.Cryptography;
// using System.Text;

// public class MyClass 
// {
//     public static void Main()
//     {
//         string containerName = "SecretContainer";
//         CspParameters csp = new CspParameters() { KeyContainerName = containerName };

//         byte[] encryptedData;
//         using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
//         {
//             encryptedData = RSA.Encrypt(dataToEncrypt, false);
//         }
//     }
// }