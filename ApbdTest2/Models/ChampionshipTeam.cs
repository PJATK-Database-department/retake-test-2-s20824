using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class ChampionshipTeam
    {
        public int IdChampionshipTeam { get; set; }
        public float Score { get; set; }
        public int TeamIdTeam { get; set; }
        public int ChampionshipIdChampionship { get; set; }

        public virtual Championship ChampionshipIdChampionshipNavigation { get; set; }
        public virtual Team TeamIdTeamNavigation { get; set; }
    }
}
