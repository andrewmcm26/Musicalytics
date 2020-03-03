using System;
using System.Collections.Generic;
using System.IO;
using Musicalytics.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Musicalytics
{
    public class SongRepository : ISongRepository
    {
        public SongRepository()
        {
        }

        public double GetAudioAngry(Song song)
        {
            return Math.Sqrt((1 - song.valence) * song.energy);
        }

        public double GetAudioJoyful(Song song)
        {
            return Math.Sqrt(song.valence * song.energy);
        }

        public double GetAudioSad(Song song)
        {
            return Math.Sqrt((1 - song.valence) * (1 - song.energy));
        }

        public double GetAudioPeaceful(Song song)
        {
            return Math.Sqrt(song.valence * (1 - song.energy));
        }

        
    }
}