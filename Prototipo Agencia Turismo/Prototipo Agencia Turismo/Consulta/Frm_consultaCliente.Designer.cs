namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaCliente));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Dgv_consultaCliente = new System.Windows.Forms.DataGridView();
            this.Btn_consultaCliente = new System.Windows.Forms.Button();
            this.Txt_consultaDpi = new System.Windows.Forms.TextBox();
            this.Lbl_consultaCliente = new System.Windows.Forms.Label();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCliente)).BeginInit();
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
            this.Pnl_principal.TabIndex = 8;
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
            this.Lbl_titulo.Size = new System.Drawing.Size(155, 17);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE CLIENTE";
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(763, 577);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 59;
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
            this.Btn_seleccionar.Location = new System.Drawing.Point(963, 577);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(164, 41);
            this.Btn_seleccionar.TabIndex = 58;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Dgv_consultaCliente
            // 
            this.Dgv_consultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaNombre,
            this.columnaApellido,
            this.columnaTelefono,
            this.columnaCorreo,
            this.columnaDocumento,
            this.columnaNit});
            this.Dgv_consultaCliente.Location = new System.Drawing.Point(23, 118);
            this.Dgv_consultaCliente.Name = "Dgv_consultaCliente";
            this.Dgv_consultaCliente.RowTemplate.Height = 24;
            this.Dgv_consultaCliente.Size = new System.Drawing.Size(1098, 405);
            this.Dgv_consultaCliente.TabIndex = 57;
            // 
            // Btn_consultaCliente
            // 
            this.Btn_consultaCliente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultaCliente.FlatAppearance.BorderSize = 3;
            this.Btn_consultaCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaCliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaCliente.Image")));
            this.Btn_consultaCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultaCliente.Location = new System.Drawing.Point(1077, 58);
            this.Btn_consultaCliente.Name = "Btn_consultaCliente";
            this.Btn_consultaCliente.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaCliente.TabIndex = 56;
            this.Btn_consultaCliente.Text = "Consultar";
            this.Btn_consultaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaCliente.UseVisualStyleBackColor = false;
            this.Btn_consultaCliente.Click += new System.EventHandler(this.Btn_consultaCliente_Click);
            // 
            // Txt_consultaDpi
            // 
            this.Txt_consultaDpi.Location = new System.Drawing.Point(257, 70);
            this.Txt_consultaDpi.Name = "Txt_consultaDpi";
            this.Txt_consultaDpi.Size = new System.Drawing.Size(790, 26);
            this.Txt_consultaDpi.TabIndex = 55;
            // 
            // Lbl_consultaCliente
            // 
            this.Lbl_consultaCliente.AutoSize = true;
            this.Lbl_consultaCliente.Location = new System.Drawing.Point(25, 73);
            this.Lbl_consultaCliente.Name = "Lbl_consultaCliente";
            this.Lbl_consultaCliente.Size = new System.Drawing.Size(226, 20);
            this.Lbl_consultaCliente.TabIndex = 54;
            this.Lbl_consultaCliente.Text = "Documento de Identificacion";
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Codigo";
            this.columnaCodigo.Name = "columnaCodigo";
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            // 
            // columnaApellido
            // 
            this.columnaApellido.HeaderText = "Apellido";
            this.columnaApellido.Name = "columnaApellido";
            // 
            // columnaTelefono
            // 
            this.columnaTelefono.HeaderText = "Telefono";
            this.columnaTelefono.Name = "columnaTelefono";
            // 
            // columnaCorreo
            // 
            this.columnaCorreo.HeaderText = "Correo";
            this.columnaCorreo.Name = "columnaCorreo";
            // 
            // columnaDocumento
            // 
            this.columnaDocumento.HeaderText = "No. de Documento";
            this.columnaDocumento.Name = "columnaDocumento";
            // 
            // columnaNit
            // 
            this.columnaNit.HeaderText = "NIT";
            this.columnaNit.Name = "columnaNit";
            // 
            // Frm_consultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaCliente);
            this.Controls.Add(this.Btn_consultaCliente);
            this.Controls.Add(this.Txt_consultaDpi);
            this.Controls.Add(this.Lbl_consultaCliente);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_consultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaCliente";
            this.Load += new System.EventHandler(this.Frm_consultaCliente_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_seleccionar;
        public System.Windows.Forms.DataGridView Dgv_consultaCliente;
        private System.Windows.Forms.Button Btn_consultaCliente;
        private System.Windows.Forms.TextBox Txt_consultaDpi;
        private System.Windows.Forms.Label Lbl_consultaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNit;
    }
}