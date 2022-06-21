using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class Championship
    {
        public Championship()
        {
            ChampionshipTeams = new HashSet<ChampionshipTeam>();
        }

        public int IdChampionship { get; set; }
        public string OfficialName { get; set; }
        public int Year { get; set; }

        public virtual ICollection<ChampionshipTeam> ChampionshipTeams { get; set; }
    }
}
