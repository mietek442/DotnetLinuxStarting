using GameStore.Api.Endpoints;
using GameStore.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRepositories(builder.Configuration);

var app = builder.Build();
app.Urls.Add("http://127.0.0.1:5024");
// app.Urls.Add("http://localhost:5024");

await app.Services.InitializeDbAsync();

app.MapGamesEndpoints();
app.Run();
