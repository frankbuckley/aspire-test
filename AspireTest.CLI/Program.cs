Console.WriteLine($"AppContext.BaseDirectory: {AppContext.BaseDirectory}");
Console.WriteLine($"Environment.CurrentDirectory: {Environment.CurrentDirectory}");

for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"args[{i}]: {args[i]}");
}

Console.WriteLine("Press any key to exit...");
Console.ReadLine();