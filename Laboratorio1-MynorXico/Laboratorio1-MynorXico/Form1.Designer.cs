namespace Laboratorio1_MynorXico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.Canción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.lblNewPlaylist = new System.Windows.Forms.Label();
            this.txtNewPlaylist = new System.Windows.Forms.TextBox();
            this.lbPlayLists = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.btnAgregarALista = new System.Windows.Forms.Button();
            this.lbSeleccionListas = new System.Windows.Forms.ListBox();
            this.lblSeleccionListas = new System.Windows.Forms.Label();
            this.btnVerBiblioteca = new System.Windows.Forms.Button();
            this.btnOrdenarPorNombre = new System.Windows.Forms.Button();
            this.btnOrdenarPorDuración = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 486);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1293, 45);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderMenu});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // openFolderMenu
            // 
            this.openFolderMenu.Name = "openFolderMenu";
            this.openFolderMenu.Size = new System.Drawing.Size(221, 22);
            this.openFolderMenu.Text = "Abrir carpeta con canciones";
            this.openFolderMenu.Click += new System.EventHandler(this.openFolderMenu_Click);
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Canción,
            this.Artist,
            this.Length});
            this.dgvSongs.Location = new System.Drawing.Point(506, 27);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.Size = new System.Drawing.Size(743, 452);
            this.dgvSongs.TabIndex = 2;
            // 
            // Canción
            // 
            this.Canción.HeaderText = "Name";
            this.Canción.Name = "Canción";
            this.Canción.Width = 500;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artista";
            this.Artist.Name = "Artist";
            // 
            // Length
            // 
            this.Length.HeaderText = "Duración";
            this.Length.Name = "Length";
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(282, 42);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(190, 23);
            this.btnCreatePlaylist.TabIndex = 3;
            this.btnCreatePlaylist.Text = "Nueva lista de reproducción";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // lblNewPlaylist
            // 
            this.lblNewPlaylist.AutoSize = true;
            this.lblNewPlaylist.Location = new System.Drawing.Point(291, 79);
            this.lblNewPlaylist.Name = "lblNewPlaylist";
            this.lblNewPlaylist.Size = new System.Drawing.Size(91, 13);
            this.lblNewPlaylist.TabIndex = 4;
            this.lblNewPlaylist.Text = "Nombre de la lista";
            this.lblNewPlaylist.Visible = false;
            // 
            // txtNewPlaylist
            // 
            this.txtNewPlaylist.Location = new System.Drawing.Point(285, 95);
            this.txtNewPlaylist.Name = "txtNewPlaylist";
            this.txtNewPlaylist.Size = new System.Drawing.Size(187, 20);
            this.txtNewPlaylist.TabIndex = 5;
            this.txtNewPlaylist.Visible = false;
            // 
            // lbPlayLists
            // 
            this.lbPlayLists.FormattingEnabled = true;
            this.lbPlayLists.Location = new System.Drawing.Point(27, 58);
            this.lbPlayLists.Name = "lbPlayLists";
            this.lbPlayLists.Size = new System.Drawing.Size(201, 407);
            this.lbPlayLists.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listas de Reproducción";
            // 
            // btnVerLista
            // 
            this.btnVerLista.Location = new System.Drawing.Point(282, 71);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(190, 23);
            this.btnVerLista.TabIndex = 8;
            this.btnVerLista.Text = "Ver canciones en lista";
            this.btnVerLista.UseVisualStyleBackColor = true;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // btnAgregarALista
            // 
            this.btnAgregarALista.Location = new System.Drawing.Point(1255, 58);
            this.btnAgregarALista.Name = "btnAgregarALista";
            this.btnAgregarALista.Size = new System.Drawing.Size(190, 23);
            this.btnAgregarALista.TabIndex = 9;
            this.btnAgregarALista.Text = "Agregar a lista de reproducción";
            this.btnAgregarALista.UseVisualStyleBackColor = true;
            this.btnAgregarALista.Click += new System.EventHandler(this.btnAgregarALista_Click);
            // 
            // lbSeleccionListas
            // 
            this.lbSeleccionListas.FormattingEnabled = true;
            this.lbSeleccionListas.Location = new System.Drawing.Point(1281, 100);
            this.lbSeleccionListas.Name = "lbSeleccionListas";
            this.lbSeleccionListas.Size = new System.Drawing.Size(120, 95);
            this.lbSeleccionListas.TabIndex = 10;
            this.lbSeleccionListas.Visible = false;
            // 
            // lblSeleccionListas
            // 
            this.lblSeleccionListas.AutoSize = true;
            this.lblSeleccionListas.Location = new System.Drawing.Point(1267, 84);
            this.lblSeleccionListas.Name = "lblSeleccionListas";
            this.lblSeleccionListas.Size = new System.Drawing.Size(164, 13);
            this.lblSeleccionListas.TabIndex = 11;
            this.lblSeleccionListas.Text = "Seleccionar lista de reproducción";
            this.lblSeleccionListas.Visible = false;
            // 
            // btnVerBiblioteca
            // 
            this.btnVerBiblioteca.Location = new System.Drawing.Point(282, 100);
            this.btnVerBiblioteca.Name = "btnVerBiblioteca";
            this.btnVerBiblioteca.Size = new System.Drawing.Size(190, 23);
            this.btnVerBiblioteca.TabIndex = 12;
            this.btnVerBiblioteca.Text = "Ver canciones en bibliioteca";
            this.btnVerBiblioteca.UseVisualStyleBackColor = true;
            this.btnVerBiblioteca.Click += new System.EventHandler(this.btnVerBiblioteca_Click);
            // 
            // btnOrdenarPorNombre
            // 
            this.btnOrdenarPorNombre.Location = new System.Drawing.Point(282, 129);
            this.btnOrdenarPorNombre.Name = "btnOrdenarPorNombre";
            this.btnOrdenarPorNombre.Size = new System.Drawing.Size(190, 23);
            this.btnOrdenarPorNombre.TabIndex = 13;
            this.btnOrdenarPorNombre.Text = "Ordenar por nombre";
            this.btnOrdenarPorNombre.UseVisualStyleBackColor = true;
            this.btnOrdenarPorNombre.Click += new System.EventHandler(this.btnOrdenarPorNombre_Click);
            // 
            // btnOrdenarPorDuración
            // 
            this.btnOrdenarPorDuración.Location = new System.Drawing.Point(282, 158);
            this.btnOrdenarPorDuración.Name = "btnOrdenarPorDuración";
            this.btnOrdenarPorDuración.Size = new System.Drawing.Size(190, 23);
            this.btnOrdenarPorDuración.TabIndex = 14;
            this.btnOrdenarPorDuración.Text = "Ordenar por duración";
            this.btnOrdenarPorDuración.UseVisualStyleBackColor = true;
            this.btnOrdenarPorDuración.Click += new System.EventHandler(this.btnOrdenarPorDuración_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Búscar por nombre";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(22, 29);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(152, 20);
            this.txtBusqueda.TabIndex = 16;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(22, 55);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 17;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBusqueda);
            this.panel1.Location = new System.Drawing.Point(260, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 87);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOrdenarPorDuración);
            this.Controls.Add(this.btnOrdenarPorNombre);
            this.Controls.Add(this.btnVerBiblioteca);
            this.Controls.Add(this.lblSeleccionListas);
            this.Controls.Add(this.lbSeleccionListas);
            this.Controls.Add(this.btnAgregarALista);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlayLists);
            this.Controls.Add(this.txtNewPlaylist);
            this.Controls.Add(this.lblNewPlaylist);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderMenu;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Label lblNewPlaylist;
        private System.Windows.Forms.TextBox txtNewPlaylist;
        private System.Windows.Forms.ListBox lbPlayLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Button btnAgregarALista;
        private System.Windows.Forms.ListBox lbSeleccionListas;
        private System.Windows.Forms.Label lblSeleccionListas;
        private System.Windows.Forms.Button btnVerBiblioteca;
        private System.Windows.Forms.Button btnOrdenarPorNombre;
        private System.Windows.Forms.Button btnOrdenarPorDuración;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Panel panel1;
    }
}

