namespace Prototipo_Agencia_Turismo.Consulta
{
    partial class Frm_consultaTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaTransporte));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Dgv_consultaTransporte = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipoTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_consultaTransporte = new System.Windows.Forms.Button();
            this.Txt_consultaPlaca = new System.Windows.Forms.TextBox();
            this.Lbl_consultaTransporte = new System.Windows.Forms.Label();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaTransporte)).BeginInit();
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
            this.Pnl_principal.TabIndex = 7;
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
            this.Lbl_titulo.Size = new System.Drawing.Size(186, 17);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONSULTA DE TRANSPORTE";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(762, 575);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 53;
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
            this.Btn_seleccionar.Location = new System.Drawing.Point(962, 575);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(164, 41);
            this.Btn_seleccionar.TabIndex = 52;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Dgv_consultaTransporte
            // 
            this.Dgv_consultaTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaTransporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaPlaca,
            this.columnaTipoTransporte,
            this.columnaCapacidad});
            this.Dgv_consultaTransporte.Location = new System.Drawing.Point(22, 116);
            this.Dgv_consultaTransporte.Name = "Dgv_consultaTransporte";
            this.Dgv_consultaTransporte.RowTemplate.Height = 24;
            this.Dgv_consultaTransporte.Size = new System.Drawing.Size(1098, 405);
            this.Dgv_consultaTransporte.TabIndex = 51;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Codigo";
            this.columnaCodigo.Name = "columnaCodigo";
            // 
            // columnaPlaca
            // 
            this.columnaPlaca.HeaderText = "Placa";
            this.columnaPlaca.Name = "columnaPlaca";
            // 
            // columnaTipoTransporte
            // 
            this.columnaTipoTransporte.HeaderText = "Tipo de Transporte";
            this.columnaTipoTransporte.Name = "columnaTipoTransporte";
            // 
            // columnaCapacidad
            // 
            this.columnaCapacidad.HeaderText = "Capacidad";
            this.columnaCapacidad.Name = "columnaCapacidad";
            // 
            // Btn_consultaTransporte
            // 
            this.Btn_consultaTransporte.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultaTransporte.FlatAppearance.BorderSize = 3;
            this.Btn_consultaTransporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultaTransporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultaTransporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaTransporte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaTransporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaTransporte.Image")));
            this.Btn_consultaTransporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultaTransporte.Location = new System.Drawing.Point(1076, 56);
            this.Btn_consultaTransporte.Name = "Btn_consultaTransporte";
            this.Btn_consultaTransporte.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultaTransporte.TabIndex = 50;
            this.Btn_consultaTransporte.Text = "Consultar";
            this.Btn_consultaTransporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaTransporte.UseVisualStyleBackColor = false;
            this.Btn_consultaTransporte.Click += new System.EventHandler(this.Btn_consultaTransporte_Click);
            // 
            // Txt_consultaPlaca
            // 
            this.Txt_consultaPlaca.Location = new System.Drawing.Point(112, 68);
            this.Txt_consultaPlaca.Name = "Txt_consultaPlaca";
            this.Txt_consultaPlaca.Size = new System.Drawing.Size(934, 26);
            this.Txt_consultaPlaca.TabIndex = 49;
            // 
            // Lbl_consultaTransporte
            // 
            this.Lbl_consultaTransporte.AutoSize = true;
            this.Lbl_consultaTransporte.Location = new System.Drawing.Point(24, 71);
            this.Lbl_consultaTransporte.Name = "Lbl_consultaTransporte";
            this.Lbl_consultaTransporte.Size = new System.Drawing.Size(51, 20);
            this.Lbl_consultaTransporte.TabIndex = 48;
            this.Lbl_consultaTransporte.Text = "Placa";
            // 
            // Frm_consultaTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaTransporte);
            this.Controls.Add(this.Btn_consultaTransporte);
            this.Controls.Add(this.Txt_consultaPlaca);
            this.Controls.Add(this.Lbl_consultaTransporte);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_consultaTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaTransporte";
            this.Load += new System.EventHandler(this.Frm_consultaTransporte_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaTransporte)).EndInit();
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
        public System.Windows.Forms.DataGridView Dgv_consultaTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipoTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCapacidad;
        private System.Windows.Forms.Button Btn_consultaTransporte;
        private System.Windows.Forms.TextBox Txt_consultaPlaca;
        private System.Windows.Forms.Label Lbl_consultaTransporte;
    }
}