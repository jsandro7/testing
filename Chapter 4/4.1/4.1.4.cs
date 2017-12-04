// using System;
// using System.IO;
// using System.Security.AccessControl;

// public class MyClass
// {
//    public static void Main(string[] args)
//    {
//         DirectoryInfo directoryInfo = new DirectoryInfo("TestDirectory");
//         directoryInfo.Create();
//         DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
//         directorySecurity.AddAccessRule(new FileSystemAccessRule("everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));
//         directoryInfo.SetAccessControl(directorySecurity);
//    }
// }