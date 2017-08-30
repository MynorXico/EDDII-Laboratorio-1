using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    class Directory
    {
        // Songs in hard drive
        public List<Song> Songs = new List<Song>();

        // Add song to library
        public void AddSong(Song s)
        {
            Songs.Add(s);
        }
    }
}
