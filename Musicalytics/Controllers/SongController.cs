using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Musicalytics.Models;

namespace Musicalytics.Controllers
{
    public class SongController : SongRepository
    {
        public SongController()
        {
        }

        public void SortSongs()
        {
            SortSong();
        }

    }
}
