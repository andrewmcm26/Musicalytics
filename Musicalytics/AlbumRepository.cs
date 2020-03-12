using System;
using System.Collections.Generic;
using System.IO;
using Musicalytics.Models;
using Newtonsoft.Json;
using System.Linq;
namespace Musicalytics
{
    public class AlbumRepository
    {
        public AlbumRepository()
        {
        }

        public List<Album> LoadAlbumJSON()
        {
            using (StreamReader r = new StreamReader("AlbumsJSON.json"))
            {
                string json = r.ReadToEnd();
                List<Album> albumItems = JsonConvert.DeserializeObject<List<Album>>(json);
                return albumItems;
            }
        }


    }
}
