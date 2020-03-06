using System;
using System.Collections.Generic;
using System.IO;
using Musicalytics.Models;
using Newtonsoft.Json;
using System.Linq;

namespace Musicalytics
{
    public class SongRepository : ISongRepository
    {
        public SongRepository()
        {
        }

        public List<Song> LoadJson()
        {
            using (StreamReader r = new StreamReader("TracksJSON.json"))
            {
                string json = r.ReadToEnd();
                List<Song> audioItems = JsonConvert.DeserializeObject<List<Song>>(json);
                return audioItems;
            }
        }

        public double GetAudioAngry(Song song)
        {
            return Math.Round(Math.Sqrt((1 - song.valence) * song.energy), 3);
        }

        public double GetAudioJoyful(Song song)
        {
            return Math.Round(Math.Sqrt(song.valence * song.energy), 3);
        }

        public double GetAudioSad(Song song)
        {
            return Math.Round(Math.Sqrt((1 - song.valence) * (1 - song.energy)), 3);
        }

        public double GetAudioPeaceful(Song song)
        {
            return Math.Round(Math.Sqrt(song.valence * (1 - song.energy)), 3);
        }

        public double[] GetEmotionValues (Song song)
        {
            var angry = GetAudioAngry(song);
            var joyful = GetAudioJoyful(song);
            var sad = GetAudioSad(song);
            var peaceful = GetAudioPeaceful(song);
            return new double[4] { angry, joyful, sad, peaceful };
        }

        public AudioEmotion GetEmotion(Song song)
        {
            var songE = new AudioEmotion();
            songE.songName = song.name;
            songE.artistName = song.artist;

            var arr = GetEmotionValues(song);
            songE.emotionValue = arr.Max();
            var indexOfMax = arr.ToList().IndexOf(arr.Max());
            if(indexOfMax == 0)
            {
                songE.emotionName = "Angry";
            }
            if(indexOfMax == 1)
            {
                songE.emotionName = "Joyful";
            }
            if(indexOfMax == 2)
            {
                songE.emotionName = "Sad";
            }
            if(indexOfMax == 3)
            {
                songE.emotionName = "Peaceful";
            }

            return songE;
        }

        public List<AudioEmotion> angrySongs = new List<AudioEmotion>();
        public List<AudioEmotion> joyfulSongs = new List<AudioEmotion>();
        public List<AudioEmotion> sadSongs = new List<AudioEmotion>();
        public List<AudioEmotion> peacefulSongs = new List<AudioEmotion>();

        public void SortSong()
        {
            var audioItems = LoadJson();

            foreach (var item in audioItems)
            {
                var songAudioEmotion = new AudioEmotion();
                songAudioEmotion = GetEmotion(item);
                if (songAudioEmotion.emotionName == "Angry")
                {
                    angrySongs.Add(songAudioEmotion);
                }

                if (songAudioEmotion.emotionName == "Joyful")
                {
                    joyfulSongs.Add(songAudioEmotion);
                }

                if (songAudioEmotion.emotionName == "Sad")
                {
                    sadSongs.Add(songAudioEmotion);
                }   

                if (songAudioEmotion.emotionName == "Peaceful")
                {
                    peacefulSongs.Add(songAudioEmotion);
                }
            }
            angrySongs = angrySongs.OrderByDescending(x => x.emotionValue).ToList();
            joyfulSongs = joyfulSongs.OrderByDescending(x => x.emotionValue).ToList();
            sadSongs = sadSongs.OrderByDescending(x => x.emotionValue).ToList();
            peacefulSongs = peacefulSongs.OrderByDescending(x => x.emotionValue).ToList();
        }    
    }
}