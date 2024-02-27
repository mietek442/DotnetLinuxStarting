using GameStore.Api.Entities;

namespace GameStore.Api.GameStoreRepos;

public interface IGamerRepos{
    Task CreateAsyc(Game game);
    Task DeleteAsyc(int id);
    Task<Game?>GetAsyc(int id);
    Task<IEnumerable<Game>> GetAllAsyc();
    Task UpdateAsyc(Game updatedgame);
}
