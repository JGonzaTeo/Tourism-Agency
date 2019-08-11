namespace Prototipo_Agencia_Turismo
{
    partial class Frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Lbl_nombreEmpresa = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_contrasena = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_contrasena = new System.Windows.Forms.TextBox();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BackColor = System.Drawing.Color.SeaGreen;
            this.Pnl_principal.Controls.Add(this.Btn_ayuda);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.label1);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(700, 40);
            this.Pnl_principal.TabIndex = 0;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(580, 0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(35, 35);
            this.Btn_ayuda.TabIndex = 9;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(650, 1);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(35, 35);
            this.Btn_cerrar.TabIndex = 8;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "INICIO DE SESIÓN";
            // 
            // Pic_logo
            // 
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(250, 80);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(212, 164);
            this.Pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_logo.TabIndex = 1;
            this.Pic_logo.TabStop = false;
            // 
            // Lbl_nombreEmpresa
            // 
            this.Lbl_nombreEmpresa.AutoSize = true;
            this.Lbl_nombreEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreEmpresa.Location = new System.Drawing.Point(270, 40);
            this.Lbl_nombreEmpresa.Name = "Lbl_nombreEmpresa";
            this.Lbl_nombreEmpresa.Size = new System.Drawing.Size(202, 23);
            this.Lbl_nombreEmpresa.TabIndex = 2;
            this.Lbl_nombreEmpresa.Text = "Agencia de turismo";
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(130, 287);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(67, 20);
            this.Lbl_usuario.TabIndex = 3;
            this.Lbl_usuario.Text = "Usuario:";
            // 
            // Lbl_contrasena
            // 
            this.Lbl_contrasena.AutoSize = true;
            this.Lbl_contrasena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contrasena.Location = new System.Drawing.Point(130, 335);
            this.Lbl_contrasena.Name = "Lbl_contrasena";
            this.Lbl_contrasena.Size = new System.Drawing.Size(99, 20);
            this.Lbl_contrasena.TabIndex = 4;
            this.Lbl_contrasena.Text = "Contraseña:";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.Location = new System.Drawing.Point(250, 275);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(212, 28);
            this.Txt_usuario.TabIndex = 5;
            this.Txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_contrasena
            // 
            this.Txt_contrasena.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contrasena.Location = new System.Drawing.Point(250, 332);
            this.Txt_contrasena.Name = "Txt_contrasena";
            this.Txt_contrasena.PasswordChar = '*';
            this.Txt_contrasena.Size = new System.Drawing.Size(212, 28);
            this.Txt_contrasena.TabIndex = 6;
            this.Txt_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_ingresar.FlatAppearance.BorderSize = 2;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Location = new System.Drawing.Point(591, 399);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(106, 31);
            this.Btn_ingresar.TabIndex = 7;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 433);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Txt_contrasena);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Lbl_contrasena);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Lbl_nombreEmpresa);
            this.Controls.Add(this.Pic_logo);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Label Lbl_nombreEmpresa;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.Label Lbl_contrasena;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_contrasena;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}

