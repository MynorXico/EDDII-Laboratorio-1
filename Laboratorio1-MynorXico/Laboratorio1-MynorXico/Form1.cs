using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratorio1_MynorXico
{
    public partial class Form1 : Form
    {
        bool btnCreate = false;
        bool btnAdd = false;
        Player p = new Player();
        public Form1()
        {
            InitializeComponent();            
        }

        private void openFolderMenu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string[] dirs = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3");
            for(int i = 0; i < dirs.Length; i++)
            {
                string Name = dirs[i].Split('\\')[dirs[i].Split('\\').Length-1];
                double Duration = axWindowsMediaPlayer1.newMedia(dirs[i]).duration;
                Song s = new Song(Name, Duration, dirs[i]);
                p.SongsInDisk.AddSong(s);
            }
            p.FillGrid(dgvSongs, p.SongsInDisk.Songs);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (!btnCreate) {
                btnCreate = true;
                btnCreatePlaylist.Text = "Crear lista de reproducción";
                lblNewPlaylist.Visible = true;
                txtNewPlaylist.Visible = true;
                btnVerLista.Visible = false;
                btnVerBiblioteca.Visible = false;
                txtNewPlaylist.Text = "";
            }
            else
            {
                string name = txtNewPlaylist.Text;
                if (name.Trim() == "")
                    return;
                foreach (PlayList p in p.Playlists)
                {
                    if (p.Name == name)
                    {
                        MessageBox.Show($"Ya existe una lista de reproducción con el nombre {name}.\nPor favor ingrese otro nombre para la lista");
                        return;
                    }
                }
                
                PlayList pl = new PlayList(name);
                p.Playlists.Add(pl);
                MessageBox.Show($"La lista de reproducción '{name}' se ha creado con éxito.");
                p.FillListBox(lbPlayLists);
                p.fillPlayListsBox(lbSeleccionListas);
               
                btnCreate = false;
                btnCreatePlaylist.Text = "Nueva lista de reproducción";
                lblNewPlaylist.Visible = false;
                txtNewPlaylist.Visible = false;
                btnVerLista.Visible = true;
                btnVerBiblioteca.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                name = lbPlayLists.SelectedItem.ToString();
            }
            catch
            {
                return;
            }
            foreach(PlayList pl in p.Playlists)
            {
                if(pl.Name == name)
                {
                    p.FillGrid(dgvSongs, pl.Songs);
                }
            }
        }

        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            if (!btnAdd)
            {
                btnAdd = true;
                btnAgregarALista.Text = "Agregar";
                lblSeleccionListas.Visible = true;
                lbSeleccionListas.Visible = true;
                p.fillPlayListsBox(lbSeleccionListas);
            }
            else
            {
                string name = dgvSongs.Rows[dgvSongs.CurrentCell.RowIndex].Cells[0].Value.ToString();
                
                btnAdd = false;
                btnAgregarALista.Text = "Agregar a lista";
                lblSeleccionListas.Visible = false;
                lbSeleccionListas.Visible = false;
                foreach (PlayList pl in p.Playlists)
                {
                    if (pl.Name == lbSeleccionListas.SelectedItem.ToString())
                    {
                        foreach(Song s in p.SongsInDisk.Songs)
                        {
                            if(s.Name == name)
                            {
                                if(pl.Songs.Exists(x=>x.Name == name))
                                {
                                    MessageBox.Show("Esta canción ya existe en la lista.");
                                    return;
                                }
                                pl.AddSong(s);
                                MessageBox.Show("La canción se añadió correctamente");
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void btnVerBiblioteca_Click(object sender, EventArgs e)
        {
            p.FillGrid(dgvSongs, p.SongsInDisk.Songs);
        }

        private void btnOrdenarPorNombre_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                name = lbPlayLists.SelectedItem.ToString();
            }
            catch
            {
                return;
            }
            foreach (PlayList pl in p.Playlists)
            {
                if (pl.Name == name)
                {
                    pl.SortByName();
                    p.FillGrid(dgvSongs, pl.Songs);
                }
            }
        }

        private void btnOrdenarPorDuración_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                name = lbPlayLists.SelectedItem.ToString();
            }
            catch
            {
                return;
            }
            foreach (PlayList pl in p.Playlists)
            {
                if (pl.Name == name)
                {
                    pl.SortByLength();
                    p.FillGrid(dgvSongs, pl.Songs);
                }
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Song s = p.SongsInDisk.Songs.Find(x => x.Name == txtBusqueda.Text);
        }
    }
}
