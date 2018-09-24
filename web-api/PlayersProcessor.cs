using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace web_api
{
    public class PlayersProcessor
    {
        private IRepository _repository;

        public PlayersProcessor(IRepository repository) {
            _repository = repository;
        }

        public Task<Player> Get(Guid id)
        {
<<<<<<< HEAD
            return _repository.GetPlayer(id);
=======
            return _repository.Get(id);
>>>>>>> master
        }

        public Task<Player[]> GetAll()
        {
<<<<<<< HEAD
            return _repository.GetAllPlayers();
=======
            return _repository.GetAll();
>>>>>>> master
        }

        public Task<Player> Create(NewPlayer player)
        {
            Player newPlayer = new Player();
            newPlayer.Name = player.Name;
            // set other values for new player
            newPlayer.Id = Guid.NewGuid();
            newPlayer.CreationTime = System.DateTime.Now;

<<<<<<< HEAD
            return _repository.CreatePlayer(newPlayer);
=======
            return _repository.Create(newPlayer);
>>>>>>> master
        }

        public Task<Player> Modify(Guid id, ModifiedPlayer player)
        {
<<<<<<< HEAD
            return _repository.ModifyPlayer(id, player);
=======
            return _repository.Modify(id, player);
>>>>>>> master
        }

        public Task<Player> Delete(Guid id)
        {
<<<<<<< HEAD
            return _repository.DeletePlayer(id);
=======
            return _repository.Delete(id);
>>>>>>> master
        }
    }
}
