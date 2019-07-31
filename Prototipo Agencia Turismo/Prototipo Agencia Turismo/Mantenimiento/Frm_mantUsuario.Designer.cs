namespace Prototipo_Agencia_Turismo.Mantenimiento
{
    partial class Frm_mantUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mantUsuario));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Txt_idPerfil = new System.Windows.Forms.TextBox();
            this.Lbl_idPerfil = new System.Windows.Forms.Label();
            this.Txt_confirmarContrasena = new System.Windows.Forms.TextBox();
            this.Lbl_confirmarContrasena = new System.Windows.Forms.Label();
            this.Txt_contrasena = new System.Windows.Forms.TextBox();
            this.Lbl_contrasena = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Txt_idUsuario = new System.Windows.Forms.TextBox();
            this.Lbl_idUsuario = new System.Windows.Forms.Label();
            this.Btn_consultaPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
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
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(5);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 51);
            this.Pnl_principal.TabIndex = 4;
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
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(42, 21);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(89, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "USUARIOS";
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(275, 59);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(115, 85);
            this.Btn_ingresar.TabIndex = 24;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(387, 59);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(115, 85);
            this.Btn_editar.TabIndex = 25;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(499, 59);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(115, 85);
            this.Btn_guardar.TabIndex = 26;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_cancelar.FlatAppearance.BorderSize = 3;
            this.Btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cancelar.Location = new System.Drawing.Point(611, 59);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(115, 85);
            this.Btn_cancelar.TabIndex = 27;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(723, 59);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(115, 85);
            this.Btn_borrar.TabIndex = 28;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
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
            this.Btn_consultar.Location = new System.Drawing.Point(834, 59);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(115, 85);
            this.Btn_consultar.TabIndex = 29;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Txt_idPerfil
            // 
            this.Txt_idPerfil.Enabled = false;
            this.Txt_idPerfil.Location = new System.Drawing.Point(595, 411);
            this.Txt_idPerfil.Name = "Txt_idPerfil";
            this.Txt_idPerfil.Size = new System.Drawing.Size(172, 28);
            this.Txt_idPerfil.TabIndex = 39;
            // 
            // Lbl_idPerfil
            // 
            this.Lbl_idPerfil.AutoSize = true;
            this.Lbl_idPerfil.Location = new System.Drawing.Point(379, 414);
            this.Lbl_idPerfil.Name = "Lbl_idPerfil";
            this.Lbl_idPerfil.Size = new System.Drawing.Size(100, 21);
            this.Lbl_idPerfil.TabIndex = 38;
            this.Lbl_idPerfil.Text = "ID de perfil";
            // 
            // Txt_confirmarContrasena
            // 
            this.Txt_confirmarContrasena.Enabled = false;
            this.Txt_confirmarContrasena.Location = new System.Drawing.Point(595, 363);
            this.Txt_confirmarContrasena.Name = "Txt_confirmarContrasena";
            this.Txt_confirmarContrasena.PasswordChar = '*';
            this.Txt_confirmarContrasena.Size = new System.Drawing.Size(243, 28);
            this.Txt_confirmarContrasena.TabIndex = 37;
            // 
            // Lbl_confirmarContrasena
            // 
            this.Lbl_confirmarContrasena.AutoSize = true;
            this.Lbl_confirmarContrasena.Location = new System.Drawing.Point(377, 366);
            this.Lbl_confirmarContrasena.Name = "Lbl_confirmarContrasena";
            this.Lbl_confirmarContrasena.Size = new System.Drawing.Size(191, 21);
            this.Lbl_confirmarContrasena.TabIndex = 36;
            this.Lbl_confirmarContrasena.Text = "Confirmar contraseña";
            // 
            // Txt_contrasena
            // 
            this.Txt_contrasena.Enabled = false;
            this.Txt_contrasena.Location = new System.Drawing.Point(595, 311);
            this.Txt_contrasena.Name = "Txt_contrasena";
            this.Txt_contrasena.PasswordChar = '*';
            this.Txt_contrasena.Size = new System.Drawing.Size(243, 28);
            this.Txt_contrasena.TabIndex = 35;
            // 
            // Lbl_contrasena
            // 
            this.Lbl_contrasena.AutoSize = true;
            this.Lbl_contrasena.Location = new System.Drawing.Point(377, 314);
            this.Lbl_contrasena.Name = "Lbl_contrasena";
            this.Lbl_contrasena.Size = new System.Drawing.Size(109, 21);
            this.Lbl_contrasena.TabIndex = 34;
            this.Lbl_contrasena.Text = "Contraseña";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Enabled = false;
            this.Txt_nombre.Location = new System.Drawing.Point(595, 259);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(172, 28);
            this.Txt_nombre.TabIndex = 33;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(379, 262);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(51, 21);
            this.Lbl_nombre.TabIndex = 32;
            this.Lbl_nombre.Text = "Nick:";
            // 
            // Txt_idUsuario
            // 
            this.Txt_idUsuario.Enabled = false;
            this.Txt_idUsuario.Location = new System.Drawing.Point(595, 209);
            this.Txt_idUsuario.Name = "Txt_idUsuario";
            this.Txt_idUsuario.Size = new System.Drawing.Size(100, 28);
            this.Txt_idUsuario.TabIndex = 31;
            // 
            // Lbl_idUsuario
            // 
            this.Lbl_idUsuario.AutoSize = true;
            this.Lbl_idUsuario.Location = new System.Drawing.Point(379, 212);
            this.Lbl_idUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_idUsuario.Name = "Lbl_idUsuario";
            this.Lbl_idUsuario.Size = new System.Drawing.Size(119, 21);
            this.Lbl_idUsuario.TabIndex = 30;
            this.Lbl_idUsuario.Text = "ID de usuario";
            // 
            // Btn_consultaPerfil
            // 
            this.Btn_consultaPerfil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultaPerfil.Enabled = false;
            this.Btn_consultaPerfil.FlatAppearance.BorderSize = 3;
            this.Btn_consultaPerfil.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaPerfil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaPerfil.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaPerfil.Image")));
            this.Btn_consultaPerfil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultaPerfil.Location = new System.Drawing.Point(773, 399);
            this.Btn_consultaPerfil.Name = "Btn_consultaPerfil";
            this.Btn_consultaPerfil.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaPerfil.TabIndex = 40;
            this.Btn_consultaPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaPerfil.UseVisualStyleBackColor = false;
            this.Btn_consultaPerfil.Click += new System.EventHandler(this.Btn_consultaPerfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Estado";
            // 
            // Txt_estado
            // 
            this.Txt_estado.Enabled = false;
            this.Txt_estado.Location = new System.Drawing.Point(595, 466);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(100, 28);
            this.Txt_estado.TabIndex = 42;
            // 
            // Frm_mantUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_consultaPerfil);
            this.Controls.Add(this.Txt_idPerfil);
            this.Controls.Add(this.Lbl_idPerfil);
            this.Controls.Add(this.Txt_confirmarContrasena);
            this.Controls.Add(this.Lbl_confirmarContrasena);
            this.Controls.Add(this.Txt_contrasena);
            this.Controls.Add(this.Lbl_contrasena);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Txt_idUsuario);
            this.Controls.Add(this.Lbl_idUsuario);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_mantUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_mantUsuario";
            this.Load += new System.EventHandler(this.Frm_mantUsuario_Load);
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
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.TextBox Txt_idPerfil;
        private System.Windows.Forms.Label Lbl_idPerfil;
        private System.Windows.Forms.TextBox Txt_confirmarContrasena;
        private System.Windows.Forms.Label Lbl_confirmarContrasena;
        private System.Windows.Forms.TextBox Txt_contrasena;
        private System.Windows.Forms.Label Lbl_contrasena;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.TextBox Txt_idUsuario;
        private System.Windows.Forms.Label Lbl_idUsuario;
        private System.Windows.Forms.Button Btn_consultaPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_estado;
    }
}