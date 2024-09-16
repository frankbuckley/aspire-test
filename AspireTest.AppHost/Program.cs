Console.WriteLine($"AppContext.BaseDirectory: {AppContext.BaseDirectory}");
Console.WriteLine($"Environment.CurrentDirectory: {Environment.CurrentDirectory}");

var builder = DistributedApplication.CreateBuilder(args);

Console.WriteLine($"builder.AppHostDirectory: {builder.AppHostDirectory}");

builder.AddProject<Projects.AspireTest_CLI>("cli")
    .WithArgs(
        "--option",
        "an argument",
        "--combined \"an argument\"",
        "--option",
        "\"an argument\""
    );

builder.Build().Run();
