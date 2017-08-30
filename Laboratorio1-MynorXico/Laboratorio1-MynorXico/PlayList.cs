using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    public class PlayList
    {
        /// <summary>
        /// PlayList properties
        /// </summary>
        public string Name { get; set; }
        public List<Song> Songs = new List<Song>();

        /// <summary>
        /// Adds a song to the playlist given a song.
        /// </summary>
        /// <param name="s">Song to add.</param>
        public void AddSong(Song s)
        {
            Songs.Add(s);
        }
        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="Name"> Name of the new playlist.</param>
        public PlayList(string Name)
        {
            this.Name = Name;
        }
        /// <summary>
        /// Array with its elements sorted by name.
        /// </summary>
        /// <param name="ascendent"></param>
        public void SortByName(bool ascendent)
        {
            // If it's ordered ascendent the array is ordered descendent.
            if (ascendent)
                this.Songs = Songs.OrderBy(x => x.Name).ToList<Song>();
            else
                this.Songs = Songs.OrderByDescending(x => x.Name).ToList<Song>();
        }
        /// <summary>
        /// Array with its elements sorted by length
        /// </summary>
        /// <param name="ascendent"></param>
        public void SortByLength(bool ascendent)
        {
            // If it's ordered ascendent the array is ordered descendennt
            if (ascendent)
                this.Songs = Songs.OrderBy(x => x.Name).ToList<Song>();
            else
                this.Songs = Songs.OrderByDescending(x => x.Name).ToList<Song>();
        }
    }
}
