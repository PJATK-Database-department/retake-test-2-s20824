using System;
using System.Collections.Generic;

#nullable disable

namespace ApbdTest2.Models
{
    public partial class Track
    {
        public Track()
        {
            MusicianTracks = new HashSet<MusicianTrack>();
        }

        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public float Duration { get; set; }
        public int? IdAlbum { get; set; }

        public virtual Album IdAlbumNavigation { get; set; }
        public virtual ICollection<MusicianTrack> MusicianTracks { get; set; }
    }
}
