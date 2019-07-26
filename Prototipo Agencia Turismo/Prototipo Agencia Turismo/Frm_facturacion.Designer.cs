namespace Prototipo_Agencia_Turismo
{
    partial class Frm_facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_facturacion));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_idFactura = new System.Windows.Forms.Label();
            this.Lbl_factura = new System.Windows.Forms.Label();
            this.Lbl_idCliente = new System.Windows.Forms.Label();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.Lbl_idEmpleado = new System.Windows.Forms.Label();
            this.Lbl_empleado = new System.Windows.Forms.Label();
            this.Dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.Btn_consultaCliente = new System.Windows.Forms.Button();
            this.Lbl_fechaFacturacion = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_cantPasajeros = new System.Windows.Forms.Label();
            this.Txt_cantPasajeros = new System.Windows.Forms.TextBox();
            this.Lbl_cantHabitaciones = new System.Windows.Forms.Label();
            this.Txt_cantHabitaciones = new System.Windows.Forms.TextBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_facturar = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).BeginInit();
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
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 0;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1020, -5);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(44, 48);
            this.Btn_minimizar.TabIndex = 12;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(1100, -5);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(44, 48);
            this.Btn_cerrar.TabIndex = 11;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(24, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(128, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "FACTURACIÓN";
            // 
            // Lbl_idFactura
            // 
            this.Lbl_idFactura.AutoSize = true;
            this.Lbl_idFactura.Location = new System.Drawing.Point(93, 64);
            this.Lbl_idFactura.Name = "Lbl_idFactura";
            this.Lbl_idFactura.Size = new System.Drawing.Size(128, 21);
            this.Lbl_idFactura.TabIndex = 1;
            this.Lbl_idFactura.Text = "ID de factura:";
            // 
            // Lbl_factura
            // 
            this.Lbl_factura.AutoSize = true;
            this.Lbl_factura.Location = new System.Drawing.Point(256, 64);
            this.Lbl_factura.Name = "Lbl_factura";
            this.Lbl_factura.Size = new System.Drawing.Size(109, 21);
            this.Lbl_factura.TabIndex = 2;
            this.Lbl_factura.Text = "codFactura";
            // 
            // Lbl_idCliente
            // 
            this.Lbl_idCliente.AutoSize = true;
            this.Lbl_idCliente.Location = new System.Drawing.Point(93, 115);
            this.Lbl_idCliente.Name = "Lbl_idCliente";
            this.Lbl_idCliente.Size = new System.Drawing.Size(122, 21);
            this.Lbl_idCliente.TabIndex = 3;
            this.Lbl_idCliente.Text = "ID de cliente:";
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Location = new System.Drawing.Point(256, 115);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.Size = new System.Drawing.Size(103, 21);
            this.Lbl_cliente.TabIndex = 4;
            this.Lbl_cliente.Text = "codCliente";
            // 
            // Lbl_idEmpleado
            // 
            this.Lbl_idEmpleado.AutoSize = true;
            this.Lbl_idEmpleado.Location = new System.Drawing.Point(93, 168);
            this.Lbl_idEmpleado.Name = "Lbl_idEmpleado";
            this.Lbl_idEmpleado.Size = new System.Drawing.Size(153, 21);
            this.Lbl_idEmpleado.TabIndex = 5;
            this.Lbl_idEmpleado.Text = "ID de empleado:";
            // 
            // Lbl_empleado
            // 
            this.Lbl_empleado.AutoSize = true;
            this.Lbl_empleado.Location = new System.Drawing.Point(256, 168);
            this.Lbl_empleado.Name = "Lbl_empleado";
            this.Lbl_empleado.Size = new System.Drawing.Size(129, 21);
            this.Lbl_empleado.TabIndex = 6;
            this.Lbl_empleado.Text = "codEmpleado";
            // 
            // Dgv_detalleFactura
            // 
            this.Dgv_detalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleFactura.Location = new System.Drawing.Point(184, 252);
            this.Dgv_detalleFactura.Name = "Dgv_detalleFactura";
            this.Dgv_detalleFactura.RowTemplate.Height = 24;
            this.Dgv_detalleFactura.Size = new System.Drawing.Size(788, 272);
            this.Dgv_detalleFactura.TabIndex = 7;
            // 
            // Btn_consultaCliente
            // 
            this.Btn_consultaCliente.Location = new System.Drawing.Point(365, 106);
            this.Btn_consultaCliente.Name = "Btn_consultaCliente";
            this.Btn_consultaCliente.Size = new System.Drawing.Size(64, 39);
            this.Btn_consultaCliente.TabIndex = 8;
            this.Btn_consultaCliente.Text = "...";
            this.Btn_consultaCliente.UseVisualStyleBackColor = true;
            // 
            // Lbl_fechaFacturacion
            // 
            this.Lbl_fechaFacturacion.AutoSize = true;
            this.Lbl_fechaFacturacion.Location = new System.Drawing.Point(658, 542);
            this.Lbl_fechaFacturacion.Name = "Lbl_fechaFacturacion";
            this.Lbl_fechaFacturacion.Size = new System.Drawing.Size(197, 21);
            this.Lbl_fechaFacturacion.TabIndex = 9;
            this.Lbl_fechaFacturacion.Text = "Fecha de facturación:";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(862, 542);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(110, 21);
            this.Lbl_fecha.TabIndex = 10;
            this.Lbl_fecha.Text = "yyyy/mm/dd";
            // 
            // Lbl_cantPasajeros
            // 
            this.Lbl_cantPasajeros.AutoSize = true;
            this.Lbl_cantPasajeros.Location = new System.Drawing.Point(191, 217);
            this.Lbl_cantPasajeros.Name = "Lbl_cantPasajeros";
            this.Lbl_cantPasajeros.Size = new System.Drawing.Size(208, 21);
            this.Lbl_cantPasajeros.TabIndex = 11;
            this.Lbl_cantPasajeros.Text = "Cantidad de Pasajeros:";
            // 
            // Txt_cantPasajeros
            // 
            this.Txt_cantPasajeros.Location = new System.Drawing.Point(400, 214);
            this.Txt_cantPasajeros.Name = "Txt_cantPasajeros";
            this.Txt_cantPasajeros.Size = new System.Drawing.Size(68, 28);
            this.Txt_cantPasajeros.TabIndex = 12;
            // 
            // Lbl_cantHabitaciones
            // 
            this.Lbl_cantHabitaciones.AutoSize = true;
            this.Lbl_cantHabitaciones.Location = new System.Drawing.Point(658, 217);
            this.Lbl_cantHabitaciones.Name = "Lbl_cantHabitaciones";
            this.Lbl_cantHabitaciones.Size = new System.Drawing.Size(241, 21);
            this.Lbl_cantHabitaciones.TabIndex = 13;
            this.Lbl_cantHabitaciones.Text = "Cantidad de Habitaciones:";
            // 
            // Txt_cantHabitaciones
            // 
            this.Txt_cantHabitaciones.Location = new System.Drawing.Point(904, 214);
            this.Txt_cantHabitaciones.Name = "Txt_cantHabitaciones";
            this.Txt_cantHabitaciones.Size = new System.Drawing.Size(68, 28);
            this.Txt_cantHabitaciones.TabIndex = 14;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.FlatAppearance.BorderSize = 3;
            this.Btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.Location = new System.Drawing.Point(993, 356);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(175, 38);
            this.Btn_agregar.TabIndex = 15;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.FlatAppearance.BorderSize = 3;
            this.Btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(993, 422);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(175, 38);
            this.Btn_eliminar.TabIndex = 16;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_facturar
            // 
            this.Btn_facturar.FlatAppearance.BorderSize = 3;
            this.Btn_facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_facturar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_facturar.Location = new System.Drawing.Point(993, 486);
            this.Btn_facturar.Name = "Btn_facturar";
            this.Btn_facturar.Size = new System.Drawing.Size(175, 38);
            this.Btn_facturar.TabIndex = 17;
            this.Btn_facturar.Text = "Facturar";
            this.Btn_facturar.UseVisualStyleBackColor = true;
            // 
            // Frm_facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_facturar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Txt_cantHabitaciones);
            this.Controls.Add(this.Lbl_cantHabitaciones);
            this.Controls.Add(this.Txt_cantPasajeros);
            this.Controls.Add(this.Lbl_cantPasajeros);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_fechaFacturacion);
            this.Controls.Add(this.Btn_consultaCliente);
            this.Controls.Add(this.Dgv_detalleFactura);
            this.Controls.Add(this.Lbl_empleado);
            this.Controls.Add(this.Lbl_idEmpleado);
            this.Controls.Add(this.Lbl_cliente);
            this.Controls.Add(this.Lbl_idCliente);
            this.Controls.Add(this.Lbl_factura);
            this.Controls.Add(this.Lbl_idFactura);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_facturacion";
            this.Load += new System.EventHandler(this.Frm_facturacion_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_idFactura;
        private System.Windows.Forms.Label Lbl_factura;
        private System.Windows.Forms.Label Lbl_idCliente;
        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.Label Lbl_idEmpleado;
        private System.Windows.Forms.Label Lbl_empleado;
        private System.Windows.Forms.DataGridView Dgv_detalleFactura;
        private System.Windows.Forms.Button Btn_consultaCliente;
        private System.Windows.Forms.Label Lbl_fechaFacturacion;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_cantPasajeros;
        private System.Windows.Forms.TextBox Txt_cantPasajeros;
        private System.Windows.Forms.Label Lbl_cantHabitaciones;
        private System.Windows.Forms.TextBox Txt_cantHabitaciones;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_facturar;
    }
}