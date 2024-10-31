var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SistemaDeTarefas>("sistemadetarefas");

builder.Build().Run();
