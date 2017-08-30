using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_MynorXico
{
    class Player
    {
        // Songs in disk
        public Directory SongsInDisk = new Directory();
        public List<PlayList> Playlists = new List<PlayList>();
        
        /// <summary>
        /// Creates a new PlayList given a name
        /// </summary>
        /// <param name="Name"> Playlist Name</param>
        public void CreatePlayList(String Name)
        {
            PlayList pl = new PlayList(Name);
            Playlists.Add(pl);
        }

        /// <summary>
        /// Fills a grid given a songs playlist
        /// </summary>
        /// <param name="dgv"> DataGridView where the songs will be displayed.</param>
        /// <param name="list">List of songs</param>
        public void FillGrid(DataGridView dgv, List<Song> list)
        {
            // Checks if the file is empty
            if (list[0] == null)
            {
                MessageBox.Show("No hay canciones por mostrar");
                return;
            }
            // clears datagridview rows
            dgv.Rows.Clear();
            dgv.DataSource = null;

            // Creates empty cells
            for (int i = 0; i < list.Count; i++)
            {
                dgv.Rows.Add();
            }
            
            // Fills the grid
            for(int i = 0; i < list.Count; i++)
            {
                dgv[0, i].Value = list[i].Name;
                dgv[1, i].Value = list[i].Length;
            }
        }
        
        /// <summary>
        /// Fills a ListBox with given PlayLists
        /// </summary>
        /// <param name="lb"> List of PlayList to display</param>
        public void fillPlayListsBox(ListBox lb)
        {
            lb.Items.Clear();
            foreach(PlayList pl in Playlists)
            {
                lb.Items.Add(pl.Name);
            }
        }
        /// <summary>
        /// Fills a ListBox with given List of songs
        /// </summary>
        /// <param name="lb"></param>
        public void FillListBox(ListBox lb)
        {
            lb.Items.Clear();
            for(int i = 0; i < Playlists.Count; i++)
            {
                lb.Items.Add(Playlists[i].Name);
            }
        }
    }
}
