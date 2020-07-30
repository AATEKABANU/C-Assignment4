using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AAssignment_4.Models
{
    public class Game
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int PublicationYear { get; set; }
        public int MinimumPlayers { get; set; }
        public int MaximumPlayers { get; set; }
         
    }
}
