var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Order_Api>("order-api");

builder.Build().Run();
