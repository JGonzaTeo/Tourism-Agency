namespace Prototipo_Agencia_Turismo
{
    partial class Frm_bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_bitacora));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Dgv_tablaBitacora = new System.Windows.Forms.DataGridView();
            this.idBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.Txt_consultaUsuario = new System.Windows.Forms.TextBox();
            this.Btn_generarReporte = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_consultaPerfil = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tablaBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_ayuda);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 0;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(945, 2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(35, 35);
            this.Btn_ayuda.TabIndex = 92;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(22, 13);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(102, 20);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "BITÁCORA";
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1020, 3);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(35, 37);
            this.Btn_minimizar.TabIndex = 10;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1100, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(35, 37);
            this.Btn_cerrar.TabIndex = 9;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dgv_tablaBitacora
            // 
            this.Dgv_tablaBitacora.AllowUserToAddRows = false;
            this.Dgv_tablaBitacora.AllowUserToDeleteRows = false;
            this.Dgv_tablaBitacora.AllowUserToResizeColumns = false;
            this.Dgv_tablaBitacora.AllowUserToResizeRows = false;
            this.Dgv_tablaBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_tablaBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_tablaBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBitacora,
            this.operacionBitacora,
            this.usuarioBitacora,
            this.fechaIngreso,
            this.aplicacion,
            this.direccionIp});
            this.Dgv_tablaBitacora.Location = new System.Drawing.Point(26, 155);
            this.Dgv_tablaBitacora.Name = "Dgv_tablaBitacora";
            this.Dgv_tablaBitacora.RowHeadersVisible = false;
            this.Dgv_tablaBitacora.RowTemplate.Height = 24;
            this.Dgv_tablaBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_tablaBitacora.Size = new System.Drawing.Size(1109, 376);
            this.Dgv_tablaBitacora.TabIndex = 1;
            // 
            // idBitacora
            // 
            this.idBitacora.HeaderText = "ID Bitacora";
            this.idBitacora.Name = "idBitacora";
            // 
            // operacionBitacora
            // 
            this.operacionBitacora.HeaderText = "Operación";
            this.operacionBitacora.Name = "operacionBitacora";
            // 
            // usuarioBitacora
            // 
            this.usuarioBitacora.HeaderText = "Usuario";
            this.usuarioBitacora.Name = "usuarioBitacora";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.HeaderText = "Fecha de ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            // 
            // aplicacion
            // 
            this.aplicacion.HeaderText = "Aplicación";
            this.aplicacion.Name = "aplicacion";
            // 
            // direccionIp
            // 
            this.direccionIp.HeaderText = "Dirección IP";
            this.direccionIp.Name = "direccionIp";
            // 
            // Lbl_nombreUsuario
            // 
            this.Lbl_nombreUsuario.AutoSize = true;
            this.Lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreUsuario.Location = new System.Drawing.Point(23, 101);
            this.Lbl_nombreUsuario.Name = "Lbl_nombreUsuario";
            this.Lbl_nombreUsuario.Size = new System.Drawing.Size(156, 20);
            this.Lbl_nombreUsuario.TabIndex = 2;
            this.Lbl_nombreUsuario.Text = "Nombre de usuario:";
            // 
            // Txt_consultaUsuario
            // 
            this.Txt_consultaUsuario.Location = new System.Drawing.Point(221, 99);
            this.Txt_consultaUsuario.Name = "Txt_consultaUsuario";
            this.Txt_consultaUsuario.Size = new System.Drawing.Size(844, 22);
            this.Txt_consultaUsuario.TabIndex = 3;
            // 
            // Btn_generarReporte
            // 
            this.Btn_generarReporte.Enabled = false;
            this.Btn_generarReporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_generarReporte.FlatAppearance.BorderSize = 3;
            this.Btn_generarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_generarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_generarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_generarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generarReporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_generarReporte.Image")));
            this.Btn_generarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_generarReporte.Location = new System.Drawing.Point(946, 575);
            this.Btn_generarReporte.Name = "Btn_generarReporte";
            this.Btn_generarReporte.Size = new System.Drawing.Size(189, 41);
            this.Btn_generarReporte.TabIndex = 4;
            this.Btn_generarReporte.Text = "Generar reporte";
            this.Btn_generarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_generarReporte.UseVisualStyleBackColor = true;
            this.Btn_generarReporte.Click += new System.EventHandler(this.Btn_generarReporte_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(771, 575);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 5;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_consultaPerfil
            // 
            this.Btn_consultaPerfil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultaPerfil.FlatAppearance.BorderSize = 3;
            this.Btn_consultaPerfil.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaPerfil.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaPerfil.Image")));
            this.Btn_consultaPerfil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultaPerfil.Location = new System.Drawing.Point(1095, 82);
            this.Btn_consultaPerfil.Name = "Btn_consultaPerfil";
            this.Btn_consultaPerfil.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaPerfil.TabIndex = 42;
            this.Btn_consultaPerfil.Text = "Consultar";
            this.Btn_consultaPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaPerfil.UseVisualStyleBackColor = false;
            this.Btn_consultaPerfil.Click += new System.EventHandler(this.Btn_consultaPerfil_Click);
            // 
            // Frm_bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_consultaPerfil);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_generarReporte);
            this.Controls.Add(this.Txt_consultaUsuario);
            this.Controls.Add(this.Lbl_nombreUsuario);
            this.Controls.Add(this.Dgv_tablaBitacora);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_bitacora";
            this.Load += new System.EventHandler(this.Frm_bitacora_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_tablaBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridView Dgv_tablaBitacora;
        private System.Windows.Forms.Label Lbl_nombreUsuario;
        private System.Windows.Forms.TextBox Txt_consultaUsuario;
        private System.Windows.Forms.Button Btn_generarReporte;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_consultaPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionIp;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}