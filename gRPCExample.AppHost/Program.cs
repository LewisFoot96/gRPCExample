var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.gRPCExampleService>("grpcexampleservice");

builder.Build().Run();
