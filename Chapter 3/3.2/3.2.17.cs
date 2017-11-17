// using System;
// using System.IO;
// using System.Security.Cryptography;

// public class MyClass 
// {
//     public static void Main()
//     {
//        EncryptSomeText();
//     } 

//     public static void EncryptSomeText()
//     {
//         string original = "My secret data!";
//         using (SymmetricAlgorithm symmetricAlgorithm = new AesManaged())
//         {
//             byte[] encrypted = Encrypt(symmetricAlgorithm, original);
//             string roundtrip = Decrypt(symmetricAlgorithm, encrypted);
//             // Displays: My secret data!
//             Console.WriteLine("Original: {0}", original);
//             Console.WriteLine("Original Encrypted: {0}",  Convert.ToBase64String(new MemoryStream(encrypted).ToArray()));
//             Console.WriteLine("Round Trip: {0}", roundtrip);
//         }
//     }

//     static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
//     {
//         ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
//         using (MemoryStream msEncrypt = new MemoryStream())
//         using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
//         using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
//         {
//             swEncrypt.Write(plainText);
//             swEncrypt.Close();
//             return msEncrypt.ToArray();
//         }
//     }
//     static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
//     {
//         ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
//         using (MemoryStream msDecrypt = new MemoryStream(cipherText))
//         using (CryptoStream csDecrypt =  new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
//         using (StreamReader srDecrypt = new StreamReader(csDecrypt))
//         {
//             return srDecrypt.ReadToEnd();            
//         }
//     }
// }