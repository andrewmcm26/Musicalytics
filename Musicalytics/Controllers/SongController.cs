using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicalytics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Musicalytics.Controllers
{
    public class SongController : Controller
    {
        public SongController()
        {
        }

        public IActionResult JoyfulIndex()
        {
            var repo = new SongRepository();
            repo.SortSong();
            return View(repo.joyfulSongs);
        }
        public IActionResult AngryIndex()
        {
            var repo = new SongRepository();
            repo.SortSong();
            return View(repo.angrySongs);
        }
        public IActionResult SadIndex()
        {
            var repo = new SongRepository();
            repo.SortSong();
            return View(repo.sadSongs);
        }
        public IActionResult PeacefulIndex()
        {
            var repo = new SongRepository();
            repo.SortSong();
            return View(repo.peacefulSongs);
        }

    }
}
