using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1_MynorXico
{
    public partial class PlaylistSelection : Form
    {
        public int indexSelection;
        public PlaylistSelection(List<PlayList> PlayLists)
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            indexSelection = lbPlaylists.SelectedIndex;
            this.Close();
        }
    }
}
