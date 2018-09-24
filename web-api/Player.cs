using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> master

namespace web_api
{
    public class Player
    {
<<<<<<< HEAD
        public Player()
        {
            Items = new List<Item>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        [Range(1, 99)]
        public int Level { get; set; }
        public bool IsBanned { get; set; }
        [DateValidation]
        public DateTime CreationTime { get; set; }
        public List<Item> Items { get; set; }

        public void Modify(ModifiedPlayer player) {
            Score = player.Score;
            Level = player.Level;
        }
=======
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsBanned { get; set; }
        public DateTime CreationTime { get; set; }
>>>>>>> master
    }
}
