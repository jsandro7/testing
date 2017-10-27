// using System;
// using System.Dynamic;


// namespace test2
// {
//     public static class Program
//     {           
//         public static void Main()
//         {
//            dynamic obj = new SampleObject();
//             Console.WriteLine(obj.SomeProperty); // Displays ‘SomeProperty’   
//         }
//     }
//     public class SampleObject : DynamicObject
//     {
//         public override bool TryGetMember(GetMemberBinder binder, out object result)
//         {
//             result = binder.Name;
//             return true;
//         }
//     }
// }