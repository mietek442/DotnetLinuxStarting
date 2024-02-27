using GameStore.Api.Entities;

namespace GameStore.Api.GameStoreRepos;
public class InGamerRepos:IGamerRepos
{
   private readonly List<Game> games = new(){
    new Game(){
        Id = 1,
        Name = "fifa",
        Genre = "najnowsza",
        Price = (decimal)19.99,
        RelaseDate = new DateTime(2021,2,1),
        ImgUrl = "https://placehold.co/100"
    },
    new Game(){
        Id = 2,
        Name = "tombrider",
        Genre = "ladna pani",
        Price = (decimal)39.99,
        RelaseDate = new DateTime(2021,2,1),
        ImgUrl = "https://placehold.co/100"
    },new Game(){
        Id = 3,
        Name = "farming",
        Genre = "stymulator",
        Price = (decimal)79.99,
        RelaseDate =  new DateTime(2021,2,1),
        ImgUrl = "https://placehold.co/100"
    },new Game(){
        Id = 4,
        Name = "CS GO",
        Genre = "RPG",
        Price = 79.99M,
        RelaseDate = new DateTime(2011,2,1),
        ImgUrl = "https://placehold.co/100"
    }
};

    // public InGamerRepos()
    // {
    // }

    public async Task< IEnumerable<Game>> GetAllAsyc()   
    {
        return await Task.FromResult(games);      
    }
    public async Task<Game?> GetAsyc(int id){
        return await Task.FromResult( games.Find(game=>game.Id==id));
    }
    public async Task CreateAsyc(Game game){
        game.Id = games.Max(game=>game.Id)+1;
        games.Add(game);
        await Task.CompletedTask;
    }
    public async Task UpdateAsyc(Game updatedgame){
        var index = games.FindIndex(game=>game.Id == updatedgame.Id);
        games[index] = updatedgame;
        await Task.CompletedTask;
    }
    public async Task DeleteAsyc(int id){
        var index = games.FindIndex(game=>game.Id == id);
        games.RemoveAt(index);
        await Task.CompletedTask;
    }
}