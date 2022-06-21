using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class PlayerTeam
    {
        public int IdPlayerTeam { get; set; }
        public int NumOfShirt { get; set; }
        public string Comment { get; set; }
        public int PlayerIdPlayer { get; set; }
        public int TeamIdTeam { get; set; }

        public virtual Player PlayerIdPlayerNavigation { get; set; }
        public virtual Team TeamIdTeamNavigation { get; set; }
    }
}
