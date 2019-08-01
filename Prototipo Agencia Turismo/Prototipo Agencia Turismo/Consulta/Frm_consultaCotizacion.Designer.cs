namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaCotizacion));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_min = new System.Windows.Forms.Button();
            this.Btn_cerr = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Txt_consultaMenu = new System.Windows.Forms.TextBox();
            this.Lbl_consultaMenu = new System.Windows.Forms.Label();
            this.Btn_actu = new System.Windows.Forms.Button();
            this.Btn_selec = new System.Windows.Forms.Button();
            this.Dgv_consultaCotizacion = new System.Windows.Forms.DataGridView();
            this.idCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCotizacion)).BeginInit();
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
            this.Pnl_principal.TabIndex = 57;
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
            this.Lbl_titulo.Size = new System.Drawing.Size(191, 17);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE COTIZACION";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(1086, 72);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultar.TabIndex = 64;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Txt_consultaMenu
            // 
            this.Txt_consultaMenu.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Txt_consultaMenu.Location = new System.Drawing.Point(157, 76);
            this.Txt_consultaMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_consultaMenu.Name = "Txt_consultaMenu";
            this.Txt_consultaMenu.Size = new System.Drawing.Size(787, 24);
            this.Txt_consultaMenu.TabIndex = 63;
            this.Txt_consultaMenu.TextChanged += new System.EventHandler(this.Txt_consultaMenu_TextChanged);
            // 
            // Lbl_consultaMenu
            // 
            this.Lbl_consultaMenu.AutoSize = true;
            this.Lbl_consultaMenu.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_consultaMenu.Location = new System.Drawing.Point(62, 79);
            this.Lbl_consultaMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_consultaMenu.Name = "Lbl_consultaMenu";
            this.Lbl_consultaMenu.Size = new System.Drawing.Size(87, 19);
            this.Lbl_consultaMenu.TabIndex = 62;
            this.Lbl_consultaMenu.Text = "Cotizacion:";
            this.Lbl_consultaMenu.Click += new System.EventHandler(this.Lbl_consultaMenu_Click);
            // 
            // Btn_actu
            // 
            this.Btn_actu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actu.FlatAppearance.BorderSize = 3;
            this.Btn_actu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actu.Location = new System.Drawing.Point(799, 587);
            this.Btn_actu.Name = "Btn_actu";
            this.Btn_actu.Size = new System.Drawing.Size(164, 41);
            this.Btn_actu.TabIndex = 67;
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
            this.Btn_selec.Location = new System.Drawing.Point(999, 587);
            this.Btn_selec.Name = "Btn_selec";
            this.Btn_selec.Size = new System.Drawing.Size(164, 41);
            this.Btn_selec.TabIndex = 66;
            this.Btn_selec.Text = "Seleccionar";
            this.Btn_selec.UseVisualStyleBackColor = true;
            this.Btn_selec.Click += new System.EventHandler(this.Btn_selec_Click_1);
            // 
            // Dgv_consultaCotizacion
            // 
            this.Dgv_consultaCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCotizacion,
            this.nomCliente,
            this.cantidad,
            this.total});
            this.Dgv_consultaCotizacion.Location = new System.Drawing.Point(38, 129);
            this.Dgv_consultaCotizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_consultaCotizacion.MultiSelect = false;
            this.Dgv_consultaCotizacion.Name = "Dgv_consultaCotizacion";
            this.Dgv_consultaCotizacion.ReadOnly = true;
            this.Dgv_consultaCotizacion.RowTemplate.Height = 24;
            this.Dgv_consultaCotizacion.Size = new System.Drawing.Size(1116, 429);
            this.Dgv_consultaCotizacion.TabIndex = 65;
            // 
            // idCotizacion
            // 
            this.idCotizacion.HeaderText = "ID Cotizacion";
            this.idCotizacion.Name = "idCotizacion";
            this.idCotizacion.ReadOnly = true;
            // 
            // nomCliente
            // 
            this.nomCliente.HeaderText = "Nombre Cliente";
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad Pasajeros";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // Frm_consultaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actu);
            this.Controls.Add(this.Btn_selec);
            this.Controls.Add(this.Dgv_consultaCotizacion);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Txt_consultaMenu);
            this.Controls.Add(this.Lbl_consultaMenu);
            this.Controls.Add(this.Pnl_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_consultaCotizacion";
            this.Text = "Frm_consultaCotizacion";
            this.Load += new System.EventHandler(this.Frm_consultaCotizacion_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCotizacion)).EndInit();
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
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.TextBox Txt_consultaMenu;
        private System.Windows.Forms.Label Lbl_consultaMenu;
        private System.Windows.Forms.Button Btn_actu;
        private System.Windows.Forms.Button Btn_selec;
        public System.Windows.Forms.DataGridView Dgv_consultaCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}