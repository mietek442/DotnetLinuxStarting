using GameStore.Api.Dtos;
using GameStore.Api.Entities;
using GameStore.Api.GameStoreRepos;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{const string GetGameEndpointName = "GetGame";



public static RouteGroupBuilder MapGamesEndpoints(this IEndpointRouteBuilder routes){
    var group = routes.MapGroup("/games").WithParameterValidation();
    InGamerRepos repository = new();
group.MapGet("/",async (IGamerRepos repository)=> 
(await repository.GetAllAsyc()).Select(game=>game.AsDto()));

group.MapGet("/{id}",async (IGamerRepos repository,int id)=> {
    Game? game = await repository.GetAsyc(id);

    if(game is null){
        return Results.NotFound();
    }
    return Results.Ok(game.AsDto());
    }
).WithName(GetGameEndpointName);  


group.MapPost("/",async (IGamerRepos repository,CreateGameDto gameDto)=>{
    Game game = new(){
        Name = gameDto.Name,
        Genre = gameDto.Genre,
        Price = gameDto.Price,
        RelaseDate = gameDto.RelaseDate,
        ImgUrl = gameDto.ImgUrl
    };
    
    await repository.CreateAsyc(game);
    return Results.CreatedAtRoute(GetGameEndpointName,new {id=game.Id},game); 
});

group.MapPut("/{id}",async (IGamerRepos repository,int id, UpdateGameDto updateGameDto)=>{
Game? existingGame = await repository.GetAsyc(id);
    if(existingGame is null){
        return Results.NotFound();
    }
    existingGame.Name = updateGameDto.Name;
    existingGame.Genre = updateGameDto.Genre;
    existingGame.Price = updateGameDto.Price;
    existingGame.RelaseDate = updateGameDto.RelaseDate;
    existingGame.ImgUrl = updateGameDto.ImgUrl;

    await repository.UpdateAsyc(existingGame);


    return Results.CreatedAtRoute(GetGameEndpointName,new {id=existingGame.Id},existingGame); 
    
    
});

group.MapDelete("/{id}",async (IGamerRepos repository,int id)=> {
    Game? game = await repository.GetAsyc(id);
    if(game is not null){
        await repository.DeleteAsyc(id);
    }else{
         return Results.NotFound();
    }
    return Results.NoContent();
});
    return group;
    }
}