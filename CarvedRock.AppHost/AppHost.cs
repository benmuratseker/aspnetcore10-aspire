var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CarvedRock_Api>("api");

builder.Build().Run();
