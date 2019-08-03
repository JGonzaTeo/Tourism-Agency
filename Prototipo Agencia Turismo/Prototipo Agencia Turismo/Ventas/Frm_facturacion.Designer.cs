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
            this.Btn_facturar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_colocar = new System.Windows.Forms.Button();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Grb_Restaurante = new System.Windows.Forms.GroupBox();
            this.Txt_menu = new System.Windows.Forms.TextBox();
            this.Txt_lugarRestaurante = new System.Windows.Forms.TextBox();
            this.Btn_consultaRestaurante = new System.Windows.Forms.Button();
            this.Lbl_restaurante = new System.Windows.Forms.Label();
            this.Lbl_menu = new System.Windows.Forms.Label();
            this.Grb_LugarT = new System.Windows.Forms.GroupBox();
            this.Txt_lugarTuristico = new System.Windows.Forms.TextBox();
            this.Btn_consultaLugarTuristico = new System.Windows.Forms.Button();
            this.Lbl_LugarT = new System.Windows.Forms.Label();
            this.Dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.codServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grb_Hotel = new System.Windows.Forms.GroupBox();
            this.Txt_noHabitacion = new System.Windows.Forms.TextBox();
            this.Txt_habitacion = new System.Windows.Forms.TextBox();
            this.Txt_lugarHotel = new System.Windows.Forms.TextBox();
            this.Btn_consultaHabitación = new System.Windows.Forms.Button();
            this.Btn_consultaHotel = new System.Windows.Forms.Button();
            this.Lbl_noHabitaciones = new System.Windows.Forms.Label();
            this.Lbl_habitacion = new System.Windows.Forms.Label();
            this.Lbl_hotel = new System.Windows.Forms.Label();
            this.Grpbx_encabezado = new System.Windows.Forms.GroupBox();
            this.Btn_consultaCliente = new System.Windows.Forms.Button();
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
            this.Lbl_precioHabitacion = new System.Windows.Forms.Label();
            this.precioMenu = new System.Windows.Forms.Label();
            this.precioLugarT = new System.Windows.Forms.Label();
            this.Pnl_principal.SuspendLayout();
            this.Pnl_Detalle.SuspendLayout();
            this.Grb_Restaurante.SuspendLayout();
            this.Grb_LugarT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).BeginInit();
            this.Grb_Hotel.SuspendLayout();
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
            this.Lbl_Total.Location = new System.Drawing.Point(747, 350);
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
            this.Pnl_Detalle.Controls.Add(this.Btn_facturar);
            this.Pnl_Detalle.Controls.Add(this.Btn_eliminar);
            this.Pnl_Detalle.Controls.Add(this.Btn_colocar);
            this.Pnl_Detalle.Controls.Add(this.Lbl_resultado);
            this.Pnl_Detalle.Controls.Add(this.Grb_Restaurante);
            this.Pnl_Detalle.Controls.Add(this.Grb_LugarT);
            this.Pnl_Detalle.Controls.Add(this.Lbl_Total);
            this.Pnl_Detalle.Controls.Add(this.Dgv_detalleFactura);
            this.Pnl_Detalle.Location = new System.Drawing.Point(0, 244);
            this.Pnl_Detalle.Name = "Pnl_Detalle";
            this.Pnl_Detalle.Size = new System.Drawing.Size(1180, 384);
            this.Pnl_Detalle.TabIndex = 3;
            // 
            // Btn_facturar
            // 
            this.Btn_facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_facturar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_facturar.Location = new System.Drawing.Point(964, 268);
            this.Btn_facturar.Name = "Btn_facturar";
            this.Btn_facturar.Size = new System.Drawing.Size(202, 44);
            this.Btn_facturar.TabIndex = 80;
            this.Btn_facturar.Text = "Facturar";
            this.Btn_facturar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(964, 200);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(202, 44);
            this.Btn_eliminar.TabIndex = 79;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_colocar
            // 
            this.Btn_colocar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_colocar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_colocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_colocar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_colocar.Location = new System.Drawing.Point(964, 136);
            this.Btn_colocar.Name = "Btn_colocar";
            this.Btn_colocar.Size = new System.Drawing.Size(202, 44);
            this.Btn_colocar.TabIndex = 78;
            this.Btn_colocar.Text = "Colocar";
            this.Btn_colocar.UseVisualStyleBackColor = true;
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Lbl_resultado.Location = new System.Drawing.Point(833, 350);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(115, 25);
            this.Lbl_resultado.TabIndex = 77;
            this.Lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grb_Restaurante
            // 
            this.Grb_Restaurante.Controls.Add(this.precioMenu);
            this.Grb_Restaurante.Controls.Add(this.Txt_menu);
            this.Grb_Restaurante.Controls.Add(this.Txt_lugarRestaurante);
            this.Grb_Restaurante.Controls.Add(this.Btn_consultaRestaurante);
            this.Grb_Restaurante.Controls.Add(this.Lbl_restaurante);
            this.Grb_Restaurante.Controls.Add(this.Lbl_menu);
            this.Grb_Restaurante.Location = new System.Drawing.Point(50, 12);
            this.Grb_Restaurante.Name = "Grb_Restaurante";
            this.Grb_Restaurante.Size = new System.Drawing.Size(520, 100);
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
            // 
            // Txt_lugarRestaurante
            // 
            this.Txt_lugarRestaurante.Enabled = false;
            this.Txt_lugarRestaurante.Location = new System.Drawing.Point(84, 27);
            this.Txt_lugarRestaurante.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_lugarRestaurante.Name = "Txt_lugarRestaurante";
            this.Txt_lugarRestaurante.Size = new System.Drawing.Size(164, 30);
            this.Txt_lugarRestaurante.TabIndex = 80;
            // 
            // Btn_consultaRestaurante
            // 
            this.Btn_consultaRestaurante.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaRestaurante.Image")));
            this.Btn_consultaRestaurante.Location = new System.Drawing.Point(439, 19);
            this.Btn_consultaRestaurante.Name = "Btn_consultaRestaurante";
            this.Btn_consultaRestaurante.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaRestaurante.TabIndex = 79;
            this.Btn_consultaRestaurante.UseVisualStyleBackColor = true;
            this.Btn_consultaRestaurante.Click += new System.EventHandler(this.Btn_consultaRestaurante_Click);
            // 
            // Lbl_restaurante
            // 
            this.Lbl_restaurante.AutoSize = true;
            this.Lbl_restaurante.Location = new System.Drawing.Point(7, 33);
            this.Lbl_restaurante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_restaurante.Name = "Lbl_restaurante";
            this.Lbl_restaurante.Size = new System.Drawing.Size(63, 22);
            this.Lbl_restaurante.TabIndex = 63;
            this.Lbl_restaurante.Text = "Lugar";
            // 
            // Lbl_menu
            // 
            this.Lbl_menu.AutoSize = true;
            this.Lbl_menu.Location = new System.Drawing.Point(7, 68);
            this.Lbl_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_menu.Name = "Lbl_menu";
            this.Lbl_menu.Size = new System.Drawing.Size(63, 22);
            this.Lbl_menu.TabIndex = 65;
            this.Lbl_menu.Text = "Menu";
            // 
            // Grb_LugarT
            // 
            this.Grb_LugarT.Controls.Add(this.precioLugarT);
            this.Grb_LugarT.Controls.Add(this.Txt_lugarTuristico);
            this.Grb_LugarT.Controls.Add(this.Btn_consultaLugarTuristico);
            this.Grb_LugarT.Controls.Add(this.Lbl_LugarT);
            this.Grb_LugarT.Location = new System.Drawing.Point(611, 17);
            this.Grb_LugarT.Name = "Grb_LugarT";
            this.Grb_LugarT.Size = new System.Drawing.Size(414, 90);
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
            // 
            // Btn_consultaLugarTuristico
            // 
            this.Btn_consultaLugarTuristico.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaLugarTuristico.Image")));
            this.Btn_consultaLugarTuristico.Location = new System.Drawing.Point(333, 14);
            this.Btn_consultaLugarTuristico.Name = "Btn_consultaLugarTuristico";
            this.Btn_consultaLugarTuristico.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaLugarTuristico.TabIndex = 78;
            this.Btn_consultaLugarTuristico.UseVisualStyleBackColor = true;
            this.Btn_consultaLugarTuristico.Click += new System.EventHandler(this.Btn_consultaLugarTuristico_Click);
            // 
            // Lbl_LugarT
            // 
            this.Lbl_LugarT.AutoSize = true;
            this.Lbl_LugarT.Location = new System.Drawing.Point(7, 46);
            this.Lbl_LugarT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_LugarT.Name = "Lbl_LugarT";
            this.Lbl_LugarT.Size = new System.Drawing.Size(84, 22);
            this.Lbl_LugarT.TabIndex = 65;
            this.Lbl_LugarT.Text = "Nombre";
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
            this.codServicio,
            this.nombre,
            this.descripcion,
            this.precio,
            this.cantidad,
            this.importe});
            this.Dgv_detalleFactura.Location = new System.Drawing.Point(27, 114);
            this.Dgv_detalleFactura.Name = "Dgv_detalleFactura";
            this.Dgv_detalleFactura.RowHeadersVisible = false;
            this.Dgv_detalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_detalleFactura.Size = new System.Drawing.Size(931, 233);
            this.Dgv_detalleFactura.TabIndex = 0;
            // 
            // codServicio
            // 
            this.codServicio.HeaderText = "Código de Servicio";
            this.codServicio.Name = "codServicio";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // Grb_Hotel
            // 
            this.Grb_Hotel.Controls.Add(this.Lbl_precioHabitacion);
            this.Grb_Hotel.Controls.Add(this.Txt_noHabitacion);
            this.Grb_Hotel.Controls.Add(this.Txt_habitacion);
            this.Grb_Hotel.Controls.Add(this.Txt_lugarHotel);
            this.Grb_Hotel.Controls.Add(this.Btn_consultaHabitación);
            this.Grb_Hotel.Controls.Add(this.Btn_consultaHotel);
            this.Grb_Hotel.Controls.Add(this.Lbl_noHabitaciones);
            this.Grb_Hotel.Controls.Add(this.Lbl_habitacion);
            this.Grb_Hotel.Controls.Add(this.Lbl_hotel);
            this.Grb_Hotel.Location = new System.Drawing.Point(612, 46);
            this.Grb_Hotel.Name = "Grb_Hotel";
            this.Grb_Hotel.Size = new System.Drawing.Size(414, 192);
            this.Grb_Hotel.TabIndex = 76;
            this.Grb_Hotel.TabStop = false;
            this.Grb_Hotel.Text = "Hotel";
            // 
            // Txt_noHabitacion
            // 
            this.Txt_noHabitacion.Location = new System.Drawing.Point(181, 130);
            this.Txt_noHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_noHabitacion.Name = "Txt_noHabitacion";
            this.Txt_noHabitacion.Size = new System.Drawing.Size(35, 30);
            this.Txt_noHabitacion.TabIndex = 67;
            // 
            // Txt_habitacion
            // 
            this.Txt_habitacion.Enabled = false;
            this.Txt_habitacion.Location = new System.Drawing.Point(181, 89);
            this.Txt_habitacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_habitacion.Name = "Txt_habitacion";
            this.Txt_habitacion.Size = new System.Drawing.Size(116, 30);
            this.Txt_habitacion.TabIndex = 66;
            // 
            // Txt_lugarHotel
            // 
            this.Txt_lugarHotel.Enabled = false;
            this.Txt_lugarHotel.Location = new System.Drawing.Point(181, 45);
            this.Txt_lugarHotel.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_lugarHotel.Name = "Txt_lugarHotel";
            this.Txt_lugarHotel.Size = new System.Drawing.Size(116, 30);
            this.Txt_lugarHotel.TabIndex = 65;
            // 
            // Btn_consultaHabitación
            // 
            this.Btn_consultaHabitación.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaHabitación.Image")));
            this.Btn_consultaHabitación.Location = new System.Drawing.Point(321, 85);
            this.Btn_consultaHabitación.Name = "Btn_consultaHabitación";
            this.Btn_consultaHabitación.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaHabitación.TabIndex = 64;
            this.Btn_consultaHabitación.UseVisualStyleBackColor = true;
            this.Btn_consultaHabitación.Click += new System.EventHandler(this.Btn_consultaHabitación_Click);
            // 
            // Btn_consultaHotel
            // 
            this.Btn_consultaHotel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaHotel.Image")));
            this.Btn_consultaHotel.Location = new System.Drawing.Point(321, 39);
            this.Btn_consultaHotel.Name = "Btn_consultaHotel";
            this.Btn_consultaHotel.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaHotel.TabIndex = 63;
            this.Btn_consultaHotel.UseVisualStyleBackColor = true;
            this.Btn_consultaHotel.Click += new System.EventHandler(this.Btn_consultaHotel_Click);
            // 
            // Lbl_noHabitaciones
            // 
            this.Lbl_noHabitaciones.AutoSize = true;
            this.Lbl_noHabitaciones.Location = new System.Drawing.Point(7, 138);
            this.Lbl_noHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_noHabitaciones.Name = "Lbl_noHabitaciones";
            this.Lbl_noHabitaciones.Size = new System.Drawing.Size(166, 22);
            this.Lbl_noHabitaciones.TabIndex = 59;
            this.Lbl_noHabitaciones.Text = "No. Habitaciones";
            // 
            // Lbl_habitacion
            // 
            this.Lbl_habitacion.AutoSize = true;
            this.Lbl_habitacion.Location = new System.Drawing.Point(7, 97);
            this.Lbl_habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_habitacion.Name = "Lbl_habitacion";
            this.Lbl_habitacion.Size = new System.Drawing.Size(111, 22);
            this.Lbl_habitacion.TabIndex = 61;
            this.Lbl_habitacion.Text = "Habitacion";
            // 
            // Lbl_hotel
            // 
            this.Lbl_hotel.AutoSize = true;
            this.Lbl_hotel.Location = new System.Drawing.Point(7, 48);
            this.Lbl_hotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_hotel.Name = "Lbl_hotel";
            this.Lbl_hotel.Size = new System.Drawing.Size(63, 22);
            this.Lbl_hotel.TabIndex = 59;
            this.Lbl_hotel.Text = "Lugar";
            // 
            // Grpbx_encabezado
            // 
            this.Grpbx_encabezado.Controls.Add(this.Btn_consultaCliente);
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
            this.Grpbx_encabezado.Size = new System.Drawing.Size(563, 192);
            this.Grpbx_encabezado.TabIndex = 4;
            this.Grpbx_encabezado.TabStop = false;
            this.Grpbx_encabezado.Text = "Encabezado";
            // 
            // Btn_consultaCliente
            // 
            this.Btn_consultaCliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaCliente.Image")));
            this.Btn_consultaCliente.Location = new System.Drawing.Point(313, 59);
            this.Btn_consultaCliente.Name = "Btn_consultaCliente";
            this.Btn_consultaCliente.Size = new System.Drawing.Size(52, 40);
            this.Btn_consultaCliente.TabIndex = 74;
            this.Btn_consultaCliente.UseVisualStyleBackColor = true;
            this.Btn_consultaCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_fechaEmision
            // 
            this.Lbl_fechaEmision.AutoSize = true;
            this.Lbl_fechaEmision.Location = new System.Drawing.Point(171, 148);
            this.Lbl_fechaEmision.Name = "Lbl_fechaEmision";
            this.Lbl_fechaEmision.Size = new System.Drawing.Size(130, 22);
            this.Lbl_fechaEmision.TabIndex = 73;
            this.Lbl_fechaEmision.Text = "yyyy/mm/dd";
            // 
            // Txt_codigoCliente
            // 
            this.Txt_codigoCliente.Enabled = false;
            this.Txt_codigoCliente.Location = new System.Drawing.Point(175, 65);
            this.Txt_codigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codigoCliente.Name = "Txt_codigoCliente";
            this.Txt_codigoCliente.Size = new System.Drawing.Size(116, 30);
            this.Txt_codigoCliente.TabIndex = 72;
            // 
            // Lbl_codCliente
            // 
            this.Lbl_codCliente.AutoSize = true;
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
            this.CB_Pasajero.Location = new System.Drawing.Point(421, 48);
            this.CB_Pasajero.Name = "CB_Pasajero";
            this.CB_Pasajero.Size = new System.Drawing.Size(121, 30);
            this.CB_Pasajero.TabIndex = 70;
            // 
            // Lbl_pasajeros
            // 
            this.Lbl_pasajeros.AutoSize = true;
            this.Lbl_pasajeros.Location = new System.Drawing.Point(420, 22);
            this.Lbl_pasajeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_pasajeros.Name = "Lbl_pasajeros";
            this.Lbl_pasajeros.Size = new System.Drawing.Size(130, 22);
            this.Lbl_pasajeros.TabIndex = 69;
            this.Lbl_pasajeros.Text = "No. Pasajeros";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(22, 148);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(68, 22);
            this.Lbl_fecha.TabIndex = 68;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Txt_IdEmpleado
            // 
            this.Txt_IdEmpleado.Enabled = false;
            this.Txt_IdEmpleado.Location = new System.Drawing.Point(175, 22);
            this.Txt_IdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IdEmpleado.Name = "Txt_IdEmpleado";
            this.Txt_IdEmpleado.Size = new System.Drawing.Size(222, 30);
            this.Txt_IdEmpleado.TabIndex = 67;
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Location = new System.Drawing.Point(22, 30);
            this.Lbl_Empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(113, 22);
            this.Lbl_Empleado.TabIndex = 66;
            this.Lbl_Empleado.Text = "Le atiende:";
            // 
            // Txt_cliente
            // 
            this.Txt_cliente.Enabled = false;
            this.Txt_cliente.Location = new System.Drawing.Point(175, 106);
            this.Txt_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_cliente.Name = "Txt_cliente";
            this.Txt_cliente.Size = new System.Drawing.Size(173, 30);
            this.Txt_cliente.TabIndex = 65;
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Location = new System.Drawing.Point(22, 109);
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
            // Lbl_precioHabitacion
            // 
            this.Lbl_precioHabitacion.AutoSize = true;
            this.Lbl_precioHabitacion.Location = new System.Drawing.Point(301, 167);
            this.Lbl_precioHabitacion.Name = "Lbl_precioHabitacion";
            this.Lbl_precioHabitacion.Size = new System.Drawing.Size(107, 22);
            this.Lbl_precioHabitacion.TabIndex = 68;
            this.Lbl_precioHabitacion.Text = "precioHab";
            // 
            // precioMenu
            // 
            this.precioMenu.AutoSize = true;
            this.precioMenu.Location = new System.Drawing.Point(407, 73);
            this.precioMenu.Name = "precioMenu";
            this.precioMenu.Size = new System.Drawing.Size(121, 22);
            this.precioMenu.TabIndex = 82;
            this.precioMenu.Text = "precioMenu";
            // 
            // precioLugarT
            // 
            this.precioLugarT.AutoSize = true;
            this.precioLugarT.Location = new System.Drawing.Point(343, 65);
            this.precioLugarT.Name = "precioLugarT";
            this.precioLugarT.Size = new System.Drawing.Size(129, 22);
            this.precioLugarT.TabIndex = 83;
            this.precioLugarT.Text = "precioLugarT";
            // 
            // Frm_facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Rbtn_facturacion);
            this.Controls.Add(this.Grb_Hotel);
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
            this.Grb_Restaurante.ResumeLayout(false);
            this.Grb_Restaurante.PerformLayout();
            this.Grb_LugarT.ResumeLayout(false);
            this.Grb_LugarT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).EndInit();
            this.Grb_Hotel.ResumeLayout(false);
            this.Grb_Hotel.PerformLayout();
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
        private System.Windows.Forms.Label Lbl_restaurante;
        private System.Windows.Forms.Label Lbl_menu;
        private System.Windows.Forms.Label Lbl_hotel;
        private System.Windows.Forms.Label Lbl_habitacion;
        private System.Windows.Forms.Label Lbl_noHabitaciones;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button Btn_consultaCliente;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_colocar;
        private System.Windows.Forms.Button Btn_facturar;
        private System.Windows.Forms.Label precioMenu;
        private System.Windows.Forms.Label precioLugarT;
        private System.Windows.Forms.Label Lbl_precioHabitacion;
    }
}