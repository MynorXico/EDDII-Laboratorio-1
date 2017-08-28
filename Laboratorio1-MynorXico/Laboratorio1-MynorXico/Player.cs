using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    class Player
    {
        public Directory SongsInDisk = new Directory();

        public Player()
        {
            for (int i = 0; i < 10; i++)        // 10 Provisional Songs...
            {
                SongsInDisk.AddSong(new Song(String.Format($"Song #{i}"), i));
            }
        }
    }
}
