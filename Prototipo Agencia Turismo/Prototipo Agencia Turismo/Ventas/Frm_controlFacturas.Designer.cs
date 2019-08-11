namespace Prototipo_Agencia_Turismo.Ventas
{
    partial class Frm_controlFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_controlFacturas));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Rbtn_modificar = new System.Windows.Forms.RadioButton();
            this.Rbtn_eliminar = new System.Windows.Forms.RadioButton();
            this.Grpbx_encabezado = new System.Windows.Forms.GroupBox();
            this.Lbl_idTipoPago = new System.Windows.Forms.Label();
            this.Lbl_idCliente = new System.Windows.Forms.Label();
            this.Lbl_tipoPago = new System.Windows.Forms.Label();
            this.Cmbx_tipoPago = new System.Windows.Forms.ComboBox();
            this.Cbo_Pasajero = new System.Windows.Forms.ComboBox();
            this.Lbl_pasajeros = new System.Windows.Forms.Label();
            this.Lbl_fechaEmision = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Txt_cliente = new System.Windows.Forms.TextBox();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.Grpbx_habitacion = new System.Windows.Forms.GroupBox();
            this.CB_noHab = new System.Windows.Forms.ComboBox();
            this.Lbl_noHabitaciones = new System.Windows.Forms.Label();
            this.Btn_consultaHabitación = new System.Windows.Forms.Button();
            this.Txt_habitacion = new System.Windows.Forms.TextBox();
            this.Grpbx_menu = new System.Windows.Forms.GroupBox();
            this.Btn_consultaMenu = new System.Windows.Forms.Button();
            this.Txt_menu = new System.Windows.Forms.TextBox();
            this.Grpbx_lugarT = new System.Windows.Forms.GroupBox();
            this.Btn_consultaLugarTuristico = new System.Windows.Forms.Button();
            this.Txt_lugarTuristico = new System.Windows.Forms.TextBox();
            this.Dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.idHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLugarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Btn_facturar = new System.Windows.Forms.Button();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Btn_colocar = new System.Windows.Forms.Button();
            this.Lbl_codFactura = new System.Windows.Forms.Label();
            this.Btn_consultaFactura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_generarReporte = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            this.Grpbx_encabezado.SuspendLayout();
            this.Grpbx_habitacion.SuspendLayout();
            this.Grpbx_menu.SuspendLayout();
            this.Grpbx_lugarT.SuspendLayout();
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
            this.Pnl_principal.TabIndex = 2;
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
            this.Lbl_titulo.Size = new System.Drawing.Size(201, 19);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "CONTROL DE FACTURAS";
            // 
            // Rbtn_modificar
            // 
            this.Rbtn_modificar.AutoSize = true;
            this.Rbtn_modificar.Enabled = false;
            this.Rbtn_modificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_modificar.Location = new System.Drawing.Point(972, 66);
            this.Rbtn_modificar.Name = "Rbtn_modificar";
            this.Rbtn_modificar.Size = new System.Drawing.Size(107, 23);
            this.Rbtn_modificar.TabIndex = 3;
            this.Rbtn_modificar.TabStop = true;
            this.Rbtn_modificar.Text = "Modificar";
            this.Rbtn_modificar.UseVisualStyleBackColor = true;
            // 
            // Rbtn_eliminar
            // 
            this.Rbtn_eliminar.AutoSize = true;
            this.Rbtn_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_eliminar.Location = new System.Drawing.Point(972, 112);
            this.Rbtn_eliminar.Name = "Rbtn_eliminar";
            this.Rbtn_eliminar.Size = new System.Drawing.Size(93, 23);
            this.Rbtn_eliminar.TabIndex = 4;
            this.Rbtn_eliminar.TabStop = true;
            this.Rbtn_eliminar.Text = "Eliminar";
            this.Rbtn_eliminar.UseVisualStyleBackColor = true;
            this.Rbtn_eliminar.CheckedChanged += new System.EventHandler(this.Rbtn_eliminar_CheckedChanged);
            // 
            // Grpbx_encabezado
            // 
            this.Grpbx_encabezado.Controls.Add(this.Lbl_idTipoPago);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_idCliente);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_tipoPago);
            this.Grpbx_encabezado.Controls.Add(this.Cmbx_tipoPago);
            this.Grpbx_encabezado.Controls.Add(this.Cbo_Pasajero);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_pasajeros);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_fechaEmision);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_fecha);
            this.Grpbx_encabezado.Controls.Add(this.Txt_cliente);
            this.Grpbx_encabezado.Controls.Add(this.Lbl_cliente);
            this.Grpbx_encabezado.Enabled = false;
            this.Grpbx_encabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grpbx_encabezado.Location = new System.Drawing.Point(29, 60);
            this.Grpbx_encabezado.Name = "Grpbx_encabezado";
            this.Grpbx_encabezado.Size = new System.Drawing.Size(793, 114);
            this.Grpbx_encabezado.TabIndex = 5;
            this.Grpbx_encabezado.TabStop = false;
            this.Grpbx_encabezado.Text = "Encabezado";
            // 
            // Lbl_idTipoPago
            // 
            this.Lbl_idTipoPago.AutoSize = true;
            this.Lbl_idTipoPago.Location = new System.Drawing.Point(723, 59);
            this.Lbl_idTipoPago.Name = "Lbl_idTipoPago";
            this.Lbl_idTipoPago.Size = new System.Drawing.Size(25, 21);
            this.Lbl_idTipoPago.TabIndex = 85;
            this.Lbl_idTipoPago.Text = "...";
            // 
            // Lbl_idCliente
            // 
            this.Lbl_idCliente.AutoSize = true;
            this.Lbl_idCliente.Location = new System.Drawing.Point(723, 24);
            this.Lbl_idCliente.Name = "Lbl_idCliente";
            this.Lbl_idCliente.Size = new System.Drawing.Size(25, 21);
            this.Lbl_idCliente.TabIndex = 84;
            this.Lbl_idCliente.Text = "...";
            // 
            // Lbl_tipoPago
            // 
            this.Lbl_tipoPago.AutoSize = true;
            this.Lbl_tipoPago.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoPago.Location = new System.Drawing.Point(556, 11);
            this.Lbl_tipoPago.Name = "Lbl_tipoPago";
            this.Lbl_tipoPago.Size = new System.Drawing.Size(134, 23);
            this.Lbl_tipoPago.TabIndex = 83;
            this.Lbl_tipoPago.Text = "Tipo de pago";
            // 
            // Cmbx_tipoPago
            // 
            this.Cmbx_tipoPago.FormattingEnabled = true;
            this.Cmbx_tipoPago.Location = new System.Drawing.Point(560, 40);
            this.Cmbx_tipoPago.Name = "Cmbx_tipoPago";
            this.Cmbx_tipoPago.Size = new System.Drawing.Size(121, 29);
            this.Cmbx_tipoPago.TabIndex = 82;
            // 
            // Cbo_Pasajero
            // 
            this.Cbo_Pasajero.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Pasajero.FormattingEnabled = true;
            this.Cbo_Pasajero.Items.AddRange(new object[] {
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
            this.Cbo_Pasajero.Location = new System.Drawing.Point(389, 39);
            this.Cbo_Pasajero.Name = "Cbo_Pasajero";
            this.Cbo_Pasajero.Size = new System.Drawing.Size(121, 30);
            this.Cbo_Pasajero.TabIndex = 81;
            // 
            // Lbl_pasajeros
            // 
            this.Lbl_pasajeros.AutoSize = true;
            this.Lbl_pasajeros.Location = new System.Drawing.Point(388, 15);
            this.Lbl_pasajeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_pasajeros.Name = "Lbl_pasajeros";
            this.Lbl_pasajeros.Size = new System.Drawing.Size(122, 21);
            this.Lbl_pasajeros.TabIndex = 80;
            this.Lbl_pasajeros.Text = "No. Pasajeros";
            // 
            // Lbl_fechaEmision
            // 
            this.Lbl_fechaEmision.AutoSize = true;
            this.Lbl_fechaEmision.Location = new System.Drawing.Point(166, 74);
            this.Lbl_fechaEmision.Name = "Lbl_fechaEmision";
            this.Lbl_fechaEmision.Size = new System.Drawing.Size(110, 21);
            this.Lbl_fechaEmision.TabIndex = 79;
            this.Lbl_fechaEmision.Text = "yyyy/mm/dd";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Location = new System.Drawing.Point(17, 74);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(62, 21);
            this.Lbl_fecha.TabIndex = 76;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Txt_cliente
            // 
            this.Txt_cliente.Enabled = false;
            this.Txt_cliente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cliente.Location = new System.Drawing.Point(170, 32);
            this.Txt_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_cliente.Name = "Txt_cliente";
            this.Txt_cliente.Size = new System.Drawing.Size(173, 30);
            this.Txt_cliente.TabIndex = 75;
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Location = new System.Drawing.Point(17, 35);
            this.Lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.Size = new System.Drawing.Size(69, 21);
            this.Lbl_cliente.TabIndex = 74;
            this.Lbl_cliente.Text = "Cliente";
            // 
            // Grpbx_habitacion
            // 
            this.Grpbx_habitacion.Controls.Add(this.CB_noHab);
            this.Grpbx_habitacion.Controls.Add(this.Lbl_noHabitaciones);
            this.Grpbx_habitacion.Controls.Add(this.Btn_consultaHabitación);
            this.Grpbx_habitacion.Controls.Add(this.Txt_habitacion);
            this.Grpbx_habitacion.Enabled = false;
            this.Grpbx_habitacion.Location = new System.Drawing.Point(27, 175);
            this.Grpbx_habitacion.Name = "Grpbx_habitacion";
            this.Grpbx_habitacion.Size = new System.Drawing.Size(304, 130);
            this.Grpbx_habitacion.TabIndex = 6;
            this.Grpbx_habitacion.TabStop = false;
            this.Grpbx_habitacion.Text = "Habitación";
            // 
            // CB_noHab
            // 
            this.CB_noHab.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_noHab.FormattingEnabled = true;
            this.CB_noHab.Items.AddRange(new object[] {
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
            this.CB_noHab.Location = new System.Drawing.Point(181, 85);
            this.CB_noHab.Name = "CB_noHab";
            this.CB_noHab.Size = new System.Drawing.Size(117, 30);
            this.CB_noHab.TabIndex = 73;
            // 
            // Lbl_noHabitaciones
            // 
            this.Lbl_noHabitaciones.AutoSize = true;
            this.Lbl_noHabitaciones.Location = new System.Drawing.Point(7, 94);
            this.Lbl_noHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_noHabitaciones.Name = "Lbl_noHabitaciones";
            this.Lbl_noHabitaciones.Size = new System.Drawing.Size(155, 21);
            this.Lbl_noHabitaciones.TabIndex = 72;
            this.Lbl_noHabitaciones.Text = "No. Habitaciones";
            // 
            // Btn_consultaHabitación
            // 
            this.Btn_consultaHabitación.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaHabitación.Enabled = false;
            this.Btn_consultaHabitación.FlatAppearance.BorderSize = 3;
            this.Btn_consultaHabitación.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaHabitación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaHabitación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaHabitación.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaHabitación.Image")));
            this.Btn_consultaHabitación.Location = new System.Drawing.Point(170, 32);
            this.Btn_consultaHabitación.Name = "Btn_consultaHabitación";
            this.Btn_consultaHabitación.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaHabitación.TabIndex = 68;
            this.Btn_consultaHabitación.UseVisualStyleBackColor = false;
            // 
            // Txt_habitacion
            // 
            this.Txt_habitacion.Enabled = false;
            this.Txt_habitacion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_habitacion.Location = new System.Drawing.Point(21, 38);
            this.Txt_habitacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_habitacion.Name = "Txt_habitacion";
            this.Txt_habitacion.Size = new System.Drawing.Size(116, 30);
            this.Txt_habitacion.TabIndex = 67;
            // 
            // Grpbx_menu
            // 
            this.Grpbx_menu.Controls.Add(this.Btn_consultaMenu);
            this.Grpbx_menu.Controls.Add(this.Txt_menu);
            this.Grpbx_menu.Enabled = false;
            this.Grpbx_menu.Location = new System.Drawing.Point(372, 205);
            this.Grpbx_menu.Name = "Grpbx_menu";
            this.Grpbx_menu.Size = new System.Drawing.Size(365, 100);
            this.Grpbx_menu.TabIndex = 7;
            this.Grpbx_menu.TabStop = false;
            this.Grpbx_menu.Text = "Menú";
            // 
            // Btn_consultaMenu
            // 
            this.Btn_consultaMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaMenu.FlatAppearance.BorderSize = 3;
            this.Btn_consultaMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaMenu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaMenu.Image")));
            this.Btn_consultaMenu.Location = new System.Drawing.Point(233, 38);
            this.Btn_consultaMenu.Name = "Btn_consultaMenu";
            this.Btn_consultaMenu.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaMenu.TabIndex = 88;
            this.Btn_consultaMenu.UseVisualStyleBackColor = false;
            // 
            // Txt_menu
            // 
            this.Txt_menu.Enabled = false;
            this.Txt_menu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_menu.Location = new System.Drawing.Point(49, 40);
            this.Txt_menu.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_menu.Name = "Txt_menu";
            this.Txt_menu.Size = new System.Drawing.Size(164, 30);
            this.Txt_menu.TabIndex = 87;
            // 
            // Grpbx_lugarT
            // 
            this.Grpbx_lugarT.Controls.Add(this.Btn_consultaLugarTuristico);
            this.Grpbx_lugarT.Controls.Add(this.Txt_lugarTuristico);
            this.Grpbx_lugarT.Enabled = false;
            this.Grpbx_lugarT.Location = new System.Drawing.Point(772, 205);
            this.Grpbx_lugarT.Name = "Grpbx_lugarT";
            this.Grpbx_lugarT.Size = new System.Drawing.Size(344, 100);
            this.Grpbx_lugarT.TabIndex = 8;
            this.Grpbx_lugarT.TabStop = false;
            this.Grpbx_lugarT.Text = "Lugar Turístico";
            // 
            // Btn_consultaLugarTuristico
            // 
            this.Btn_consultaLugarTuristico.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaLugarTuristico.FlatAppearance.BorderSize = 3;
            this.Btn_consultaLugarTuristico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaLugarTuristico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaLugarTuristico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaLugarTuristico.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaLugarTuristico.Image")));
            this.Btn_consultaLugarTuristico.Location = new System.Drawing.Point(243, 30);
            this.Btn_consultaLugarTuristico.Name = "Btn_consultaLugarTuristico";
            this.Btn_consultaLugarTuristico.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaLugarTuristico.TabIndex = 81;
            this.Btn_consultaLugarTuristico.UseVisualStyleBackColor = false;
            // 
            // Txt_lugarTuristico
            // 
            this.Txt_lugarTuristico.Enabled = false;
            this.Txt_lugarTuristico.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_lugarTuristico.Location = new System.Drawing.Point(29, 36);
            this.Txt_lugarTuristico.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_lugarTuristico.Name = "Txt_lugarTuristico";
            this.Txt_lugarTuristico.Size = new System.Drawing.Size(172, 30);
            this.Txt_lugarTuristico.TabIndex = 80;
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
            this.idHabitacion,
            this.idMenu,
            this.idLugarT,
            this.cantidadHabitaciones,
            this.importe});
            this.Dgv_detalleFactura.Location = new System.Drawing.Point(38, 311);
            this.Dgv_detalleFactura.Name = "Dgv_detalleFactura";
            this.Dgv_detalleFactura.RowHeadersVisible = false;
            this.Dgv_detalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_detalleFactura.Size = new System.Drawing.Size(931, 278);
            this.Dgv_detalleFactura.TabIndex = 9;
            // 
            // idHabitacion
            // 
            this.idHabitacion.HeaderText = "Código habitación";
            this.idHabitacion.Name = "idHabitacion";
            // 
            // idMenu
            // 
            this.idMenu.HeaderText = "Código menú";
            this.idMenu.Name = "idMenu";
            // 
            // idLugarT
            // 
            this.idLugarT.HeaderText = "Código lugar turístico";
            this.idLugarT.Name = "idLugarT";
            // 
            // cantidadHabitaciones
            // 
            this.cantidadHabitaciones.HeaderText = "Cantidad Habitaciones";
            this.cantidadHabitaciones.Name = "cantidadHabitaciones";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Lbl_resultado.Location = new System.Drawing.Point(854, 606);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(115, 25);
            this.Lbl_resultado.TabIndex = 79;
            this.Lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(768, 606);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(80, 23);
            this.Lbl_Total.TabIndex = 78;
            this.Lbl_Total.Text = "Total Q.";
            // 
            // Btn_facturar
            // 
            this.Btn_facturar.Enabled = false;
            this.Btn_facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_facturar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_facturar.Location = new System.Drawing.Point(975, 538);
            this.Btn_facturar.Name = "Btn_facturar";
            this.Btn_facturar.Size = new System.Drawing.Size(202, 44);
            this.Btn_facturar.TabIndex = 83;
            this.Btn_facturar.Text = ".";
            this.Btn_facturar.UseVisualStyleBackColor = true;
            this.Btn_facturar.Click += new System.EventHandler(this.Btn_facturar_Click);
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.Enabled = false;
            this.Btn_quitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_quitar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitar.Location = new System.Drawing.Point(975, 470);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(202, 44);
            this.Btn_quitar.TabIndex = 82;
            this.Btn_quitar.Text = "Eliminar";
            this.Btn_quitar.UseVisualStyleBackColor = true;
            // 
            // Btn_colocar
            // 
            this.Btn_colocar.Enabled = false;
            this.Btn_colocar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_colocar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_colocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_colocar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_colocar.Location = new System.Drawing.Point(975, 406);
            this.Btn_colocar.Name = "Btn_colocar";
            this.Btn_colocar.Size = new System.Drawing.Size(202, 44);
            this.Btn_colocar.TabIndex = 81;
            this.Btn_colocar.Text = "Colocar";
            this.Btn_colocar.UseVisualStyleBackColor = true;
            // 
            // Lbl_codFactura
            // 
            this.Lbl_codFactura.AutoSize = true;
            this.Lbl_codFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_codFactura.Location = new System.Drawing.Point(372, 43);
            this.Lbl_codFactura.Name = "Lbl_codFactura";
            this.Lbl_codFactura.Size = new System.Drawing.Size(27, 23);
            this.Lbl_codFactura.TabIndex = 84;
            this.Lbl_codFactura.Text = "...";
            // 
            // Btn_consultaFactura
            // 
            this.Btn_consultaFactura.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaFactura.FlatAppearance.BorderSize = 3;
            this.Btn_consultaFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_consultaFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaFactura.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaFactura.Image")));
            this.Btn_consultaFactura.Location = new System.Drawing.Point(891, 83);
            this.Btn_consultaFactura.Name = "Btn_consultaFactura";
            this.Btn_consultaFactura.Size = new System.Drawing.Size(75, 36);
            this.Btn_consultaFactura.TabIndex = 89;
            this.Btn_consultaFactura.UseVisualStyleBackColor = false;
            this.Btn_consultaFactura.Click += new System.EventHandler(this.Btn_consultaFactura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "Código de factura:";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(945, 2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(35, 35);
            this.Btn_ayuda.TabIndex = 91;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_generarReporte
            // 
            this.Btn_generarReporte.Enabled = false;
            this.Btn_generarReporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_generarReporte.FlatAppearance.BorderSize = 3;
            this.Btn_generarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_generarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_generarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_generarReporte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generarReporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_generarReporte.Image")));
            this.Btn_generarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_generarReporte.Location = new System.Drawing.Point(979, 141);
            this.Btn_generarReporte.Name = "Btn_generarReporte";
            this.Btn_generarReporte.Size = new System.Drawing.Size(189, 41);
            this.Btn_generarReporte.TabIndex = 92;
            this.Btn_generarReporte.Text = "Generar reporte";
            this.Btn_generarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_generarReporte.UseVisualStyleBackColor = true;
            this.Btn_generarReporte.Click += new System.EventHandler(this.Btn_generarReporte_Click);
            // 
            // Frm_controlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Btn_generarReporte);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_consultaFactura);
            this.Controls.Add(this.Lbl_codFactura);
            this.Controls.Add(this.Btn_facturar);
            this.Controls.Add(this.Btn_quitar);
            this.Controls.Add(this.Btn_colocar);
            this.Controls.Add(this.Lbl_resultado);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Dgv_detalleFactura);
            this.Controls.Add(this.Grpbx_lugarT);
            this.Controls.Add(this.Grpbx_menu);
            this.Controls.Add(this.Grpbx_habitacion);
            this.Controls.Add(this.Grpbx_encabezado);
            this.Controls.Add(this.Rbtn_eliminar);
            this.Controls.Add(this.Rbtn_modificar);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_controlFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_controlFacturas";
            this.Load += new System.EventHandler(this.Frm_controlFacturas_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.Grpbx_encabezado.ResumeLayout(false);
            this.Grpbx_encabezado.PerformLayout();
            this.Grpbx_habitacion.ResumeLayout(false);
            this.Grpbx_habitacion.PerformLayout();
            this.Grpbx_menu.ResumeLayout(false);
            this.Grpbx_menu.PerformLayout();
            this.Grpbx_lugarT.ResumeLayout(false);
            this.Grpbx_lugarT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.RadioButton Rbtn_modificar;
        private System.Windows.Forms.RadioButton Rbtn_eliminar;
        private System.Windows.Forms.GroupBox Grpbx_encabezado;
        private System.Windows.Forms.Label Lbl_fechaEmision;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.TextBox Txt_cliente;
        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.ComboBox Cbo_Pasajero;
        private System.Windows.Forms.Label Lbl_pasajeros;
        private System.Windows.Forms.GroupBox Grpbx_habitacion;
        private System.Windows.Forms.GroupBox Grpbx_menu;
        private System.Windows.Forms.GroupBox Grpbx_lugarT;
        private System.Windows.Forms.Button Btn_consultaMenu;
        private System.Windows.Forms.TextBox Txt_menu;
        private System.Windows.Forms.TextBox Txt_habitacion;
        private System.Windows.Forms.Button Btn_consultaHabitación;
        private System.Windows.Forms.ComboBox CB_noHab;
        private System.Windows.Forms.Label Lbl_noHabitaciones;
        private System.Windows.Forms.Label Lbl_tipoPago;
        private System.Windows.Forms.ComboBox Cmbx_tipoPago;
        private System.Windows.Forms.TextBox Txt_lugarTuristico;
        private System.Windows.Forms.Button Btn_consultaLugarTuristico;
        private System.Windows.Forms.DataGridView Dgv_detalleFactura;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Button Btn_facturar;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.Button Btn_colocar;
        private System.Windows.Forms.Label Lbl_codFactura;
        private System.Windows.Forms.Button Btn_consultaFactura;
        private System.Windows.Forms.Label Lbl_idCliente;
        private System.Windows.Forms.Label Lbl_idTipoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLugarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_generarReporte;
    }
}