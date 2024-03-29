﻿namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaLugarTuristico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaLugarTuristico));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_consultaLugarT = new System.Windows.Forms.Label();
            this.Txt_consultaLugarT = new System.Windows.Forms.TextBox();
            this.Btn_consultaLugarT = new System.Windows.Forms.Button();
            this.Dgv_consultaLugarT = new System.Windows.Forms.DataGridView();
            this.idLugarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoLugarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaLugarT)).BeginInit();
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
            this.Lbl_titulo.Size = new System.Drawing.Size(265, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE LUGAR TURÍSTICO";
            // 
            // Lbl_consultaLugarT
            // 
            this.Lbl_consultaLugarT.AutoSize = true;
            this.Lbl_consultaLugarT.Location = new System.Drawing.Point(2, 88);
            this.Lbl_consultaLugarT.Name = "Lbl_consultaLugarT";
            this.Lbl_consultaLugarT.Size = new System.Drawing.Size(130, 21);
            this.Lbl_consultaLugarT.TabIndex = 7;
            this.Lbl_consultaLugarT.Text = "Lugar turístico:";
            // 
            // Txt_consultaLugarT
            // 
            this.Txt_consultaLugarT.Location = new System.Drawing.Point(131, 85);
            this.Txt_consultaLugarT.Name = "Txt_consultaLugarT";
            this.Txt_consultaLugarT.Size = new System.Drawing.Size(934, 28);
            this.Txt_consultaLugarT.TabIndex = 8;
            // 
            // Btn_consultaLugarT
            // 
            this.Btn_consultaLugarT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultaLugarT.FlatAppearance.BorderSize = 3;
            this.Btn_consultaLugarT.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultaLugarT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultaLugarT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaLugarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaLugarT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaLugarT.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaLugarT.Image")));
            this.Btn_consultaLugarT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultaLugarT.Location = new System.Drawing.Point(1095, 73);
            this.Btn_consultaLugarT.Name = "Btn_consultaLugarT";
            this.Btn_consultaLugarT.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaLugarT.TabIndex = 42;
            this.Btn_consultaLugarT.Text = "Consultar";
            this.Btn_consultaLugarT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaLugarT.UseVisualStyleBackColor = false;
            this.Btn_consultaLugarT.Click += new System.EventHandler(this.Btn_consultaLugarT_Click);
            // 
            // Dgv_consultaLugarT
            // 
            this.Dgv_consultaLugarT.AllowUserToAddRows = false;
            this.Dgv_consultaLugarT.AllowUserToDeleteRows = false;
            this.Dgv_consultaLugarT.AllowUserToResizeColumns = false;
            this.Dgv_consultaLugarT.AllowUserToResizeRows = false;
            this.Dgv_consultaLugarT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaLugarT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaLugarT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLugarT,
            this.nombre,
            this.descripcion,
            this.departamentoLugarT,
            this.precio});
            this.Dgv_consultaLugarT.Location = new System.Drawing.Point(47, 156);
            this.Dgv_consultaLugarT.Name = "Dgv_consultaLugarT";
            this.Dgv_consultaLugarT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Dgv_consultaLugarT.RowHeadersVisible = false;
            this.Dgv_consultaLugarT.RowTemplate.Height = 24;
            this.Dgv_consultaLugarT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaLugarT.Size = new System.Drawing.Size(1098, 405);
            this.Dgv_consultaLugarT.TabIndex = 43;
            // 
            // idLugarT
            // 
            this.idLugarT.HeaderText = "ID lugar turístico";
            this.idLugarT.Name = "idLugarT";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre ";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // departamentoLugarT
            // 
            this.departamentoLugarT.HeaderText = "Departamento";
            this.departamentoLugarT.Name = "departamentoLugarT";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
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
            this.Btn_ayuda.TabIndex = 114;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Frm_consultaLugarTuristico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaLugarT);
            this.Controls.Add(this.Btn_consultaLugarT);
            this.Controls.Add(this.Txt_consultaLugarT);
            this.Controls.Add(this.Lbl_consultaLugarT);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_consultaLugarTuristico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaLugarTuristico";
            this.Load += new System.EventHandler(this.Frm_consultaLugarTuristico_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaLugarT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_consultaLugarT;
        private System.Windows.Forms.TextBox Txt_consultaLugarT;
        private System.Windows.Forms.Button Btn_consultaLugarT;
        public System.Windows.Forms.DataGridView Dgv_consultaLugarT;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLugarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoLugarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}