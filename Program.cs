using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

#pragma warning disable SKEXP0070 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var builder = Kernel.CreateBuilder().AddOllamaChatCompletion(
    modelId: "llama3.1:latest",
    endpoint: new Uri("http://localhost:11434")
);

builder.Services.AddLogging(x => x.AddConsole().SetMinimumLevel(LogLevel.Trace));

var kernel = builder.Build();
var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();