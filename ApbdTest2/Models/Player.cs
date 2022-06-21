using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class Player
    {
        public Player()
        {
            PlayerTeams = new HashSet<PlayerTeam>();
        }

        public int IdPlayer { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int DateOfBirth { get; set; }

        public virtual ICollection<PlayerTeam> PlayerTeams { get; set; }
    }
}
