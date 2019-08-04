namespace Prototipo_Agencia_Turismo.Procesos
{
    partial class Frm_AsignacionEmpGuia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsignacionEmpGuia));
            this.Gpb_Horario = new System.Windows.Forms.GroupBox();
            this.Dtp_Fechafin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fechainicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_horainicio = new System.Windows.Forms.Label();
            this.Lbl_horafinal = new System.Windows.Forms.Label();
            this.Gpb_Busqueda = new System.Windows.Forms.GroupBox();
            this.Btn_buscarGuia = new System.Windows.Forms.Button();
            this.Btn_ConsultaEmpleado = new System.Windows.Forms.Button();
            this.Lbl_idempleado = new System.Windows.Forms.Label();
            this.Txt_idEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_idGuia = new System.Windows.Forms.Label();
            this.Txt_Guia = new System.Windows.Forms.TextBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar1 = new System.Windows.Forms.Button();
            this.Btn_cerrar1 = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Gpb_Horario.SuspendLayout();
            this.Gpb_Busqueda.SuspendLayout();
            this.Pnl_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Horario
            // 
            this.Gpb_Horario.Controls.Add(this.Dtp_Fechafin);
            this.Gpb_Horario.Controls.Add(this.Dtp_Fechainicio);
            this.Gpb_Horario.Controls.Add(this.Lbl_horainicio);
            this.Gpb_Horario.Controls.Add(this.Lbl_horafinal);
            this.Gpb_Horario.Location = new System.Drawing.Point(160, 342);
            this.Gpb_Horario.Name = "Gpb_Horario";
            this.Gpb_Horario.Size = new System.Drawing.Size(921, 120);
            this.Gpb_Horario.TabIndex = 75;
            this.Gpb_Horario.TabStop = false;
            this.Gpb_Horario.Text = "Horario:";
            // 
            // Dtp_Fechafin
            // 
            this.Dtp_Fechafin.CustomFormat = "yyyy-MM-dd";
            this.Dtp_Fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fechafin.Location = new System.Drawing.Point(569, 54);
            this.Dtp_Fechafin.Name = "Dtp_Fechafin";
            this.Dtp_Fechafin.Size = new System.Drawing.Size(125, 22);
            this.Dtp_Fechafin.TabIndex = 110;
            // 
            // Dtp_Fechainicio
            // 
            this.Dtp_Fechainicio.CustomFormat = "yyyy-MM-dd";
            this.Dtp_Fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fechainicio.Location = new System.Drawing.Point(146, 49);
            this.Dtp_Fechainicio.Name = "Dtp_Fechainicio";
            this.Dtp_Fechainicio.Size = new System.Drawing.Size(125, 22);
            this.Dtp_Fechainicio.TabIndex = 109;
            // 
            // Lbl_horainicio
            // 
            this.Lbl_horainicio.AutoSize = true;
            this.Lbl_horainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_horainicio.Location = new System.Drawing.Point(8, 51);
            this.Lbl_horainicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_horainicio.Name = "Lbl_horainicio";
            this.Lbl_horainicio.Size = new System.Drawing.Size(113, 20);
            this.Lbl_horainicio.TabIndex = 51;
            this.Lbl_horainicio.Text = "Hora de inicio";
            // 
            // Lbl_horafinal
            // 
            this.Lbl_horafinal.AutoSize = true;
            this.Lbl_horafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_horafinal.Location = new System.Drawing.Point(470, 56);
            this.Lbl_horafinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_horafinal.Name = "Lbl_horafinal";
            this.Lbl_horafinal.Size = new System.Drawing.Size(92, 20);
            this.Lbl_horafinal.TabIndex = 53;
            this.Lbl_horafinal.Text = "Hora de fin";
            // 
            // Gpb_Busqueda
            // 
            this.Gpb_Busqueda.Controls.Add(this.Btn_buscarGuia);
            this.Gpb_Busqueda.Controls.Add(this.Btn_ConsultaEmpleado);
            this.Gpb_Busqueda.Controls.Add(this.Lbl_idempleado);
            this.Gpb_Busqueda.Controls.Add(this.Txt_idEmpleado);
            this.Gpb_Busqueda.Controls.Add(this.Lbl_idGuia);
            this.Gpb_Busqueda.Controls.Add(this.Txt_Guia);
            this.Gpb_Busqueda.Location = new System.Drawing.Point(160, 195);
            this.Gpb_Busqueda.Name = "Gpb_Busqueda";
            this.Gpb_Busqueda.Size = new System.Drawing.Size(921, 120);
            this.Gpb_Busqueda.TabIndex = 74;
            this.Gpb_Busqueda.TabStop = false;
            this.Gpb_Busqueda.Text = "Busqueda";
            // 
            // Btn_buscarGuia
            // 
            this.Btn_buscarGuia.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_buscarGuia.Location = new System.Drawing.Point(721, 50);
            this.Btn_buscarGuia.Name = "Btn_buscarGuia";
            this.Btn_buscarGuia.Size = new System.Drawing.Size(40, 34);
            this.Btn_buscarGuia.TabIndex = 56;
            this.Btn_buscarGuia.Text = "B";
            this.Btn_buscarGuia.UseVisualStyleBackColor = false;
            this.Btn_buscarGuia.Click += new System.EventHandler(this.Btn_buscarGuia_Click);
            // 
            // Btn_ConsultaEmpleado
            // 
            this.Btn_ConsultaEmpleado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_ConsultaEmpleado.Location = new System.Drawing.Point(326, 45);
            this.Btn_ConsultaEmpleado.Name = "Btn_ConsultaEmpleado";
            this.Btn_ConsultaEmpleado.Size = new System.Drawing.Size(40, 34);
            this.Btn_ConsultaEmpleado.TabIndex = 55;
            this.Btn_ConsultaEmpleado.Text = "B";
            this.Btn_ConsultaEmpleado.UseVisualStyleBackColor = false;
            this.Btn_ConsultaEmpleado.Click += new System.EventHandler(this.Btn_ConsultaEmpleado_Click);
            // 
            // Lbl_idempleado
            // 
            this.Lbl_idempleado.AutoSize = true;
            this.Lbl_idempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idempleado.Location = new System.Drawing.Point(8, 51);
            this.Lbl_idempleado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_idempleado.Name = "Lbl_idempleado";
            this.Lbl_idempleado.Size = new System.Drawing.Size(168, 20);
            this.Lbl_idempleado.TabIndex = 51;
            this.Lbl_idempleado.Text = "Nombre de empleado";
            // 
            // Txt_idEmpleado
            // 
            this.Txt_idEmpleado.Enabled = false;
            this.Txt_idEmpleado.Location = new System.Drawing.Point(195, 51);
            this.Txt_idEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_idEmpleado.Name = "Txt_idEmpleado";
            this.Txt_idEmpleado.Size = new System.Drawing.Size(124, 22);
            this.Txt_idEmpleado.TabIndex = 52;
            // 
            // Lbl_idGuia
            // 
            this.Lbl_idGuia.AutoSize = true;
            this.Lbl_idGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idGuia.Location = new System.Drawing.Point(470, 56);
            this.Lbl_idGuia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_idGuia.Name = "Lbl_idGuia";
            this.Lbl_idGuia.Size = new System.Drawing.Size(108, 20);
            this.Lbl_idGuia.TabIndex = 53;
            this.Lbl_idGuia.Text = "Nombre Guia";
            // 
            // Txt_Guia
            // 
            this.Txt_Guia.Enabled = false;
            this.Txt_Guia.Location = new System.Drawing.Point(586, 56);
            this.Txt_Guia.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Guia.Name = "Txt_Guia";
            this.Txt_Guia.Size = new System.Drawing.Size(128, 22);
            this.Txt_Guia.TabIndex = 54;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(742, 73);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(115, 115);
            this.Btn_consultar.TabIndex = 73;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(619, 73);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(115, 115);
            this.Btn_borrar.TabIndex = 72;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_cancelar.FlatAppearance.BorderSize = 3;
            this.Btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cancelar.Location = new System.Drawing.Point(496, 73);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(115, 115);
            this.Btn_cancelar.TabIndex = 71;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(373, 73);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(115, 115);
            this.Btn_guardar.TabIndex = 70;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_minimizar1);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar1);
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Location = new System.Drawing.Point(1, 2);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 51);
            this.Pnl_principal.TabIndex = 68;
            // 
            // Btn_minimizar1
            // 
            this.Btn_minimizar1.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar1.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar1.Image")));
            this.Btn_minimizar1.Location = new System.Drawing.Point(1020, 1);
            this.Btn_minimizar1.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar1.Name = "Btn_minimizar1";
            this.Btn_minimizar1.Size = new System.Drawing.Size(44, 48);
            this.Btn_minimizar1.TabIndex = 13;
            this.Btn_minimizar1.UseVisualStyleBackColor = true;
            this.Btn_minimizar1.Click += new System.EventHandler(this.Btn_minimizar1_Click);
            // 
            // Btn_cerrar1
            // 
            this.Btn_cerrar1.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar1.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar1.Image")));
            this.Btn_cerrar1.Location = new System.Drawing.Point(1100, 1);
            this.Btn_cerrar1.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar1.Name = "Btn_cerrar1";
            this.Btn_cerrar1.Size = new System.Drawing.Size(44, 48);
            this.Btn_cerrar1.TabIndex = 12;
            this.Btn_cerrar1.UseVisualStyleBackColor = true;
            this.Btn_cerrar1.Click += new System.EventHandler(this.Btn_cerrar1_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1275, 1);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(55, 63);
            this.Btn_minimizar.TabIndex = 11;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1375, 1);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(55, 63);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(52, 28);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(332, 20);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Asignacion Empleado A Guia Turistico";
            // 
            // Frm_AsignacionEmpGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Gpb_Horario);
            this.Controls.Add(this.Gpb_Busqueda);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Pnl_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AsignacionEmpGuia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AsignacionEmpGuia";
            this.Load += new System.EventHandler(this.Frm_AsignacionEmpGuia_Load);
            this.Gpb_Horario.ResumeLayout(false);
            this.Gpb_Horario.PerformLayout();
            this.Gpb_Busqueda.ResumeLayout(false);
            this.Gpb_Busqueda.PerformLayout();
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Horario;
        private System.Windows.Forms.DateTimePicker Dtp_Fechafin;
        private System.Windows.Forms.DateTimePicker Dtp_Fechainicio;
        private System.Windows.Forms.Label Lbl_horainicio;
        private System.Windows.Forms.Label Lbl_horafinal;
        private System.Windows.Forms.GroupBox Gpb_Busqueda;
        private System.Windows.Forms.Button Btn_buscarGuia;
        private System.Windows.Forms.Button Btn_ConsultaEmpleado;
        private System.Windows.Forms.Label Lbl_idempleado;
        private System.Windows.Forms.TextBox Txt_idEmpleado;
        private System.Windows.Forms.Label Lbl_idGuia;
        private System.Windows.Forms.TextBox Txt_Guia;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar1;
        private System.Windows.Forms.Button Btn_cerrar1;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
    }
}