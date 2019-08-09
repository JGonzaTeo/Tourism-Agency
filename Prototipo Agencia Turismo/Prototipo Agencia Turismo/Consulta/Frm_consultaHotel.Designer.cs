namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaHotel));
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Dgv_consultaHotel = new System.Windows.Forms.DataGridView();
            this.idHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_consultaHotel = new System.Windows.Forms.TextBox();
            this.Lbl_consultaHotel = new System.Windows.Forms.Label();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_min = new System.Windows.Forms.Button();
            this.Btn_cerr = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_consultaPerfil = new System.Windows.Forms.Button();
            this.Btn_busqueda = new System.Windows.Forms.Button();
            this.Btn_actu = new System.Windows.Forms.Button();
            this.Btn_selec = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaHotel)).BeginInit();
            this.Pnl_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(1110, 916);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(246, 64);
            this.Btn_actualizar.TabIndex = 54;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Dgv_consultaHotel
            // 
            this.Dgv_consultaHotel.AllowUserToAddRows = false;
            this.Dgv_consultaHotel.AllowUserToDeleteRows = false;
            this.Dgv_consultaHotel.AllowUserToResizeColumns = false;
            this.Dgv_consultaHotel.AllowUserToResizeRows = false;
            this.Dgv_consultaHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHotel,
            this.nombre,
            this.direccion,
            this.telefono,
            this.correo});
            this.Dgv_consultaHotel.Location = new System.Drawing.Point(24, 126);
            this.Dgv_consultaHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_consultaHotel.MultiSelect = false;
            this.Dgv_consultaHotel.Name = "Dgv_consultaHotel";
            this.Dgv_consultaHotel.ReadOnly = true;
            this.Dgv_consultaHotel.RowHeadersVisible = false;
            this.Dgv_consultaHotel.RowTemplate.Height = 24;
            this.Dgv_consultaHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaHotel.Size = new System.Drawing.Size(1116, 429);
            this.Dgv_consultaHotel.TabIndex = 52;
            // 
            // idHotel
            // 
            this.idHotel.HeaderText = "ID";
            this.idHotel.Name = "idHotel";
            this.idHotel.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // Txt_consultaHotel
            // 
            this.Txt_consultaHotel.Location = new System.Drawing.Point(138, 79);
            this.Txt_consultaHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_consultaHotel.Name = "Txt_consultaHotel";
            this.Txt_consultaHotel.Size = new System.Drawing.Size(787, 30);
            this.Txt_consultaHotel.TabIndex = 48;
            // 
            // Lbl_consultaHotel
            // 
            this.Lbl_consultaHotel.AutoSize = true;
            this.Lbl_consultaHotel.Location = new System.Drawing.Point(63, 85);
            this.Lbl_consultaHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_consultaHotel.Name = "Lbl_consultaHotel";
            this.Lbl_consultaHotel.Size = new System.Drawing.Size(62, 22);
            this.Lbl_consultaHotel.TabIndex = 47;
            this.Lbl_consultaHotel.Text = "Hotel:";
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_seleccionar.FlatAppearance.BorderSize = 3;
            this.Btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(1410, 916);
            this.Btn_seleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(246, 64);
            this.Btn_seleccionar.TabIndex = 53;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_ayuda);
            this.Pnl_principal.Controls.Add(this.Btn_min);
            this.Pnl_principal.Controls.Add(this.Btn_cerr);
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(8);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 55;
            // 
            // Btn_min
            // 
            this.Btn_min.FlatAppearance.BorderSize = 0;
            this.Btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_min.Image = ((System.Drawing.Image)(resources.GetObject("Btn_min.Image")));
            this.Btn_min.Location = new System.Drawing.Point(1042, 1);
            this.Btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_min.Name = "Btn_min";
            this.Btn_min.Size = new System.Drawing.Size(44, 40);
            this.Btn_min.TabIndex = 13;
            this.Btn_min.UseVisualStyleBackColor = true;
            this.Btn_min.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cerr
            // 
            this.Btn_cerr.FlatAppearance.BorderSize = 0;
            this.Btn_cerr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerr.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerr.Image")));
            this.Btn_cerr.Location = new System.Drawing.Point(1122, 1);
            this.Btn_cerr.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerr.Name = "Btn_cerr";
            this.Btn_cerr.Size = new System.Drawing.Size(44, 40);
            this.Btn_cerr.TabIndex = 12;
            this.Btn_cerr.UseVisualStyleBackColor = true;
            this.Btn_cerr.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1530, 1);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(66, 74);
            this.Btn_minimizar.TabIndex = 11;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1650, 1);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(66, 74);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(63, 12);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(175, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE HOTEL";
            // 
            // Btn_consultaPerfil
            // 
            this.Btn_consultaPerfil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultaPerfil.FlatAppearance.BorderSize = 3;
            this.Btn_consultaPerfil.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaPerfil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaPerfil.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaPerfil.Image")));
            this.Btn_consultaPerfil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultaPerfil.Location = new System.Drawing.Point(1609, 76);
            this.Btn_consultaPerfil.Name = "Btn_consultaPerfil";
            this.Btn_consultaPerfil.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaPerfil.TabIndex = 56;
            this.Btn_consultaPerfil.Text = "Consultar";
            this.Btn_consultaPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaPerfil.UseVisualStyleBackColor = false;
            // 
            // Btn_busqueda
            // 
            this.Btn_busqueda.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_busqueda.FlatAppearance.BorderSize = 3;
            this.Btn_busqueda.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_busqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_busqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_busqueda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_busqueda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_busqueda.Image")));
            this.Btn_busqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_busqueda.Location = new System.Drawing.Point(1063, 69);
            this.Btn_busqueda.Name = "Btn_busqueda";
            this.Btn_busqueda.Size = new System.Drawing.Size(40, 40);
            this.Btn_busqueda.TabIndex = 57;
            this.Btn_busqueda.Text = "Consultar";
            this.Btn_busqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_busqueda.UseVisualStyleBackColor = false;
            this.Btn_busqueda.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_actu
            // 
            this.Btn_actu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actu.FlatAppearance.BorderSize = 3;
            this.Btn_actu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actu.Location = new System.Drawing.Point(776, 575);
            this.Btn_actu.Name = "Btn_actu";
            this.Btn_actu.Size = new System.Drawing.Size(164, 41);
            this.Btn_actu.TabIndex = 59;
            this.Btn_actu.Text = "Actualizar";
            this.Btn_actu.UseVisualStyleBackColor = true;
            this.Btn_actu.Click += new System.EventHandler(this.Btn_actu_Click);
            // 
            // Btn_selec
            // 
            this.Btn_selec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_selec.FlatAppearance.BorderSize = 3;
            this.Btn_selec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_selec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_selec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_selec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_selec.Location = new System.Drawing.Point(976, 575);
            this.Btn_selec.Name = "Btn_selec";
            this.Btn_selec.Size = new System.Drawing.Size(164, 41);
            this.Btn_selec.TabIndex = 58;
            this.Btn_selec.Text = "Seleccionar";
            this.Btn_selec.UseVisualStyleBackColor = true;
            this.Btn_selec.Click += new System.EventHandler(this.Btn_selec_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(945, 1);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(35, 35);
            this.Btn_ayuda.TabIndex = 115;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Frm_consultaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actu);
            this.Controls.Add(this.Btn_selec);
            this.Controls.Add(this.Btn_busqueda);
            this.Controls.Add(this.Btn_consultaPerfil);
            this.Controls.Add(this.Pnl_principal);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgv_consultaHotel);
            this.Controls.Add(this.Txt_consultaHotel);
            this.Controls.Add(this.Lbl_consultaHotel);
            this.Controls.Add(this.Btn_seleccionar);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_consultaHotel";
            this.Text = "Frm_consultaHotel";
            this.Load += new System.EventHandler(this.Frm_consultaHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaHotel)).EndInit();
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.TextBox Txt_consultaHotel;
        private System.Windows.Forms.Label Lbl_consultaHotel;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_consultaPerfil;
        private System.Windows.Forms.Button Btn_min;
        private System.Windows.Forms.Button Btn_cerr;
        private System.Windows.Forms.Button Btn_busqueda;
        private System.Windows.Forms.Button Btn_actu;
        private System.Windows.Forms.Button Btn_selec;
        public System.Windows.Forms.DataGridView Dgv_consultaHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}