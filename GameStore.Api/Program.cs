using GameStore.Api.Endpoints;
using GameStore.Api.Data;
using Microsoft.AspNetCore.Http;
using System.Net;
using GameStore.Api.Extensions;
// using GameStore.Api.Extensions.;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRepositories(builder.Configuration);
builder.Services.AddCors();
builder.Services.ConfigureCors();


var app = builder.Build();

app.Urls.Add("http://127.0.0.1:5024");
app.UseCors("CorsPolicy");




app.MapGet("/",()=>"succes");



await app.Services.InitializeDbAsync();
app.MapGamesEndpoints();

app.Run();
