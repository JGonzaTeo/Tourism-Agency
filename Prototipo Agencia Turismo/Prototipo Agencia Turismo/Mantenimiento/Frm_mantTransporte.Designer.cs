namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    partial class Frm_mantTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mantTransporte));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_idTransporte = new System.Windows.Forms.Label();
            this.Txt_idTransporte = new System.Windows.Forms.TextBox();
            this.Lbl_noPlaca = new System.Windows.Forms.Label();
            this.Txt_noPlaca = new System.Windows.Forms.TextBox();
            this.Lbl_tipoTransporte = new System.Windows.Forms.Label();
            this.Txt_tipoTransporte = new System.Windows.Forms.TextBox();
            this.Lbl_capacidad = new System.Windows.Forms.Label();
            this.Txt_capacidad = new System.Windows.Forms.TextBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
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
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 1;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1020, 1);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(35, 37);
            this.Btn_minimizar.TabIndex = 11;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1100, 1);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(35, 37);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(34, 16);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
<<<<<<< HEAD
            this.Lbl_titulo.Size = new System.Drawing.Size(120, 19);
=======
            this.Lbl_titulo.Size = new System.Drawing.Size(97, 17);
>>>>>>> Integracion-Ivan-José
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "TRANSPORTES";
            // 
            // Lbl_idTransporte
            // 
            this.Lbl_idTransporte.AutoSize = true;
            this.Lbl_idTransporte.Location = new System.Drawing.Point(319, 200);
            this.Lbl_idTransporte.Name = "Lbl_idTransporte";
<<<<<<< HEAD
            this.Lbl_idTransporte.Size = new System.Drawing.Size(153, 21);
            this.Lbl_idTransporte.TabIndex = 2;
            this.Lbl_idTransporte.Text = "ID de transporte:";
=======
            this.Lbl_idTransporte.Size = new System.Drawing.Size(123, 19);
            this.Lbl_idTransporte.TabIndex = 2;
            this.Lbl_idTransporte.Text = "ID de transporte:";
            this.Lbl_idTransporte.Visible = false;
            this.Lbl_idTransporte.Click += new System.EventHandler(this.Lbl_idTransporte_Click);
>>>>>>> Integracion-Ivan-José
            // 
            // Txt_idTransporte
            // 
            this.Txt_idTransporte.Enabled = false;
            this.Txt_idTransporte.Location = new System.Drawing.Point(494, 193);
            this.Txt_idTransporte.Name = "Txt_idTransporte";
<<<<<<< HEAD
            this.Txt_idTransporte.Size = new System.Drawing.Size(138, 28);
            this.Txt_idTransporte.TabIndex = 3;
=======
            this.Txt_idTransporte.Size = new System.Drawing.Size(138, 24);
            this.Txt_idTransporte.TabIndex = 3;
            this.Txt_idTransporte.Visible = false;
            this.Txt_idTransporte.TextChanged += new System.EventHandler(this.Txt_idTransporte_TextChanged);
>>>>>>> Integracion-Ivan-José
            // 
            // Lbl_noPlaca
            // 
            this.Lbl_noPlaca.AutoSize = true;
            this.Lbl_noPlaca.Location = new System.Drawing.Point(319, 264);
            this.Lbl_noPlaca.Name = "Lbl_noPlaca";
<<<<<<< HEAD
            this.Lbl_noPlaca.Size = new System.Drawing.Size(127, 21);
            this.Lbl_noPlaca.TabIndex = 4;
            this.Lbl_noPlaca.Text = "No. de placa:";
            // 
            // Txt_noPlaca
            // 
            this.Txt_noPlaca.Location = new System.Drawing.Point(494, 257);
            this.Txt_noPlaca.Name = "Txt_noPlaca";
            this.Txt_noPlaca.Size = new System.Drawing.Size(190, 28);
            this.Txt_noPlaca.TabIndex = 5;
=======
            this.Lbl_noPlaca.Size = new System.Drawing.Size(105, 19);
            this.Lbl_noPlaca.TabIndex = 4;
            this.Lbl_noPlaca.Text = "No. de placa:";
            this.Lbl_noPlaca.Click += new System.EventHandler(this.Lbl_noPlaca_Click);
            // 
            // Txt_noPlaca
            // 
            this.Txt_noPlaca.Enabled = false;
            this.Txt_noPlaca.Location = new System.Drawing.Point(494, 257);
            this.Txt_noPlaca.Name = "Txt_noPlaca";
            this.Txt_noPlaca.Size = new System.Drawing.Size(190, 24);
            this.Txt_noPlaca.TabIndex = 5;
            this.Txt_noPlaca.TextChanged += new System.EventHandler(this.Txt_noPlaca_TextChanged);
>>>>>>> Integracion-Ivan-José
            // 
            // Lbl_tipoTransporte
            // 
            this.Lbl_tipoTransporte.AutoSize = true;
            this.Lbl_tipoTransporte.Location = new System.Drawing.Point(319, 326);
            this.Lbl_tipoTransporte.Name = "Lbl_tipoTransporte";
<<<<<<< HEAD
            this.Lbl_tipoTransporte.Size = new System.Drawing.Size(169, 21);
            this.Lbl_tipoTransporte.TabIndex = 6;
            this.Lbl_tipoTransporte.Text = "Tipo de transporte:";
            // 
            // Txt_tipoTransporte
            // 
            this.Txt_tipoTransporte.Location = new System.Drawing.Point(494, 319);
            this.Txt_tipoTransporte.Name = "Txt_tipoTransporte";
            this.Txt_tipoTransporte.Size = new System.Drawing.Size(190, 28);
            this.Txt_tipoTransporte.TabIndex = 7;
=======
            this.Lbl_tipoTransporte.Size = new System.Drawing.Size(137, 19);
            this.Lbl_tipoTransporte.TabIndex = 6;
            this.Lbl_tipoTransporte.Text = "Tipo de transporte:";
            this.Lbl_tipoTransporte.Click += new System.EventHandler(this.Lbl_tipoTransporte_Click);
            // 
            // Txt_tipoTransporte
            // 
            this.Txt_tipoTransporte.Enabled = false;
            this.Txt_tipoTransporte.Location = new System.Drawing.Point(494, 319);
            this.Txt_tipoTransporte.Name = "Txt_tipoTransporte";
            this.Txt_tipoTransporte.Size = new System.Drawing.Size(190, 24);
            this.Txt_tipoTransporte.TabIndex = 7;
            this.Txt_tipoTransporte.TextChanged += new System.EventHandler(this.Txt_tipoTransporte_TextChanged);
>>>>>>> Integracion-Ivan-José
            // 
            // Lbl_capacidad
            // 
            this.Lbl_capacidad.AutoSize = true;
            this.Lbl_capacidad.Location = new System.Drawing.Point(319, 388);
            this.Lbl_capacidad.Name = "Lbl_capacidad";
<<<<<<< HEAD
            this.Lbl_capacidad.Size = new System.Drawing.Size(115, 21);
            this.Lbl_capacidad.TabIndex = 8;
            this.Lbl_capacidad.Text = "Capacidad:";
            // 
            // Txt_capacidad
            // 
            this.Txt_capacidad.Location = new System.Drawing.Point(494, 381);
            this.Txt_capacidad.Name = "Txt_capacidad";
            this.Txt_capacidad.Size = new System.Drawing.Size(83, 28);
            this.Txt_capacidad.TabIndex = 9;
=======
            this.Lbl_capacidad.Size = new System.Drawing.Size(96, 19);
            this.Lbl_capacidad.TabIndex = 8;
            this.Lbl_capacidad.Text = "Capacidad:";
            this.Lbl_capacidad.Click += new System.EventHandler(this.Lbl_capacidad_Click);
            // 
            // Txt_capacidad
            // 
            this.Txt_capacidad.Enabled = false;
            this.Txt_capacidad.Location = new System.Drawing.Point(494, 381);
            this.Txt_capacidad.Name = "Txt_capacidad";
            this.Txt_capacidad.Size = new System.Drawing.Size(83, 24);
            this.Txt_capacidad.TabIndex = 9;
            this.Txt_capacidad.TextChanged += new System.EventHandler(this.Txt_capacidad_TextChanged);
>>>>>>> Integracion-Ivan-José
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(842, 59);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(115, 85);
            this.Btn_consultar.TabIndex = 40;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
<<<<<<< HEAD
=======
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
>>>>>>> Integracion-Ivan-José
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(730, 59);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(115, 85);
            this.Btn_borrar.TabIndex = 39;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
<<<<<<< HEAD
=======
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
>>>>>>> Integracion-Ivan-José
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_cancelar.FlatAppearance.BorderSize = 3;
            this.Btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cancelar.Location = new System.Drawing.Point(618, 59);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(115, 85);
            this.Btn_cancelar.TabIndex = 38;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
<<<<<<< HEAD
=======
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
>>>>>>> Integracion-Ivan-José
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(505, 59);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(115, 85);
            this.Btn_guardar.TabIndex = 37;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
<<<<<<< HEAD
=======
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
>>>>>>> Integracion-Ivan-José
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(392, 59);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(115, 85);
            this.Btn_editar.TabIndex = 36;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
<<<<<<< HEAD
=======
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
>>>>>>> Integracion-Ivan-José
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(279, 59);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(115, 85);
            this.Btn_ingresar.TabIndex = 35;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
<<<<<<< HEAD
            // 
            // Frm_mantTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
=======
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Frm_mantTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
>>>>>>> Integracion-Ivan-José
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Txt_capacidad);
            this.Controls.Add(this.Lbl_capacidad);
            this.Controls.Add(this.Txt_tipoTransporte);
            this.Controls.Add(this.Lbl_tipoTransporte);
            this.Controls.Add(this.Txt_noPlaca);
            this.Controls.Add(this.Lbl_noPlaca);
            this.Controls.Add(this.Txt_idTransporte);
            this.Controls.Add(this.Lbl_idTransporte);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_mantTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_mantTransporte";
            this.Load += new System.EventHandler(this.Frm_mantTransporte_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_idTransporte;
        private System.Windows.Forms.TextBox Txt_idTransporte;
        private System.Windows.Forms.Label Lbl_noPlaca;
        private System.Windows.Forms.TextBox Txt_noPlaca;
        private System.Windows.Forms.Label Lbl_tipoTransporte;
        private System.Windows.Forms.TextBox Txt_tipoTransporte;
        private System.Windows.Forms.Label Lbl_capacidad;
        private System.Windows.Forms.TextBox Txt_capacidad;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
    }
}