namespace Prototipo_Agencia_Turismo
{
    partial class Frm_reservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reservacion));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarTuristico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_nombCliente = new System.Windows.Forms.Label();
            this.Lbl_nomCliente = new System.Windows.Forms.Label();
            this.Lbl_idcoti = new System.Windows.Forms.Label();
            this.Lbl_idReservacion = new System.Windows.Forms.Label();
            this.Lbl_metodo = new System.Windows.Forms.Label();
            this.Lbl_metodoPago = new System.Windows.Forms.Label();
            this.Lbl_fechaSalida = new System.Windows.Forms.Label();
            this.Lbl_piloto = new System.Windows.Forms.Label();
            this.Lbl_idPiloto = new System.Windows.Forms.Label();
            this.Lbl_vehiculo = new System.Windows.Forms.Label();
            this.Lbl_idVehiculo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_detalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_busquedaCotizacion = new System.Windows.Forms.Button();
            this.Lbl_reservacion = new System.Windows.Forms.Label();
            this.Lbl_idCotizacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dtp_FecaEntrada = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FecaSalida = new System.Windows.Forms.DateTimePicker();
            this.Btn_consultarPiloto = new System.Windows.Forms.Button();
            this.Btn_consultarVehiculo = new System.Windows.Forms.Button();
            this.Btn_reservar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 1;
            this.Pnl_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_principal_Paint);
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
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
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
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(24, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(126, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "RESERVACION";
            // 
            // Dgv_detalleFactura
            // 
            this.Dgv_detalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_detalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.habitacion,
            this.menu,
            this.lugarTuristico,
            this.cantidad});
            this.Dgv_detalleFactura.Location = new System.Drawing.Point(28, 278);
            this.Dgv_detalleFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_detalleFactura.MultiSelect = false;
            this.Dgv_detalleFactura.Name = "Dgv_detalleFactura";
            this.Dgv_detalleFactura.ReadOnly = true;
            this.Dgv_detalleFactura.RowTemplate.Height = 24;
            this.Dgv_detalleFactura.Size = new System.Drawing.Size(904, 272);
            this.Dgv_detalleFactura.TabIndex = 24;
            // 
            // habitacion
            // 
            this.habitacion.HeaderText = "ID Habitacion";
            this.habitacion.Name = "habitacion";
            this.habitacion.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.HeaderText = "ID Menu";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            // 
            // lugarTuristico
            // 
            this.lugarTuristico.HeaderText = "ID Turistico";
            this.lugarTuristico.Name = "lugarTuristico";
            this.lugarTuristico.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad Habitaciones";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Lbl_nombCliente
            // 
            this.Lbl_nombCliente.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_nombCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_nombCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_nombCliente.Location = new System.Drawing.Point(196, 104);
            this.Lbl_nombCliente.Name = "Lbl_nombCliente";
            this.Lbl_nombCliente.Size = new System.Drawing.Size(178, 26);
            this.Lbl_nombCliente.TabIndex = 23;
            // 
            // Lbl_nomCliente
            // 
            this.Lbl_nomCliente.AutoSize = true;
            this.Lbl_nomCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_nomCliente.Location = new System.Drawing.Point(8, 111);
            this.Lbl_nomCliente.Name = "Lbl_nomCliente";
            this.Lbl_nomCliente.Size = new System.Drawing.Size(122, 21);
            this.Lbl_nomCliente.TabIndex = 22;
            this.Lbl_nomCliente.Text = "ID de cliente:";
            // 
            // Lbl_idcoti
            // 
            this.Lbl_idcoti.AutoSize = true;
            this.Lbl_idcoti.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_idcoti.Location = new System.Drawing.Point(8, 62);
            this.Lbl_idcoti.Name = "Lbl_idcoti";
            this.Lbl_idcoti.Size = new System.Drawing.Size(152, 21);
            this.Lbl_idcoti.TabIndex = 20;
            this.Lbl_idcoti.Text = "ID de cotizacion:";
            // 
            // Lbl_idReservacion
            // 
            this.Lbl_idReservacion.AutoSize = true;
            this.Lbl_idReservacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_idReservacion.Location = new System.Drawing.Point(8, 16);
            this.Lbl_idReservacion.Name = "Lbl_idReservacion";
            this.Lbl_idReservacion.Size = new System.Drawing.Size(158, 21);
            this.Lbl_idReservacion.TabIndex = 18;
            this.Lbl_idReservacion.Text = "ID de reservacion";
            // 
            // Lbl_metodo
            // 
            this.Lbl_metodo.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_metodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_metodo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_metodo.Location = new System.Drawing.Point(196, 147);
            this.Lbl_metodo.Name = "Lbl_metodo";
            this.Lbl_metodo.Size = new System.Drawing.Size(106, 27);
            this.Lbl_metodo.TabIndex = 34;
            // 
            // Lbl_metodoPago
            // 
            this.Lbl_metodoPago.AutoSize = true;
            this.Lbl_metodoPago.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_metodoPago.Location = new System.Drawing.Point(8, 155);
            this.Lbl_metodoPago.Name = "Lbl_metodoPago";
            this.Lbl_metodoPago.Size = new System.Drawing.Size(184, 21);
            this.Lbl_metodoPago.TabIndex = 33;
            this.Lbl_metodoPago.Text = "ID metodo de pago:";
            // 
            // Lbl_fechaSalida
            // 
            this.Lbl_fechaSalida.AutoSize = true;
            this.Lbl_fechaSalida.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_fechaSalida.Location = new System.Drawing.Point(8, 111);
            this.Lbl_fechaSalida.Name = "Lbl_fechaSalida";
            this.Lbl_fechaSalida.Size = new System.Drawing.Size(164, 21);
            this.Lbl_fechaSalida.TabIndex = 40;
            this.Lbl_fechaSalida.Text = "Fecha de entrada";
            // 
            // Lbl_piloto
            // 
            this.Lbl_piloto.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_piloto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_piloto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_piloto.Location = new System.Drawing.Point(196, 66);
            this.Lbl_piloto.Name = "Lbl_piloto";
            this.Lbl_piloto.Size = new System.Drawing.Size(99, 24);
            this.Lbl_piloto.TabIndex = 39;
            // 
            // Lbl_idPiloto
            // 
            this.Lbl_idPiloto.AutoSize = true;
            this.Lbl_idPiloto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_idPiloto.Location = new System.Drawing.Point(8, 67);
            this.Lbl_idPiloto.Name = "Lbl_idPiloto";
            this.Lbl_idPiloto.Size = new System.Drawing.Size(113, 21);
            this.Lbl_idPiloto.TabIndex = 38;
            this.Lbl_idPiloto.Text = "ID de piloto:";
            // 
            // Lbl_vehiculo
            // 
            this.Lbl_vehiculo.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_vehiculo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_vehiculo.Location = new System.Drawing.Point(196, 15);
            this.Lbl_vehiculo.Name = "Lbl_vehiculo";
            this.Lbl_vehiculo.Size = new System.Drawing.Size(99, 28);
            this.Lbl_vehiculo.TabIndex = 37;
            // 
            // Lbl_idVehiculo
            // 
            this.Lbl_idVehiculo.AutoSize = true;
            this.Lbl_idVehiculo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_idVehiculo.Location = new System.Drawing.Point(8, 16);
            this.Lbl_idVehiculo.Name = "Lbl_idVehiculo";
            this.Lbl_idVehiculo.Size = new System.Drawing.Size(136, 21);
            this.Lbl_idVehiculo.TabIndex = 36;
            this.Lbl_idVehiculo.Text = "ID de vehiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(8, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fecha de salida:";
            // 
            // Lbl_detalle
            // 
            this.Lbl_detalle.AutoSize = true;
            this.Lbl_detalle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_detalle.Location = new System.Drawing.Point(25, 248);
            this.Lbl_detalle.Name = "Lbl_detalle";
            this.Lbl_detalle.Size = new System.Drawing.Size(195, 19);
            this.Lbl_detalle.TabIndex = 13;
            this.Lbl_detalle.Text = "DETALLE RESERVACION";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_busquedaCotizacion);
            this.panel1.Controls.Add(this.Lbl_idReservacion);
            this.panel1.Controls.Add(this.Lbl_reservacion);
            this.panel1.Controls.Add(this.Lbl_metodo);
            this.panel1.Controls.Add(this.Lbl_idcoti);
            this.panel1.Controls.Add(this.Lbl_metodoPago);
            this.panel1.Controls.Add(this.Lbl_idCotizacion);
            this.panel1.Controls.Add(this.Lbl_nombCliente);
            this.panel1.Controls.Add(this.Lbl_nomCliente);
            this.panel1.Location = new System.Drawing.Point(43, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(401, 188);
            this.panel1.TabIndex = 51;
            // 
            // Btn_busquedaCotizacion
            // 
            this.Btn_busquedaCotizacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_busquedaCotizacion.FlatAppearance.BorderSize = 3;
            this.Btn_busquedaCotizacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_busquedaCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_busquedaCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_busquedaCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_busquedaCotizacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_busquedaCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_busquedaCotizacion.Image")));
            this.Btn_busquedaCotizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_busquedaCotizacion.Location = new System.Drawing.Point(334, 47);
            this.Btn_busquedaCotizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_busquedaCotizacion.Name = "Btn_busquedaCotizacion";
            this.Btn_busquedaCotizacion.Size = new System.Drawing.Size(40, 40);
            this.Btn_busquedaCotizacion.TabIndex = 59;
            this.Btn_busquedaCotizacion.Text = "Consultar";
            this.Btn_busquedaCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_busquedaCotizacion.UseVisualStyleBackColor = false;
            this.Btn_busquedaCotizacion.Click += new System.EventHandler(this.Btn_busquedaCotizacion_Click);
            // 
            // Lbl_reservacion
            // 
            this.Lbl_reservacion.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_reservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_reservacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_reservacion.Location = new System.Drawing.Point(196, 7);
            this.Lbl_reservacion.Name = "Lbl_reservacion";
            this.Lbl_reservacion.Size = new System.Drawing.Size(106, 28);
            this.Lbl_reservacion.TabIndex = 19;
            // 
            // Lbl_idCotizacion
            // 
            this.Lbl_idCotizacion.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_idCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_idCotizacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lbl_idCotizacion.Location = new System.Drawing.Point(196, 56);
            this.Lbl_idCotizacion.Name = "Lbl_idCotizacion";
            this.Lbl_idCotizacion.Size = new System.Drawing.Size(106, 25);
            this.Lbl_idCotizacion.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Dtp_FecaEntrada);
            this.panel2.Controls.Add(this.Dtp_FecaSalida);
            this.panel2.Controls.Add(this.Btn_consultarPiloto);
            this.panel2.Controls.Add(this.Btn_consultarVehiculo);
            this.panel2.Controls.Add(this.Lbl_idVehiculo);
            this.panel2.Controls.Add(this.Lbl_vehiculo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Lbl_idPiloto);
            this.panel2.Controls.Add(this.Lbl_piloto);
            this.panel2.Controls.Add(this.Lbl_fechaSalida);
            this.panel2.Location = new System.Drawing.Point(519, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(401, 188);
            this.panel2.TabIndex = 52;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Dtp_FecaEntrada
            // 
            this.Dtp_FecaEntrada.CustomFormat = "yyyy-MM-dd";
            this.Dtp_FecaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_FecaEntrada.Location = new System.Drawing.Point(196, 147);
            this.Dtp_FecaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_FecaEntrada.Name = "Dtp_FecaEntrada";
            this.Dtp_FecaEntrada.Size = new System.Drawing.Size(111, 30);
            this.Dtp_FecaEntrada.TabIndex = 110;
            this.Dtp_FecaEntrada.Value = new System.DateTime(2019, 7, 31, 0, 0, 0, 0);
            this.Dtp_FecaEntrada.ValueChanged += new System.EventHandler(this.Dtp_FecaEntrada_ValueChanged);
            // 
            // Dtp_FecaSalida
            // 
            this.Dtp_FecaSalida.CustomFormat = "yyyy-MM-dd";
            this.Dtp_FecaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_FecaSalida.Location = new System.Drawing.Point(196, 104);
            this.Dtp_FecaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_FecaSalida.Name = "Dtp_FecaSalida";
            this.Dtp_FecaSalida.Size = new System.Drawing.Size(111, 30);
            this.Dtp_FecaSalida.TabIndex = 109;
            this.Dtp_FecaSalida.Value = new System.DateTime(2019, 7, 31, 0, 0, 0, 0);
            this.Dtp_FecaSalida.ValueChanged += new System.EventHandler(this.Dtp_FecaSalida_ValueChanged);
            // 
            // Btn_consultarPiloto
            // 
            this.Btn_consultarPiloto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultarPiloto.FlatAppearance.BorderSize = 3;
            this.Btn_consultarPiloto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultarPiloto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultarPiloto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultarPiloto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultarPiloto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultarPiloto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultarPiloto.Image")));
            this.Btn_consultarPiloto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultarPiloto.Location = new System.Drawing.Point(334, 51);
            this.Btn_consultarPiloto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_consultarPiloto.Name = "Btn_consultarPiloto";
            this.Btn_consultarPiloto.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultarPiloto.TabIndex = 60;
            this.Btn_consultarPiloto.Text = "Consultar";
            this.Btn_consultarPiloto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultarPiloto.UseVisualStyleBackColor = false;
            this.Btn_consultarPiloto.Click += new System.EventHandler(this.Btn_consultarPiloto_Click);
            // 
            // Btn_consultarVehiculo
            // 
            this.Btn_consultarVehiculo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultarVehiculo.FlatAppearance.BorderSize = 3;
            this.Btn_consultarVehiculo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultarVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultarVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultarVehiculo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultarVehiculo.Image")));
            this.Btn_consultarVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultarVehiculo.Location = new System.Drawing.Point(334, 4);
            this.Btn_consultarVehiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_consultarVehiculo.Name = "Btn_consultarVehiculo";
            this.Btn_consultarVehiculo.Size = new System.Drawing.Size(40, 40);
            this.Btn_consultarVehiculo.TabIndex = 59;
            this.Btn_consultarVehiculo.Text = "Consultar";
            this.Btn_consultarVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultarVehiculo.UseVisualStyleBackColor = false;
            this.Btn_consultarVehiculo.Click += new System.EventHandler(this.Btn_consultarVehiculo_Click);
            // 
            // Btn_reservar
            // 
            this.Btn_reservar.FlatAppearance.BorderSize = 3;
            this.Btn_reservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_reservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_reservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reservar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reservar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reservar.Image")));
            this.Btn_reservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reservar.Location = new System.Drawing.Point(970, 420);
            this.Btn_reservar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_reservar.Name = "Btn_reservar";
            this.Btn_reservar.Size = new System.Drawing.Size(176, 44);
            this.Btn_reservar.TabIndex = 32;
            this.Btn_reservar.Text = "Reservar";
            this.Btn_reservar.UseVisualStyleBackColor = true;
            this.Btn_reservar.Click += new System.EventHandler(this.Btn_reservar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.FlatAppearance.BorderSize = 3;
            this.Btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_eliminar.Location = new System.Drawing.Point(970, 351);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(176, 44);
            this.Btn_eliminar.TabIndex = 31;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Frm_reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_detalle);
            this.Controls.Add(this.Btn_reservar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Dgv_detalleFactura);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_reservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_reservacion";
            this.Load += new System.EventHandler(this.Frm_reservacion_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_reservar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DataGridView Dgv_detalleFactura;
        private System.Windows.Forms.Label Lbl_nombCliente;
        private System.Windows.Forms.Label Lbl_nomCliente;
        private System.Windows.Forms.Label Lbl_idcoti;
        private System.Windows.Forms.Label Lbl_idReservacion;
        private System.Windows.Forms.Label Lbl_metodo;
        private System.Windows.Forms.Label Lbl_metodoPago;
        private System.Windows.Forms.Label Lbl_fechaSalida;
        private System.Windows.Forms.Label Lbl_piloto;
        private System.Windows.Forms.Label Lbl_idPiloto;
        private System.Windows.Forms.Label Lbl_vehiculo;
        private System.Windows.Forms.Label Lbl_idVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_detalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_busquedaCotizacion;
        private System.Windows.Forms.Button Btn_consultarPiloto;
        private System.Windows.Forms.Button Btn_consultarVehiculo;
        private System.Windows.Forms.Label Lbl_reservacion;
        private System.Windows.Forms.Label Lbl_idCotizacion;
        private System.Windows.Forms.DateTimePicker Dtp_FecaEntrada;
        private System.Windows.Forms.DateTimePicker Dtp_FecaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarTuristico;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}