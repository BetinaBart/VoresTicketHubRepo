var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Order_Api>("order-api");

builder.AddProject<Projects.Notification_Api>("notification-api");

builder.Build().Run();
