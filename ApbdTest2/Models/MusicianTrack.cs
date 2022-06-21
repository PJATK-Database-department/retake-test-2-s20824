using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class MusicianTrack
    {
        public int IdMusician { get; set; }
        public int IdTrack { get; set; }

        public virtual Musician IdMusicianNavigation { get; set; }
        public virtual Track IdTrackNavigation { get; set; }
    }
}
