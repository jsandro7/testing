// using System;
// using System.Diagnostics;
// using System.Reflection;
// using System.Linq;


// public static class Program
//     {           
//         public static void Main()
//         {   
//             Assembly pluginAssembly = Assembly.Load("test2");
//             var plugins = from type in pluginAssembly.GetTypes()
//             where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
//             select type;

//             foreach (Type pluginType in plugins)
//             {
//                 IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
//             }
//         }     
//     }

//     public class MyPlugin : IPlugin
//     {
//         public string Name
//         {
//             get { return "MyPlugin"; }
//         }
//         public string Description
//         {
//             get { return "My Sample Plugin"; }
//         }
//         public bool Load(MyApplication application)
//         {
//             return true;
//         }
//     }

//     public interface IPlugin
//     {
//         string Name { get; }
//         string Description { get; }
//         bool Load(MyApplication application);
//     }

//     public class MyApplication{}