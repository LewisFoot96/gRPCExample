var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.gRPCExampleService>("grpcexampleservice");

builder.AddProject<Projects.gRPCClientExample>("grpcclientexample");

builder.Build().Run();
