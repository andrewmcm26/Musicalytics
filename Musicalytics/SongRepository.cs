using System;
using Musicalytics.Models;

namespace Musicalytics
{
    public class SongRepository : ISongRepository
    {
        public SongRepository()
        {
        }

        public double GetAudioAngry(Song song)
        {
            return Math.Sqrt((1 - song.Valence) * song.Energy);
        }

        public double GetAudioJoyful(Song song)
        {
            return Math.Sqrt(song.Valence * song.Energy);
        }

        public double GetAudioSad(Song song)
        {
            return Math.Sqrt((1 - song.Valence) * (1 - song.Energy));
        }

        public double GetAudioPeaceful(Song song)
        {
            return Math.Sqrt(song.Valence * (1 - song.Energy));
        }
    }
}