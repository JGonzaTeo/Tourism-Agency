namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaReservacion));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_consultaPerfil = new System.Windows.Forms.Button();
            this.Txt_consultaReservacion = new System.Windows.Forms.TextBox();
            this.Lbl_consultaUsuario = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Dgv_consultaReservacion = new System.Windows.Forms.DataGridView();
            this.idReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPiloto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaReservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(7);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 50);
            this.Pnl_principal.TabIndex = 7;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1003, -1);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(59, 63);
            this.Btn_minimizar.TabIndex = 11;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1094, -1);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(59, 63);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(40, 21);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(198, 17);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE RESERVACION";
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
            this.Btn_consultaPerfil.Location = new System.Drawing.Point(1071, 71);
            this.Btn_consultaPerfil.Name = "Btn_consultaPerfil";
            this.Btn_consultaPerfil.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaPerfil.TabIndex = 45;
            this.Btn_consultaPerfil.Text = "Consultar";
            this.Btn_consultaPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaPerfil.UseVisualStyleBackColor = false;
            this.Btn_consultaPerfil.Click += new System.EventHandler(this.Btn_consultaPerfil_Click);
            // 
            // Txt_consultaReservacion
            // 
            this.Txt_consultaReservacion.Location = new System.Drawing.Point(155, 78);
            this.Txt_consultaReservacion.Name = "Txt_consultaReservacion";
            this.Txt_consultaReservacion.Size = new System.Drawing.Size(899, 24);
            this.Txt_consultaReservacion.TabIndex = 44;
            // 
            // Lbl_consultaUsuario
            // 
            this.Lbl_consultaUsuario.AutoSize = true;
            this.Lbl_consultaUsuario.Location = new System.Drawing.Point(40, 83);
            this.Lbl_consultaUsuario.Name = "Lbl_consultaUsuario";
            this.Lbl_consultaUsuario.Size = new System.Drawing.Size(109, 19);
            this.Lbl_consultaUsuario.TabIndex = 43;
            this.Lbl_consultaUsuario.Text = "ID reservacion:";
            this.Lbl_consultaUsuario.Click += new System.EventHandler(this.Lbl_consultaUsuario_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(761, 577);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 48;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_seleccionar.FlatAppearance.BorderSize = 3;
            this.Btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(961, 577);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(164, 41);
            this.Btn_seleccionar.TabIndex = 47;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Dgv_consultaReservacion
            // 
            this.Dgv_consultaReservacion.AllowUserToAddRows = false;
            this.Dgv_consultaReservacion.AllowUserToDeleteRows = false;
            this.Dgv_consultaReservacion.AllowUserToResizeColumns = false;
            this.Dgv_consultaReservacion.AllowUserToResizeRows = false;
            this.Dgv_consultaReservacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaReservacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservacion,
            this.idCotizacion,
            this.idPago,
            this.idAsignacion,
            this.idTransporte,
            this.idPiloto,
            this.fechaSalida,
            this.fechaEntrada});
            this.Dgv_consultaReservacion.Location = new System.Drawing.Point(37, 131);
            this.Dgv_consultaReservacion.Name = "Dgv_consultaReservacion";
            this.Dgv_consultaReservacion.RowHeadersVisible = false;
            this.Dgv_consultaReservacion.RowTemplate.Height = 24;
            this.Dgv_consultaReservacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaReservacion.Size = new System.Drawing.Size(1098, 432);
            this.Dgv_consultaReservacion.TabIndex = 46;
            // 
            // idReservacion
            // 
            this.idReservacion.HeaderText = "ID Reservacion";
            this.idReservacion.Name = "idReservacion";
            // 
            // idCotizacion
            // 
            this.idCotizacion.HeaderText = "ID Cotizacion";
            this.idCotizacion.Name = "idCotizacion";
            // 
            // idPago
            // 
            this.idPago.HeaderText = "ID Tipo Pago";
            this.idPago.Name = "idPago";
            // 
            // idAsignacion
            // 
            this.idAsignacion.HeaderText = "ID Asignacion Transporte";
            this.idAsignacion.Name = "idAsignacion";
            // 
            // idTransporte
            // 
            this.idTransporte.HeaderText = "ID Tipo Transporte";
            this.idTransporte.Name = "idTransporte";
            // 
            // idPiloto
            // 
            this.idPiloto.HeaderText = "ID Piloto";
            this.idPiloto.Name = "idPiloto";
            // 
            // fechaSalida
            // 
            this.fechaSalida.HeaderText = "Fecha Salida";
            this.fechaSalida.Name = "fechaSalida";
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.HeaderText = "Fecha Entrada";
            this.fechaEntrada.Name = "fechaEntrada";
            // 
            // Frm_consultaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaReservacion);
            this.Controls.Add(this.Btn_consultaPerfil);
            this.Controls.Add(this.Txt_consultaReservacion);
            this.Controls.Add(this.Lbl_consultaUsuario);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_consultaReservacion";
            this.Text = "Frm_consultaReservacion";
            this.Load += new System.EventHandler(this.Frm_consultaReservacion_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaReservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_consultaPerfil;
        private System.Windows.Forms.TextBox Txt_consultaReservacion;
        private System.Windows.Forms.Label Lbl_consultaUsuario;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_seleccionar;
        public System.Windows.Forms.DataGridView Dgv_consultaReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPiloto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrada;
    }
}