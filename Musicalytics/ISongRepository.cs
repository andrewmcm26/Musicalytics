using System;
using Musicalytics.Models;

namespace Musicalytics
{
    public interface ISongRepository
    {

    public double GetAudioAngry(Song song);
    public double GetAudioJoyful(Song song);
    public double GetAudioSad (Song song);
    public double GetAudioPeaceful(Song song);
    }

}
