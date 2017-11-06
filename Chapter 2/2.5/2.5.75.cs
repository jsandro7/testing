// using System;
// using System.Diagnostics;
// using System.Reflection;
// using System.Linq;
// using System.CodeDom;
// using System.IO;
// using Microsoft.CSharp;


// public static class Program
//     {           
//         public static void Main()
//         {                         
//             CSharpCodeProvider provider = new CSharpCodeProvider();
//             using (StreamWriter sw = new StreamWriter("HelloWorld.cs", false))
//             {
//                 IndentedTextWriter tw = new IndentedTextWriter(sw, " ");
//                 provider.GenerateCodeFromCompileUnit(compileUnit, tw, new CodeGeneratorOptions());
//                 tw.Close();
//             }
//         }         
//     }