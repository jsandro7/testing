// using System;
// using System.IO;

// public class MyClass 
//     {
//         public static void Main()
//         {
//             string t1 = "1";
//             string t2 = new String('t',1);
//             String t3 = new String(new char[1] {'1'});
//             string t4 = String.Empty;
//             String t5 = null;

//             t4 += t3;
//             Console.WriteLine(t4);

//             t5 += t4;
//             Console.WriteLine(t5);

//             string test = "Dennis";
//             Console.WriteLine("{0} or {1}", test[2], test[5]);


//             char[] test1 = test.ToCharArray();
//             char[] test2 = {'D', 'e', 'n', 'n', 'i', 's'};
//             string test3 = " Garcia";
//             string test4 = test1 + test3;

//             Console.WriteLine(test4);

//             //var test5 = test1 + test2;

//             var test5 = new char[13];
//             Array.Copy(test1, test5,test1.Length);
//             Array.Copy(test3.ToCharArray(),0,test5, test1.Length, test3.Length);
//             Console.WriteLine(test5);

//             var test6 = test + test3;
//             Console.WriteLine(test6);


//             string s = string.Empty;
//             for (int i = 0; i < 10000; i++)
//             {
//                 s += "x";
//             }
//         }
//     }