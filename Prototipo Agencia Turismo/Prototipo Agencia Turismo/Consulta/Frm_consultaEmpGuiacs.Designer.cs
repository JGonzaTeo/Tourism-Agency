﻿namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaEmpGuiacs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaEmpGuiacs));
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Dgv_consultaEmpleadoguia = new System.Windows.Forms.DataGridView();
            this.Codigo_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_consulta = new System.Windows.Forms.Button();
            this.Txt_consultaGuiaturistico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaEmpleadoguia)).BeginInit();
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
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(722, 223);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 68;
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
            this.Btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(922, 223);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(164, 41);
            this.Btn_seleccionar.TabIndex = 67;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Dgv_consultaEmpleadoguia
            // 
            this.Dgv_consultaEmpleadoguia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaEmpleadoguia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_emp,
            this.Cod_guia,
            this.Fec_inicio,
            this.Fec_fin});
            this.Dgv_consultaEmpleadoguia.Location = new System.Drawing.Point(86, 115);
            this.Dgv_consultaEmpleadoguia.Name = "Dgv_consultaEmpleadoguia";
            this.Dgv_consultaEmpleadoguia.RowTemplate.Height = 24;
            this.Dgv_consultaEmpleadoguia.Size = new System.Drawing.Size(593, 405);
            this.Dgv_consultaEmpleadoguia.TabIndex = 66;
            // 
            // Codigo_emp
            // 
            this.Codigo_emp.HeaderText = "Codigo Empleado";
            this.Codigo_emp.Name = "Codigo_emp";
            this.Codigo_emp.ReadOnly = true;
            // 
            // Cod_guia
            // 
            this.Cod_guia.HeaderText = "Codigo Guia";
            this.Cod_guia.Name = "Cod_guia";
            this.Cod_guia.ReadOnly = true;
            // 
            // Fec_inicio
            // 
            this.Fec_inicio.HeaderText = "Fecha Inicio";
            this.Fec_inicio.Name = "Fec_inicio";
            this.Fec_inicio.ReadOnly = true;
            // 
            // Fec_fin
            // 
            this.Fec_fin.HeaderText = "Fecha_fin";
            this.Fec_fin.Name = "Fec_fin";
            this.Fec_fin.ReadOnly = true;
            // 
            // Btn_consulta
            // 
            this.Btn_consulta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consulta.FlatAppearance.BorderSize = 3;
            this.Btn_consulta.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consulta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consulta.Image")));
            this.Btn_consulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consulta.Location = new System.Drawing.Point(1064, 63);
            this.Btn_consulta.Name = "Btn_consulta";
            this.Btn_consulta.Size = new System.Drawing.Size(40, 40);
            this.Btn_consulta.TabIndex = 65;
            this.Btn_consulta.Text = "Consultar";
            this.Btn_consulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consulta.UseVisualStyleBackColor = false;
            this.Btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // Txt_consultaGuiaturistico
            // 
            this.Txt_consultaGuiaturistico.Location = new System.Drawing.Point(100, 75);
            this.Txt_consultaGuiaturistico.Name = "Txt_consultaGuiaturistico";
            this.Txt_consultaGuiaturistico.Size = new System.Drawing.Size(934, 22);
            this.Txt_consultaGuiaturistico.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-124, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nombre:";
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(5);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 51);
            this.Pnl_principal.TabIndex = 62;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1020, 1);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(44, 48);
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
            this.Btn_cerrar.Size = new System.Drawing.Size(44, 48);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(42, 21);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(335, 20);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Consulta Empleados  asignado a guias";
            // 
            // Frm_consultaEmpGuiacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaEmpleadoguia);
            this.Controls.Add(this.Btn_consulta);
            this.Controls.Add(this.Txt_consultaGuiaturistico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_consultaEmpGuiacs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaEmpGuiacs";
            this.Load += new System.EventHandler(this.Frm_consultaEmpGuiacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaEmpleadoguia)).EndInit();
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_seleccionar;
        public System.Windows.Forms.DataGridView Dgv_consultaEmpleadoguia;
        private System.Windows.Forms.Button Btn_consulta;
        private System.Windows.Forms.TextBox Txt_consultaGuiaturistico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_fin;
    }
}