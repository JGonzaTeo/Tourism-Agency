namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaHabitacion));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_min = new System.Windows.Forms.Button();
            this.Btn_cerr = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_busqueda = new System.Windows.Forms.Button();
            this.Txt_consultaHabitacion = new System.Windows.Forms.TextBox();
            this.Lbl_consultaHotel = new System.Windows.Forms.Label();
            this.Dgv_consultaHabitacion = new System.Windows.Forms.DataGridView();
            this.idHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_actu = new System.Windows.Forms.Button();
            this.Btn_selec = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_min);
            this.Pnl_principal.Controls.Add(this.Btn_cerr);
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(8);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 63);
            this.Pnl_principal.TabIndex = 56;
            // 
            // Btn_min
            // 
            this.Btn_min.FlatAppearance.BorderSize = 0;
            this.Btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_min.Image = ((System.Drawing.Image)(resources.GetObject("Btn_min.Image")));
            this.Btn_min.Location = new System.Drawing.Point(1042, 9);
            this.Btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_min.Name = "Btn_min";
            this.Btn_min.Size = new System.Drawing.Size(44, 48);
            this.Btn_min.TabIndex = 13;
            this.Btn_min.UseVisualStyleBackColor = true;
            this.Btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // Btn_cerr
            // 
            this.Btn_cerr.FlatAppearance.BorderSize = 0;
            this.Btn_cerr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerr.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerr.Image")));
            this.Btn_cerr.Location = new System.Drawing.Point(1122, 9);
            this.Btn_cerr.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerr.Name = "Btn_cerr";
            this.Btn_cerr.Size = new System.Drawing.Size(44, 48);
            this.Btn_cerr.TabIndex = 12;
            this.Btn_cerr.UseVisualStyleBackColor = true;
            this.Btn_cerr.Click += new System.EventHandler(this.Btn_cerr_Click);
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
            this.Lbl_titulo.Location = new System.Drawing.Point(63, 32);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(189, 17);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE HABITACION";
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
            this.Btn_busqueda.Location = new System.Drawing.Point(1082, 74);
            this.Btn_busqueda.Name = "Btn_busqueda";
            this.Btn_busqueda.Size = new System.Drawing.Size(40, 40);
            this.Btn_busqueda.TabIndex = 60;
            this.Btn_busqueda.Text = "Consultar";
            this.Btn_busqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_busqueda.UseVisualStyleBackColor = false;
            this.Btn_busqueda.Click += new System.EventHandler(this.Btn_busqueda_Click);
            // 
            // Txt_consultaHabitacion
            // 
            this.Txt_consultaHabitacion.Location = new System.Drawing.Point(164, 77);
            this.Txt_consultaHabitacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_consultaHabitacion.Name = "Txt_consultaHabitacion";
            this.Txt_consultaHabitacion.Size = new System.Drawing.Size(787, 26);
            this.Txt_consultaHabitacion.TabIndex = 59;
            // 
            // Lbl_consultaHotel
            // 
            this.Lbl_consultaHotel.AutoSize = true;
            this.Lbl_consultaHotel.Location = new System.Drawing.Point(63, 80);
            this.Lbl_consultaHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_consultaHotel.Name = "Lbl_consultaHotel";
            this.Lbl_consultaHotel.Size = new System.Drawing.Size(93, 20);
            this.Lbl_consultaHotel.TabIndex = 58;
            this.Lbl_consultaHotel.Text = "Habitacion:";
            // 
            // Dgv_consultaHabitacion
            // 
            this.Dgv_consultaHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaHabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHabitacion,
            this.idHotel,
            this.nombre,
            this.capacidad,
            this.costo});
            this.Dgv_consultaHabitacion.Location = new System.Drawing.Point(51, 137);
            this.Dgv_consultaHabitacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_consultaHabitacion.MultiSelect = false;
            this.Dgv_consultaHabitacion.Name = "Dgv_consultaHabitacion";
            this.Dgv_consultaHabitacion.ReadOnly = true;
            this.Dgv_consultaHabitacion.RowTemplate.Height = 24;
            this.Dgv_consultaHabitacion.Size = new System.Drawing.Size(1116, 429);
            this.Dgv_consultaHabitacion.TabIndex = 61;
            // 
            // idHabitacion
            // 
            this.idHabitacion.HeaderText = "ID Habitacion";
            this.idHabitacion.Name = "idHabitacion";
            this.idHabitacion.ReadOnly = true;
            // 
            // idHotel
            // 
            this.idHotel.HeaderText = "ID Hotel";
            this.idHotel.Name = "idHotel";
            this.idHotel.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // capacidad
            // 
            this.capacidad.HeaderText = "Capacidad";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // Btn_actu
            // 
            this.Btn_actu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actu.FlatAppearance.BorderSize = 3;
            this.Btn_actu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actu.Location = new System.Drawing.Point(802, 587);
            this.Btn_actu.Name = "Btn_actu";
            this.Btn_actu.Size = new System.Drawing.Size(164, 41);
            this.Btn_actu.TabIndex = 63;
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
            this.Btn_selec.Location = new System.Drawing.Point(1002, 587);
            this.Btn_selec.Name = "Btn_selec";
            this.Btn_selec.Size = new System.Drawing.Size(164, 41);
            this.Btn_selec.TabIndex = 62;
            this.Btn_selec.Text = "Seleccionar";
            this.Btn_selec.UseVisualStyleBackColor = true;
            this.Btn_selec.Click += new System.EventHandler(this.Btn_selec_Click);
            // 
            // Frm_consultaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actu);
            this.Controls.Add(this.Btn_selec);
            this.Controls.Add(this.Dgv_consultaHabitacion);
            this.Controls.Add(this.Btn_busqueda);
            this.Controls.Add(this.Txt_consultaHabitacion);
            this.Controls.Add(this.Lbl_consultaHotel);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_consultaHabitacion";
            this.Text = "Frm_consultaHabitacion";
            this.Load += new System.EventHandler(this.Frm_consultaHabitacion_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_min;
        private System.Windows.Forms.Button Btn_cerr;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_busqueda;
        private System.Windows.Forms.TextBox Txt_consultaHabitacion;
        private System.Windows.Forms.Label Lbl_consultaHotel;
        public System.Windows.Forms.DataGridView Dgv_consultaHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.Button Btn_actu;
        private System.Windows.Forms.Button Btn_selec;
    }
}