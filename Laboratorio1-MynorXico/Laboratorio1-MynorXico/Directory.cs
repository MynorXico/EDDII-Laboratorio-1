using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    class Directory
    {
        public List<Song> Songs { get; set; }

        public void AddSong(Song s)
        {
            Songs.Add(s);
        }
    }
}
