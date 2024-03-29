﻿namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaUsuario));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_consultaUsuario = new System.Windows.Forms.Label();
            this.Txt_consultaUsuario = new System.Windows.Forms.TextBox();
            this.Btn_consultaPerfil = new System.Windows.Forms.Button();
            this.Dgv_consultaUsuario = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_ayuda);
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(5);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 6;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1020, 1);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(44, 40);
            this.Btn_minimizar.TabIndex = 11;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1100, 1);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(44, 40);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(42, 12);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(197, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE USUARIO";
            // 
            // Lbl_consultaUsuario
            // 
            this.Lbl_consultaUsuario.AutoSize = true;
            this.Lbl_consultaUsuario.Location = new System.Drawing.Point(43, 88);
            this.Lbl_consultaUsuario.Name = "Lbl_consultaUsuario";
            this.Lbl_consultaUsuario.Size = new System.Drawing.Size(75, 21);
            this.Lbl_consultaUsuario.TabIndex = 7;
            this.Lbl_consultaUsuario.Text = "Usuario:";
            // 
            // Txt_consultaUsuario
            // 
            this.Txt_consultaUsuario.Location = new System.Drawing.Point(131, 85);
            this.Txt_consultaUsuario.Name = "Txt_consultaUsuario";
            this.Txt_consultaUsuario.Size = new System.Drawing.Size(934, 28);
            this.Txt_consultaUsuario.TabIndex = 8;
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
            this.Btn_consultaPerfil.Location = new System.Drawing.Point(1095, 73);
            this.Btn_consultaPerfil.Name = "Btn_consultaPerfil";
            this.Btn_consultaPerfil.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaPerfil.TabIndex = 42;
            this.Btn_consultaPerfil.Text = "Consultar";
            this.Btn_consultaPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaPerfil.UseVisualStyleBackColor = false;
            this.Btn_consultaPerfil.Click += new System.EventHandler(this.Btn_consultaPerfil_Click);
            // 
            // Dgv_consultaUsuario
            // 
            this.Dgv_consultaUsuario.AllowUserToAddRows = false;
            this.Dgv_consultaUsuario.AllowUserToDeleteRows = false;
            this.Dgv_consultaUsuario.AllowUserToResizeColumns = false;
            this.Dgv_consultaUsuario.AllowUserToResizeRows = false;
            this.Dgv_consultaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nombreUsuario,
            this.contrasenaUsuario,
            this.idPerfil,
            this.estado});
            this.Dgv_consultaUsuario.Location = new System.Drawing.Point(47, 156);
            this.Dgv_consultaUsuario.Name = "Dgv_consultaUsuario";
            this.Dgv_consultaUsuario.RowHeadersVisible = false;
            this.Dgv_consultaUsuario.RowTemplate.Height = 24;
            this.Dgv_consultaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaUsuario.Size = new System.Drawing.Size(1098, 405);
            this.Dgv_consultaUsuario.TabIndex = 43;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "ID usuario";
            this.idUsuario.Name = "idUsuario";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.HeaderText = "Nombre";
            this.nombreUsuario.Name = "nombreUsuario";
            // 
            // contrasenaUsuario
            // 
            this.contrasenaUsuario.HeaderText = "Contraseña";
            this.contrasenaUsuario.Name = "contrasenaUsuario";
            // 
            // idPerfil
            // 
            this.idPerfil.HeaderText = "ID perfil";
            this.idPerfil.Name = "idPerfil";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_seleccionar.FlatAppearance.BorderSize = 3;
            this.Btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(971, 575);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(164, 41);
            this.Btn_seleccionar.TabIndex = 44;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(771, 575);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 45;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(945, 1);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(35, 35);
            this.Btn_ayuda.TabIndex = 107;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Frm_consultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaUsuario);
            this.Controls.Add(this.Btn_consultaPerfil);
            this.Controls.Add(this.Txt_consultaUsuario);
            this.Controls.Add(this.Lbl_consultaUsuario);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_consultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaUsuario";
            this.Load += new System.EventHandler(this.Frm_consultaUsuario_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_consultaUsuario;
        private System.Windows.Forms.TextBox Txt_consultaUsuario;
        private System.Windows.Forms.Button Btn_consultaPerfil;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Button Btn_actualizar;
        public System.Windows.Forms.DataGridView Dgv_consultaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}