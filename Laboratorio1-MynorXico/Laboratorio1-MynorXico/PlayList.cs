using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    class PlayList
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public void AddSong(Song s)
        {
            Songs.Add(s);
        }
        public PlayList(string Name)
        {
            this.Name = Name;
        }
    }
}
