﻿using System;
namespace Musicalytics.Models
{
    public class AudioEmotion
    {
        public AudioEmotion()
        {
        }

        public double emotionValue { get; set; }
        public string emotionName { get; set; }
        public string songName { get; set; }
    }
}