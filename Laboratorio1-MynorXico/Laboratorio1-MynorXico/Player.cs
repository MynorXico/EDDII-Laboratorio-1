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
        public Directory SongsInDisk = new Directory();
        public List<PlayList> Playlists = new List<PlayList>();

        public Player()
        {
           
        }
        public void CreatePlayList(String Name)
        {
            PlayList pl = new PlayList(Name);
            Playlists.Add(pl);
        }

        public void FillGrid(DataGridView dgv, List<Song> list)
        {
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

        public void fillPlayListsBox(ListBox lb)
        {
            lb.Items.Clear();
            foreach(PlayList pl in Playlists)
            {
                lb.Items.Add(pl.Name);
            }
        }
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
