using System.ComponentModel.DataAnnotations;

namespace web_api
{
    public class ModifiedPlayer
    {
        public int Score { get; set; }
        [Range(1, 99)]
        public int Level { get; set; }
    }
}
