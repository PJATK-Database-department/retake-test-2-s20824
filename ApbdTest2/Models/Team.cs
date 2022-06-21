using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class Team
    {
        public Team()
        {
            ChampionshipTeams = new HashSet<ChampionshipTeam>();
            PlayerTeams = new HashSet<PlayerTeam>();
        }

        public int IdTeam { get; set; }
        public string TeamName { get; set; }
        public int MaxAge { get; set; }

        public virtual ICollection<ChampionshipTeam> ChampionshipTeams { get; set; }
        public virtual ICollection<PlayerTeam> PlayerTeams { get; set; }
    }
}
