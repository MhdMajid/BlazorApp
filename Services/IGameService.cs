using BA2.Entity;

namespace BA2.Services
{
    public interface IGameService
    {
       Task<List<Game>> GetAllGames();
       Task<Game> AddGame(Game game); 
       Task<Game> GetGameById(int id); 

       Task<Game> EditGame(int Id , Game game);
       Task<bool> DeleteGame(int Id);

    }
}
