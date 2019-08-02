namespace Prototipo_Agencia_Turismo.Cotizacion
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
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Pnl_Detalle = new System.Windows.Forms.Panel();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Grb_Hotel = new System.Windows.Forms.GroupBox();
            this.Txt_noHabitacion = new System.Windows.Forms.TextBox();
            this.Txt_habitacion = new System.Windows.Forms.TextBox();
            this.Txt_lugarHotel = new System.Windows.Forms.TextBox();
            this.Btn_consultaHabitación = new System.Windows.Forms.Button();
            this.Btn_consultaHotel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Habitacion = new System.Windows.Forms.Label();
            this.Lbl_Hotel = new System.Windows.Forms.Label();
            this.Grb_Restaurante = new System.Windows.Forms.GroupBox();
            this.Txt_menu = new System.Windows.Forms.TextBox();
            this.Txt_lugarRestaurante = new System.Windows.Forms.TextBox();
            this.Btn_consultaRestaurante = new System.Windows.Forms.Button();
            this.Lbl_Restaurante = new System.Windows.Forms.Label();
            this.Lbl_Menu = new System.Windows.Forms.Label();
            this.Grb_LugarT = new System.Windows.Forms.GroupBox();
            this.Txt_lugarTuristico = new System.Windows.Forms.TextBox();
            this.Btn_consultaLugarTuristico = new System.Windows.Forms.Button();
            this.Lbl_LugarT = new System.Windows.Forms.Label();
            this.Dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.codHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLugarTuristico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grpbx_encabezado = new System.Windows.Forms.GroupBox();
            this.Lbl_fechaEmision = new System.Windows.Forms.Label();
            this.Txt_codigoCliente = new System.Windows.Forms.TextBox();
            this.Lbl_codCliente = new System.Windows.Forms.Label();
            this.CB_Pasajero = new System.Windows.Forms.ComboBox();
            this.Lbl_pasajeros = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Txt_IdEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Txt_cliente = new System.Windows.Forms.TextBox();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.Rbtn_cotizacion = new System.Windows.Forms.RadioButton();
            this.Rbtn_facturacion = new System.Windows.Forms.RadioButton();
            this.Pnl_principal.SuspendLayout();
            this.Pnl_Detalle.SuspendLayout();
            this.Grb_Hotel.SuspendLayout();
            this.Grb_Restaurante.SuspendLayout();
            this.Grb_LugarT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).BeginInit();
            this.Grpbx_encabezado.SuspendLayout();
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
            this.Pnl_principal.TabIndex = 1;
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
            this.Lbl_titulo.Size = new System.Drawing.Size(128, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "FACTURACIÓN";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Enabled = false;
            this.Lbl_Total.Location = new System.Drawing.Point(776, 350);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(80, 22);
            this.Lbl_Total.TabIndex = 56;
            this.Lbl_Total.Text = "Total Q.";
            this.Lbl_Total.Visible = false;
            // 
            // Pnl_Detalle
            // 
            this.Pnl_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Detalle.Controls.Add(this.Lbl_resultado);
            this.Pnl_Detalle.Controls.Add(this.Grb_Hotel);
            this.Pnl_Detalle.Controls.Add(this.Grb_Restaurante);
            this.Pnl_Detalle.Controls.Add(this.Grb_LugarT);
            this.Pnl_Detalle.Controls.Add(this.Lbl_Total);
            this.Pnl_Detalle.Controls.Add(this.Dgv_detalleFactura);
            this.Pnl_Detalle.Location = new System.Drawing.Point(0, 244);
            this.Pnl_Detalle.Name = "Pnl_Detalle";
            this.Pnl_Detalle.Size = new System.Drawing.Size(1180, 384);
            this.Pnl_Detalle.TabIndex = 3;
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.Location = new System.Drawing.Point(901, 350);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(57, 22);
            this.Lbl_resultado.TabIndex = 77;
            this.Lbl_resultado.Text = "valor";
            // 
            // Grb_Hotel
            // 
            this.Grb_Hotel.Controls.Add(this.Txt_noHabitacion);
            this.Grb_Hotel.Controls.Add(this.Txt_habitacion);
            this.Grb_Hotel.Controls.Add(this.Txt_lugarHotel);
            this.Grb_Hotel.Controls.Add(this.Btn_consultaHabitación);
            this.Grb_Hotel.Controls.Add(this.Btn_consultaHotel);
            this.Grb_Hotel.Controls.Add(this.label2);
            this.Grb_Hotel.Controls.Add(this.Lbl_Habitacion);
            this.Grb_Hotel.Controls.Add(this.Lbl_Hotel);
            this.Grb_Hotel.Location = new System.Drawing.Point(27, 8);
            this.Grb_Hotel.Name = "Grb_Hotel";
            this.Grb_Hotel.Size = new System.Drawing.Size(467, 100);
            this.Grb_Hotel.TabIndex = 76;
            this.Grb_Hotel.TabStop = false;
            this.Grb_Hotel.Text = "Hotel";
            // 
            // Txt_noHabitacion
            // 
            this.Txt_noHabitacion.Enabled = false;
            this.Txt_noHabitacion.Location = new System.Drawing.Point(425, 64);
            this.Txt_noHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_noHabitacion.Name = "Txt_noHabitacion";
            this.Txt_noHabitacion.Size = new System.Drawing.Size(35, 30);
            this.Txt_noHabitacion.TabIndex = 67;
            this.Txt_noHabitacion.Visible = false;
            // 
            // Txt_habitacion
            // 
            this.Txt_habitacion.Enabled = false;
            this.Txt_habitacion.Location = new System.Drawing.Point(142, 59);
            this.Txt_habitacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_habitacion.Name = "Txt_habitacion";
            this.Txt_habitacion.Size = new System.Drawing.Size(116, 30);
            this.Txt_habitacion.TabIndex = 66;
            this.Txt_habitacion.Visible = false;
            // 
            // Txt_lugarHotel
            // 
            this.Txt_lugarHotel.Enabled = false;
            this.Txt_lugarHotel.Location = new System.Drawing.Point(94, 18);
            this.Txt_lugarHotel.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_lugarHotel.Name = "Txt_lugarHotel";
            this.Txt_lugarHotel.Size = new System.Drawing.Size(116, 30);
            this.Txt_lugarHotel.TabIndex = 65;
            this.Txt_lugarHotel.Visible = false;
            // 
            // Btn_consultaHabitación
            // 
            this.Btn_consultaHabitación.Location = new System.Drawing.Point(375, 11);
            this.Btn_consultaHabitación.Name = "Btn_consultaHabitación";
            this.Btn_consultaHabitación.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaHabitación.TabIndex = 64;
            this.Btn_consultaHabitación.Text = "...";
            this.Btn_consultaHabitación.UseVisualStyleBackColor = true;
            // 
            // Btn_consultaHotel
            // 
            this.Btn_consultaHotel.Location = new System.Drawing.Point(280, 11);
            this.Btn_consultaHotel.Name = "Btn_consultaHotel";
            this.Btn_consultaHotel.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaHotel.TabIndex = 63;
            this.Btn_consultaHotel.Text = "...";
            this.Btn_consultaHotel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(258, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "No. Habitaciones";
            this.label2.Visible = false;
            // 
            // Lbl_Habitacion
            // 
            this.Lbl_Habitacion.AutoSize = true;
            this.Lbl_Habitacion.Enabled = false;
            this.Lbl_Habitacion.Location = new System.Drawing.Point(23, 67);
            this.Lbl_Habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Habitacion.Name = "Lbl_Habitacion";
            this.Lbl_Habitacion.Size = new System.Drawing.Size(111, 22);
            this.Lbl_Habitacion.TabIndex = 61;
            this.Lbl_Habitacion.Text = "Habitacion";
            this.Lbl_Habitacion.Visible = false;
            // 
            // Lbl_Hotel
            // 
            this.Lbl_Hotel.AutoSize = true;
            this.Lbl_Hotel.Enabled = false;
            this.Lbl_Hotel.Location = new System.Drawing.Point(23, 25);
            this.Lbl_Hotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Hotel.Name = "Lbl_Hotel";
            this.Lbl_Hotel.Size = new System.Drawing.Size(63, 22);
            this.Lbl_Hotel.TabIndex = 59;
            this.Lbl_Hotel.Text = "Lugar";
            this.Lbl_Hotel.Visible = false;
            // 
            // Grb_Restaurante
            // 
            this.Grb_Restaurante.Controls.Add(this.Txt_menu);
            this.Grb_Restaurante.Controls.Add(this.Txt_lugarRestaurante);
            this.Grb_Restaurante.Controls.Add(this.Btn_consultaRestaurante);
            this.Grb_Restaurante.Controls.Add(this.Lbl_Restaurante);
            this.Grb_Restaurante.Controls.Add(this.Lbl_Menu);
            this.Grb_Restaurante.Location = new System.Drawing.Point(500, 8);
            this.Grb_Restaurante.Name = "Grb_Restaurante";
            this.Grb_Restaurante.Size = new System.Drawing.Size(326, 100);
            this.Grb_Restaurante.TabIndex = 75;
            this.Grb_Restaurante.TabStop = false;
            this.Grb_Restaurante.Text = "Restaurante";
            // 
            // Txt_menu
            // 
            this.Txt_menu.Enabled = false;
            this.Txt_menu.Location = new System.Drawing.Point(84, 65);
            this.Txt_menu.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_menu.Name = "Txt_menu";
            this.Txt_menu.Size = new System.Drawing.Size(164, 30);
            this.Txt_menu.TabIndex = 81;
            this.Txt_menu.Visible = false;
            // 
            // Txt_lugarRestaurante
            // 
            this.Txt_lugarRestaurante.Enabled = false;
            this.Txt_lugarRestaurante.Location = new System.Drawing.Point(84, 27);
            this.Txt_lugarRestaurante.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_lugarRestaurante.Name = "Txt_lugarRestaurante";
            this.Txt_lugarRestaurante.Size = new System.Drawing.Size(164, 30);
            this.Txt_lugarRestaurante.TabIndex = 80;
            this.Txt_lugarRestaurante.Visible = false;
            // 
            // Btn_consultaRestaurante
            // 
            this.Btn_consultaRestaurante.Location = new System.Drawing.Point(255, 18);
            this.Btn_consultaRestaurante.Name = "Btn_consultaRestaurante";
            this.Btn_consultaRestaurante.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaRestaurante.TabIndex = 79;
            this.Btn_consultaRestaurante.Text = "...";
            this.Btn_consultaRestaurante.UseVisualStyleBackColor = true;
            // 
            // Lbl_Restaurante
            // 
            this.Lbl_Restaurante.AutoSize = true;
            this.Lbl_Restaurante.Enabled = false;
            this.Lbl_Restaurante.Location = new System.Drawing.Point(7, 33);
            this.Lbl_Restaurante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Restaurante.Name = "Lbl_Restaurante";
            this.Lbl_Restaurante.Size = new System.Drawing.Size(63, 22);
            this.Lbl_Restaurante.TabIndex = 63;
            this.Lbl_Restaurante.Text = "Lugar";
            this.Lbl_Restaurante.Visible = false;
            // 
            // Lbl_Menu
            // 
            this.Lbl_Menu.AutoSize = true;
            this.Lbl_Menu.Enabled = false;
            this.Lbl_Menu.Location = new System.Drawing.Point(7, 68);
            this.Lbl_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Menu.Name = "Lbl_Menu";
            this.Lbl_Menu.Size = new System.Drawing.Size(63, 22);
            this.Lbl_Menu.TabIndex = 65;
            this.Lbl_Menu.Text = "Menu";
            this.Lbl_Menu.Visible = false;
            // 
            // Grb_LugarT
            // 
            this.Grb_LugarT.Controls.Add(this.Txt_lugarTuristico);
            this.Grb_LugarT.Controls.Add(this.Btn_consultaLugarTuristico);
            this.Grb_LugarT.Controls.Add(this.Lbl_LugarT);
            this.Grb_LugarT.Location = new System.Drawing.Point(832, 12);
            this.Grb_LugarT.Name = "Grb_LugarT";
            this.Grb_LugarT.Size = new System.Drawing.Size(343, 90);
            this.Grb_LugarT.TabIndex = 59;
            this.Grb_LugarT.TabStop = false;
            this.Grb_LugarT.Text = "Lugar Turistico";
            // 
            // Txt_lugarTuristico
            // 
            this.Txt_lugarTuristico.Enabled = false;
            this.Txt_lugarTuristico.Location = new System.Drawing.Point(108, 43);
            this.Txt_lugarTuristico.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_lugarTuristico.Name = "Txt_lugarTuristico";
            this.Txt_lugarTuristico.Size = new System.Drawing.Size(116, 30);
            this.Txt_lugarTuristico.TabIndex = 79;
            this.Txt_lugarTuristico.Visible = false;
            // 
            // Btn_consultaLugarTuristico
            // 
            this.Btn_consultaLugarTuristico.Location = new System.Drawing.Point(260, 17);
            this.Btn_consultaLugarTuristico.Name = "Btn_consultaLugarTuristico";
            this.Btn_consultaLugarTuristico.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaLugarTuristico.TabIndex = 78;
            this.Btn_consultaLugarTuristico.Text = "...";
            this.Btn_consultaLugarTuristico.UseVisualStyleBackColor = true;
            // 
            // Lbl_LugarT
            // 
            this.Lbl_LugarT.AutoSize = true;
            this.Lbl_LugarT.Enabled = false;
            this.Lbl_LugarT.Location = new System.Drawing.Point(7, 46);
            this.Lbl_LugarT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_LugarT.Name = "Lbl_LugarT";
            this.Lbl_LugarT.Size = new System.Drawing.Size(84, 22);
            this.Lbl_LugarT.TabIndex = 65;
            this.Lbl_LugarT.Text = "Nombre";
            this.Lbl_LugarT.Visible = false;
            // 
            // Dgv_detalleFactura
            // 
            this.Dgv_detalleFactura.AllowUserToAddRows = false;
            this.Dgv_detalleFactura.AllowUserToDeleteRows = false;
            this.Dgv_detalleFactura.AllowUserToResizeColumns = false;
            this.Dgv_detalleFactura.AllowUserToResizeRows = false;
            this.Dgv_detalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_detalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codHabitacion,
            this.codMenu,
            this.codLugarTuristico,
            this.cantHabitaciones,
            this.precio,
            this.importe});
            this.Dgv_detalleFactura.Location = new System.Drawing.Point(27, 114);
            this.Dgv_detalleFactura.Name = "Dgv_detalleFactura";
            this.Dgv_detalleFactura.RowHeadersVisible = false;
            this.Dgv_detalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_detalleFactura.Size = new System.Drawing.Size(931, 233);
            this.Dgv_detalleFactura.TabIndex = 0;
            // 
            // codHabitacion
            // 
            this.codHabitacion.HeaderText = "Código de Habitación";
            this.codHabitacion.Name = "codHabitacion";
            // 
            // codMenu
            // 
            this.codMenu.HeaderText = "Código de Menú";
            this.codMenu.Name = "codMenu";
            // 
            // codLugarTuristico
            // 
            this.codLugarTuristico.HeaderText = "Código Lugar Turístico";
            this.codLugarTuristico.Name = "codLugarTuristico";
            // 
            // cantHabitaciones
            // 
            this.cantHabitaciones.HeaderText = "Cantidad de Habitaciones";
            this.cantHabitaciones.Name = "cantHabitaciones";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // Grpbx_encabezado
            // 
            this.Grpbx_encabezado.Controls.Add(this.Lbl_fechaEmision);
            this.Grpbx_encabezado.Controls.Add(this.Txt_codigoCliente);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_codCliente);
            this.Grpbx_encabezado.Controls.Add(this.CB_Pasajero);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_pasajeros);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_fecha);
            this.Grpbx_encabezado.Controls.Add(this.Txt_IdEmpleado);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_Empleado);
            this.Grpbx_encabezado.Controls.Add(this.Txt_cliente);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_cliente);
            this.Grpbx_encabezado.Location = new System.Drawing.Point(29, 46);
            this.Grpbx_encabezado.Name = "Grpbx_encabezado";
            this.Grpbx_encabezado.Size = new System.Drawing.Size(1017, 192);
            this.Grpbx_encabezado.TabIndex = 4;
            this.Grpbx_encabezado.TabStop = false;
            this.Grpbx_encabezado.Text = "Encabezado";
            // 
            // Lbl_fechaEmision
            // 
            this.Lbl_fechaEmision.AutoSize = true;
            this.Lbl_fechaEmision.Location = new System.Drawing.Point(196, 148);
            this.Lbl_fechaEmision.Name = "Lbl_fechaEmision";
            this.Lbl_fechaEmision.Size = new System.Drawing.Size(130, 22);
            this.Lbl_fechaEmision.TabIndex = 73;
            this.Lbl_fechaEmision.Text = "yyyy/mm/dd";
            // 
            // Txt_codigoCliente
            // 
            this.Txt_codigoCliente.Enabled = false;
            this.Txt_codigoCliente.Location = new System.Drawing.Point(200, 68);
            this.Txt_codigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codigoCliente.Name = "Txt_codigoCliente";
            this.Txt_codigoCliente.Size = new System.Drawing.Size(116, 30);
            this.Txt_codigoCliente.TabIndex = 72;
            // 
            // Lbl_codCliente
            // 
            this.Lbl_codCliente.AutoSize = true;
            this.Lbl_codCliente.Enabled = false;
            this.Lbl_codCliente.Location = new System.Drawing.Point(22, 73);
            this.Lbl_codCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codCliente.Name = "Lbl_codCliente";
            this.Lbl_codCliente.Size = new System.Drawing.Size(149, 22);
            this.Lbl_codCliente.TabIndex = 71;
            this.Lbl_codCliente.Text = "Código cliente:";
            // 
            // CB_Pasajero
            // 
            this.CB_Pasajero.FormattingEnabled = true;
            this.CB_Pasajero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CB_Pasajero.Location = new System.Drawing.Point(577, 118);
            this.CB_Pasajero.Name = "CB_Pasajero";
            this.CB_Pasajero.Size = new System.Drawing.Size(121, 30);
            this.CB_Pasajero.TabIndex = 70;
            // 
            // Lbl_pasajeros
            // 
            this.Lbl_pasajeros.AutoSize = true;
            this.Lbl_pasajeros.Enabled = false;
            this.Lbl_pasajeros.Location = new System.Drawing.Point(447, 121);
            this.Lbl_pasajeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_pasajeros.Name = "Lbl_pasajeros";
            this.Lbl_pasajeros.Size = new System.Drawing.Size(130, 22);
            this.Lbl_pasajeros.TabIndex = 69;
            this.Lbl_pasajeros.Text = "No. Pasajeros";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Enabled = false;
            this.Lbl_fecha.Location = new System.Drawing.Point(69, 148);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(68, 22);
            this.Lbl_fecha.TabIndex = 68;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Txt_IdEmpleado
            // 
            this.Txt_IdEmpleado.Enabled = false;
            this.Txt_IdEmpleado.Location = new System.Drawing.Point(200, 27);
            this.Txt_IdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IdEmpleado.Name = "Txt_IdEmpleado";
            this.Txt_IdEmpleado.Size = new System.Drawing.Size(222, 30);
            this.Txt_IdEmpleado.TabIndex = 67;
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Enabled = false;
            this.Lbl_Empleado.Location = new System.Drawing.Point(34, 33);
            this.Lbl_Empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(113, 22);
            this.Lbl_Empleado.TabIndex = 66;
            this.Lbl_Empleado.Text = "Le atiende:";
            // 
            // Txt_cliente
            // 
            this.Txt_cliente.Enabled = false;
            this.Txt_cliente.Location = new System.Drawing.Point(200, 106);
            this.Txt_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_cliente.Name = "Txt_cliente";
            this.Txt_cliente.Size = new System.Drawing.Size(173, 30);
            this.Txt_cliente.TabIndex = 65;
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Enabled = false;
            this.Lbl_cliente.Location = new System.Drawing.Point(63, 109);
            this.Lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.Size = new System.Drawing.Size(74, 22);
            this.Lbl_cliente.TabIndex = 64;
            this.Lbl_cliente.Text = "Cliente";
            // 
            // Rbtn_cotizacion
            // 
            this.Rbtn_cotizacion.AutoSize = true;
            this.Rbtn_cotizacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_cotizacion.Location = new System.Drawing.Point(1050, 143);
            this.Rbtn_cotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rbtn_cotizacion.Name = "Rbtn_cotizacion";
            this.Rbtn_cotizacion.Size = new System.Drawing.Size(117, 23);
            this.Rbtn_cotizacion.TabIndex = 75;
            this.Rbtn_cotizacion.TabStop = true;
            this.Rbtn_cotizacion.Text = "Cotización";
            this.Rbtn_cotizacion.UseVisualStyleBackColor = true;
            this.Rbtn_cotizacion.CheckedChanged += new System.EventHandler(this.Rbtn_cotizacion_CheckedChanged);
            // 
            // Rbtn_facturacion
            // 
            this.Rbtn_facturacion.AutoSize = true;
            this.Rbtn_facturacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_facturacion.Location = new System.Drawing.Point(1050, 94);
            this.Rbtn_facturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rbtn_facturacion.Name = "Rbtn_facturacion";
            this.Rbtn_facturacion.Size = new System.Drawing.Size(126, 23);
            this.Rbtn_facturacion.TabIndex = 76;
            this.Rbtn_facturacion.TabStop = true;
            this.Rbtn_facturacion.Text = "Facturación";
            this.Rbtn_facturacion.UseVisualStyleBackColor = true;
            this.Rbtn_facturacion.CheckedChanged += new System.EventHandler(this.Rbtn_facturacion_CheckedChanged);
            // 
            // Frm_facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Rbtn_facturacion);
            this.Controls.Add(this.Rbtn_cotizacion);
            this.Controls.Add(this.Grpbx_encabezado);
            this.Controls.Add(this.Pnl_Detalle);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cotizacion";
            this.Load += new System.EventHandler(this.Frm_facturacion_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.Pnl_Detalle.ResumeLayout(false);
            this.Pnl_Detalle.PerformLayout();
            this.Grb_Hotel.ResumeLayout(false);
            this.Grb_Hotel.PerformLayout();
            this.Grb_Restaurante.ResumeLayout(false);
            this.Grb_Restaurante.PerformLayout();
            this.Grb_LugarT.ResumeLayout(false);
            this.Grb_LugarT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).EndInit();
            this.Grpbx_encabezado.ResumeLayout(false);
            this.Grpbx_encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_Detalle;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.DataGridView Dgv_detalleFactura;
        private System.Windows.Forms.Label Lbl_LugarT;
        private System.Windows.Forms.Label Lbl_Restaurante;
        private System.Windows.Forms.Label Lbl_Menu;
        private System.Windows.Forms.Label Lbl_Hotel;
        private System.Windows.Forms.Label Lbl_Habitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Grb_Hotel;
        private System.Windows.Forms.GroupBox Grb_Restaurante;
        private System.Windows.Forms.GroupBox Grb_LugarT;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Button Btn_consultaHabitación;
        private System.Windows.Forms.Button Btn_consultaHotel;
        private System.Windows.Forms.Button Btn_consultaRestaurante;
        private System.Windows.Forms.Button Btn_consultaLugarTuristico;
        private System.Windows.Forms.TextBox Txt_noHabitacion;
        private System.Windows.Forms.TextBox Txt_habitacion;
        private System.Windows.Forms.TextBox Txt_lugarHotel;
        private System.Windows.Forms.TextBox Txt_menu;
        private System.Windows.Forms.TextBox Txt_lugarRestaurante;
        private System.Windows.Forms.TextBox Txt_lugarTuristico;
        private System.Windows.Forms.DataGridViewTextBoxColumn codHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLugarTuristico;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.GroupBox Grpbx_encabezado;
        private System.Windows.Forms.Label Lbl_fechaEmision;
        private System.Windows.Forms.TextBox Txt_codigoCliente;
        private System.Windows.Forms.Label Lbl_codCliente;
        private System.Windows.Forms.ComboBox CB_Pasajero;
        private System.Windows.Forms.Label Lbl_pasajeros;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.TextBox Txt_IdEmpleado;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.TextBox Txt_cliente;
        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.RadioButton Rbtn_cotizacion;
        private System.Windows.Forms.RadioButton Rbtn_facturacion;
    }
}