using Kata.GidedRose.Services;
using Kata.GidedRose.Stores;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<IItemFactory, ItemFactory>();
builder.Services.AddTransient<IStore, Store>();
builder.Services.AddTransient<GidedRoseService>();
using var host = builder.Build();
host.Services.GetService<GidedRoseService>()!.Run();