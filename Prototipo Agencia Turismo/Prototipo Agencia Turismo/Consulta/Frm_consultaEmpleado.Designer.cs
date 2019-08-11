namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaEmpleado));
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Dgv_consultaEmpleados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Auxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_residencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Bancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo_Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_consulta = new System.Windows.Forms.Button();
            this.Txt_consultaEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaEmpleados)).BeginInit();
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
            this.Btn_actualizar.Location = new System.Drawing.Point(746, 461);
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
            this.Btn_seleccionar.Location = new System.Drawing.Point(946, 461);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(164, 41);
            this.Btn_seleccionar.TabIndex = 67;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Dgv_consultaEmpleados
            // 
            this.Dgv_consultaEmpleados.AllowUserToAddRows = false;
            this.Dgv_consultaEmpleados.AllowUserToDeleteRows = false;
            this.Dgv_consultaEmpleados.AllowUserToResizeColumns = false;
            this.Dgv_consultaEmpleados.AllowUserToResizeRows = false;
            this.Dgv_consultaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nombre_empleado,
            this.Valor,
            this.Tipo,
            this.Correo,
            this.Correo_Auxiliar,
            this.Telefono,
            this.telefono_residencial,
            this.Dpi,
            this.Usario,
            this.Cuenta_Bancaria,
            this.Nit,
            this.Sueldo_Base,
            this.Direccion});
            this.Dgv_consultaEmpleados.Location = new System.Drawing.Point(12, 118);
            this.Dgv_consultaEmpleados.Name = "Dgv_consultaEmpleados";
            this.Dgv_consultaEmpleados.RowHeadersVisible = false;
            this.Dgv_consultaEmpleados.RowTemplate.Height = 24;
            this.Dgv_consultaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaEmpleados.Size = new System.Drawing.Size(1111, 305);
            this.Dgv_consultaEmpleados.TabIndex = 66;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.HeaderText = "Nombre";
            this.nombre_empleado.Name = "nombre_empleado";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Apellido";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Fecha Nacimiento";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Correo_Auxiliar
            // 
            this.Correo_Auxiliar.HeaderText = "Correo alternativo";
            this.Correo_Auxiliar.Name = "Correo_Auxiliar";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // telefono_residencial
            // 
            this.telefono_residencial.HeaderText = "Telefono residencial";
            this.telefono_residencial.Name = "telefono_residencial";
            // 
            // Dpi
            // 
            this.Dpi.HeaderText = "Dpi";
            this.Dpi.Name = "Dpi";
            // 
            // Usario
            // 
            this.Usario.HeaderText = "Usuario";
            this.Usario.Name = "Usario";
            // 
            // Cuenta_Bancaria
            // 
            this.Cuenta_Bancaria.HeaderText = "Cuenta_Bancaria";
            this.Cuenta_Bancaria.Name = "Cuenta_Bancaria";
            // 
            // Nit
            // 
            this.Nit.HeaderText = "Nit";
            this.Nit.Name = "Nit";
            // 
            // Sueldo_Base
            // 
            this.Sueldo_Base.HeaderText = "Sueldo_Base";
            this.Sueldo_Base.Name = "Sueldo_Base";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
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
            this.Btn_consulta.Location = new System.Drawing.Point(1083, 56);
            this.Btn_consulta.Name = "Btn_consulta";
            this.Btn_consulta.Size = new System.Drawing.Size(40, 40);
            this.Btn_consulta.TabIndex = 65;
            this.Btn_consulta.Text = "Consultar";
            this.Btn_consulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consulta.UseVisualStyleBackColor = false;
            this.Btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // Txt_consultaEmpleado
            // 
            this.Txt_consultaEmpleado.Location = new System.Drawing.Point(119, 68);
            this.Txt_consultaEmpleado.Name = "Txt_consultaEmpleado";
            this.Txt_consultaEmpleado.Size = new System.Drawing.Size(934, 22);
            this.Txt_consultaEmpleado.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nombre:";
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_ayuda);
            this.Pnl_principal.Controls.Add(this.button1);
            this.Pnl_principal.Controls.Add(this.button2);
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(5);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1162, 40);
            this.Pnl_principal.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1024, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1104, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 40);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1239, -1);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(1319, -1);
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
            this.Lbl_titulo.Location = new System.Drawing.Point(42, 12);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(211, 20);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Consulta De Empleados";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(945, 1);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(35, 35);
            this.Btn_ayuda.TabIndex = 118;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Frm_consultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 593);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaEmpleados);
            this.Controls.Add(this.Btn_consulta);
            this.Controls.Add(this.Txt_consultaEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_consultaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaEmpleado";
            this.Load += new System.EventHandler(this.Frm_consultaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaEmpleados)).EndInit();
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_seleccionar;
        public System.Windows.Forms.DataGridView Dgv_consultaEmpleados;
        private System.Windows.Forms.Button Btn_consulta;
        private System.Windows.Forms.TextBox Txt_consultaEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_residencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Bancaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo_Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}