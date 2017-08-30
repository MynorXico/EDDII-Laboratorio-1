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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Canción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(27, 341);
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
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Canción,
            this.Length});
            this.dgvSongs.Location = new System.Drawing.Point(506, 27);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.Size = new System.Drawing.Size(578, 308);
            this.dgvSongs.TabIndex = 2;
            this.dgvSongs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellContentDoubleClick);
            this.dgvSongs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellDoubleClick);
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(6, 32);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(190, 23);
            this.btnCreatePlaylist.TabIndex = 6;
            this.btnCreatePlaylist.Text = "Nueva lista de reproducción";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // lblNewPlaylist
            // 
            this.lblNewPlaylist.AutoSize = true;
            this.lblNewPlaylist.Location = new System.Drawing.Point(15, 69);
            this.lblNewPlaylist.Name = "lblNewPlaylist";
            this.lblNewPlaylist.Size = new System.Drawing.Size(91, 13);
            this.lblNewPlaylist.TabIndex = 4;
            this.lblNewPlaylist.Text = "Nombre de la lista";
            this.lblNewPlaylist.Visible = false;
            // 
            // txtNewPlaylist
            // 
            this.txtNewPlaylist.Location = new System.Drawing.Point(9, 85);
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
            this.lbPlayLists.Size = new System.Drawing.Size(201, 277);
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
            this.btnVerLista.Location = new System.Drawing.Point(6, 61);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(190, 23);
            this.btnVerLista.TabIndex = 8;
            this.btnVerLista.Text = "Ver canciones en lista";
            this.btnVerLista.UseVisualStyleBackColor = true;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // btnAgregarALista
            // 
            this.btnAgregarALista.Location = new System.Drawing.Point(1135, 37);
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
            this.lbSeleccionListas.Location = new System.Drawing.Point(1153, 79);
            this.lbSeleccionListas.Name = "lbSeleccionListas";
            this.lbSeleccionListas.Size = new System.Drawing.Size(120, 95);
            this.lbSeleccionListas.TabIndex = 10;
            this.lbSeleccionListas.Visible = false;
            // 
            // lblSeleccionListas
            // 
            this.lblSeleccionListas.AutoSize = true;
            this.lblSeleccionListas.Location = new System.Drawing.Point(1150, 63);
            this.lblSeleccionListas.Name = "lblSeleccionListas";
            this.lblSeleccionListas.Size = new System.Drawing.Size(164, 13);
            this.lblSeleccionListas.TabIndex = 11;
            this.lblSeleccionListas.Text = "Seleccionar lista de reproducción";
            this.lblSeleccionListas.Visible = false;
            // 
            // btnVerBiblioteca
            // 
            this.btnVerBiblioteca.Location = new System.Drawing.Point(6, 90);
            this.btnVerBiblioteca.Name = "btnVerBiblioteca";
            this.btnVerBiblioteca.Size = new System.Drawing.Size(190, 23);
            this.btnVerBiblioteca.TabIndex = 12;
            this.btnVerBiblioteca.Text = "Ver canciones en bibliioteca";
            this.btnVerBiblioteca.UseVisualStyleBackColor = true;
            this.btnVerBiblioteca.Click += new System.EventHandler(this.btnVerBiblioteca_Click);
            // 
            // btnOrdenarPorNombre
            // 
            this.btnOrdenarPorNombre.Location = new System.Drawing.Point(6, 119);
            this.btnOrdenarPorNombre.Name = "btnOrdenarPorNombre";
            this.btnOrdenarPorNombre.Size = new System.Drawing.Size(190, 23);
            this.btnOrdenarPorNombre.TabIndex = 13;
            this.btnOrdenarPorNombre.Text = "Ordenar por nombre";
            this.btnOrdenarPorNombre.UseVisualStyleBackColor = true;
            this.btnOrdenarPorNombre.Click += new System.EventHandler(this.btnOrdenarPorNombre_Click);
            // 
            // btnOrdenarPorDuración
            // 
            this.btnOrdenarPorDuración.Location = new System.Drawing.Point(6, 148);
            this.btnOrdenarPorDuración.Name = "btnOrdenarPorDuración";
            this.btnOrdenarPorDuración.Size = new System.Drawing.Size(190, 23);
            this.btnOrdenarPorDuración.TabIndex = 14;
            this.btnOrdenarPorDuración.Text = "Ordenar por duración";
            this.btnOrdenarPorDuración.UseVisualStyleBackColor = true;
            this.btnOrdenarPorDuración.Click += new System.EventHandler(this.btnOrdenarPorDuración_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(6, 45);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(152, 20);
            this.txtBusqueda.TabIndex = 16;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(32, 71);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 17;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerBiblioteca);
            this.groupBox1.Controls.Add(this.btnCreatePlaylist);
            this.groupBox1.Controls.Add(this.btnOrdenarPorDuración);
            this.groupBox1.Controls.Add(this.lblNewPlaylist);
            this.groupBox1.Controls.Add(this.btnOrdenarPorNombre);
            this.groupBox1.Controls.Add(this.txtNewPlaylist);
            this.groupBox1.Controls.Add(this.btnVerLista);
            this.groupBox1.Location = new System.Drawing.Point(243, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 183);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones con Playlists";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBusqueda);
            this.groupBox2.Controls.Add(this.btnBusqueda);
            this.groupBox2.Location = new System.Drawing.Point(247, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // Canción
            // 
            this.Canción.FillWeight = 500F;
            this.Canción.HeaderText = "Name";
            this.Canción.Name = "Canción";
            this.Canción.ReadOnly = true;
            this.Canción.Width = 500;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Length.HeaderText = "Duración (s)";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSeleccionListas);
            this.Controls.Add(this.lbSeleccionListas);
            this.Controls.Add(this.btnAgregarALista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlayLists);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderMenu;
        private System.Windows.Forms.DataGridView dgvSongs;
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
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
    }
}

