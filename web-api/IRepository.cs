using System;
using System.Threading.Tasks;

namespace web_api
{
    public interface IRepository
    {
<<<<<<< HEAD
        Task<Player> GetPlayer(Guid id);
        Task<Player[]> GetAllPlayers();
        Task<Player> CreatePlayer(Player player);
        Task<Player> ModifyPlayer(Guid id, ModifiedPlayer player);
        Task<Player> DeletePlayer(Guid id);

        Task<Item> GetItem(Guid playerId, Guid itemId);
        Task<Item[]> GetAllItems(Guid playerId);
        Task<Item> CreateItem(Guid playerId, Item item);
        Task<Item> ModifyItem(Guid playerId, Guid itemId, ModifiedItem item);
        Task<Item> DeleteItem(Guid playerId, Guid itemId);
=======
        Task<Player> Get(Guid id);
        Task<Player[]> GetAll();
        Task<Player> Create(Player player);
        Task<Player> Modify(Guid id, ModifiedPlayer player);
        Task<Player> Delete(Guid id);
>>>>>>> master
    }
}
