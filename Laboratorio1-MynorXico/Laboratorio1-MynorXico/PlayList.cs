using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    public class PlayList
    {
        public string Name { get; set; }
        public List<Song> Songs = new List<Song>();

        public void AddSong(Song s)
        {
            Songs.Add(s);
        }
        public PlayList(string Name)
        {
            this.Name = Name;
        }
        public void SortByName()
        {
            this.Songs = Songs.OrderBy(x => x.Name).ToList<Song>();
        }
        public void SortByLength()
        {
            this.Songs = Songs.OrderBy(x => x.Length).ToList<Song>();
        }
    }
}
