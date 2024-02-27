using GameStore.Api.Data;
using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.GameStoreRepos;

public class EntityFrameworkGamesRepository : IGamerRepos
{
    private readonly GameStoreContext dbContext;

    public EntityFrameworkGamesRepository(GameStoreContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Game>> GetAllAsyc()
    {
       return await dbContext.Games.AsNoTracking().ToListAsync();
    }
    public async Task<Game?> GetAsyc(int id)
    {
        return await dbContext.Games.FindAsync(id);
    }
     public  async Task CreateAsyc(Game game)
    {
        dbContext.Games.Add(game);
       await dbContext.SaveChangesAsync();
    }
    public async Task UpdateAsyc(Game updatedgame)
    {
       dbContext.Update(updatedgame);
       await dbContext.SaveChangesAsync();

    }
    public async Task DeleteAsyc(int id)
    {
        await dbContext.Games.Where(game=>game.Id ==id).ExecuteDeleteAsync();
    }
}