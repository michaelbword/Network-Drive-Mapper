using System.Numerics;

Console.WriteLine("Mapping the H drive... Please wait");
Utility.NetworkDrive.MapNetworkDrive("H", @"\\REDACTED");
Thread.Sleep(2000);
var dirs1 = Directory.GetDirectories("H:");
Console.WriteLine("H drive mapped!");
Thread.Sleep(2000);
Console.WriteLine("Mapping the J drive... Please wait");
Utility.NetworkDrive.MapNetworkDrive("J", @"\\REDACTED");
Thread.Sleep(2000);
var dirs2 = Directory.GetDirectories("J:");
Console.WriteLine("Drive mapping complete, if you encounter an issue please email REDACTED");
Thread.Sleep(5000);
