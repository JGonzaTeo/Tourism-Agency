namespace Prototipo_Agencia_Turismo.Cotizacion
{
    partial class Frm_Cotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cotizacion));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_Encabezado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.CB_Pasajero = new System.Windows.Forms.ComboBox();
            this.Lbl_Pasajeros = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.DTM_FechaCot = new System.Windows.Forms.DateTimePicker();
            this.Txt_IdEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.Pnl_Detalle = new System.Windows.Forms.Panel();
            this.Lbl_LugarT = new System.Windows.Forms.Label();
            this.CB_LugarT = new System.Windows.Forms.ComboBox();
            this.Lbl_Restaurante = new System.Windows.Forms.Label();
            this.CB_Restaurante = new System.Windows.Forms.ComboBox();
            this.CB_Menu = new System.Windows.Forms.ComboBox();
            this.Lbl_Menu = new System.Windows.Forms.Label();
            this.CB_Hotel = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lbl_Hotel = new System.Windows.Forms.Label();
            this.Lbl_Habitacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Habitacion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Grb_LugarT = new System.Windows.Forms.GroupBox();
            this.Grb_Restaurante = new System.Windows.Forms.GroupBox();
            this.Grb_Hotel = new System.Windows.Forms.GroupBox();
            this.Pnl_principal.SuspendLayout();
            this.Pnl_Encabezado.SuspendLayout();
            this.Pnl_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Grb_LugarT.SuspendLayout();
            this.Grb_Restaurante.SuspendLayout();
            this.Grb_Hotel.SuspendLayout();
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
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(24, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(95, 17);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "COTIZACIÓN";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // Pnl_Encabezado
            // 
            this.Pnl_Encabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Encabezado.Controls.Add(this.label1);
            this.Pnl_Encabezado.Controls.Add(this.Txt_Total);
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Total);
            this.Pnl_Encabezado.Controls.Add(this.CB_Pasajero);
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Pasajeros);
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Fecha);
            this.Pnl_Encabezado.Controls.Add(this.DTM_FechaCot);
            this.Pnl_Encabezado.Controls.Add(this.Txt_IdEmpleado);
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Empleado);
            this.Pnl_Encabezado.Controls.Add(this.Txt_Cliente);
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Cliente);
            this.Pnl_Encabezado.Location = new System.Drawing.Point(0, 67);
            this.Pnl_Encabezado.Name = "Pnl_Encabezado";
            this.Pnl_Encabezado.Size = new System.Drawing.Size(1180, 158);
            this.Pnl_Encabezado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(880, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Q";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Total
            // 
            this.Txt_Total.Enabled = false;
            this.Txt_Total.Location = new System.Drawing.Point(901, 94);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(111, 26);
            this.Txt_Total.TabIndex = 57;
            this.Txt_Total.Visible = false;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Enabled = false;
            this.Lbl_Total.Location = new System.Drawing.Point(830, 98);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(42, 20);
            this.Lbl_Total.TabIndex = 56;
            this.Lbl_Total.Text = "Total";
            this.Lbl_Total.Visible = false;
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
            this.CB_Pasajero.Location = new System.Drawing.Point(579, 95);
            this.CB_Pasajero.Name = "CB_Pasajero";
            this.CB_Pasajero.Size = new System.Drawing.Size(121, 28);
            this.CB_Pasajero.TabIndex = 55;
            // 
            // Lbl_Pasajeros
            // 
            this.Lbl_Pasajeros.AutoSize = true;
            this.Lbl_Pasajeros.Enabled = false;
            this.Lbl_Pasajeros.Location = new System.Drawing.Point(449, 98);
            this.Lbl_Pasajeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Pasajeros.Name = "Lbl_Pasajeros";
            this.Lbl_Pasajeros.Size = new System.Drawing.Size(107, 20);
            this.Lbl_Pasajeros.TabIndex = 53;
            this.Lbl_Pasajeros.Text = "No. Pasajeros";
            this.Lbl_Pasajeros.Visible = false;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Enabled = false;
            this.Lbl_Fecha.Location = new System.Drawing.Point(50, 98);
            this.Lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(55, 20);
            this.Lbl_Fecha.TabIndex = 52;
            this.Lbl_Fecha.Text = "Fecha";
            this.Lbl_Fecha.Visible = false;
            // 
            // DTM_FechaCot
            // 
            this.DTM_FechaCot.CustomFormat = "dd-mm-yyyy";
            this.DTM_FechaCot.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTM_FechaCot.Location = new System.Drawing.Point(165, 92);
            this.DTM_FechaCot.Name = "DTM_FechaCot";
            this.DTM_FechaCot.Size = new System.Drawing.Size(122, 26);
            this.DTM_FechaCot.TabIndex = 51;
            // 
            // Txt_IdEmpleado
            // 
            this.Txt_IdEmpleado.Enabled = false;
            this.Txt_IdEmpleado.Location = new System.Drawing.Point(687, 35);
            this.Txt_IdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IdEmpleado.Name = "Txt_IdEmpleado";
            this.Txt_IdEmpleado.Size = new System.Drawing.Size(325, 26);
            this.Txt_IdEmpleado.TabIndex = 50;
            this.Txt_IdEmpleado.Visible = false;
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Enabled = false;
            this.Lbl_Empleado.Location = new System.Drawing.Point(577, 38);
            this.Lbl_Empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(83, 20);
            this.Lbl_Empleado.TabIndex = 49;
            this.Lbl_Empleado.Text = "Empleado";
            this.Lbl_Empleado.Visible = false;
            this.Lbl_Empleado.Click += new System.EventHandler(this.Lbl_IdEmpleado_Click);
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Enabled = false;
            this.Txt_Cliente.Location = new System.Drawing.Point(165, 35);
            this.Txt_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(348, 26);
            this.Txt_Cliente.TabIndex = 48;
            this.Txt_Cliente.Visible = false;
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Enabled = false;
            this.Lbl_Cliente.Location = new System.Drawing.Point(50, 38);
            this.Lbl_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Cliente.TabIndex = 47;
            this.Lbl_Cliente.Text = "Cliente";
            this.Lbl_Cliente.Visible = false;
            // 
            // Pnl_Detalle
            // 
            this.Pnl_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Detalle.Controls.Add(this.Grb_Hotel);
            this.Pnl_Detalle.Controls.Add(this.Grb_Restaurante);
            this.Pnl_Detalle.Controls.Add(this.Grb_LugarT);
            this.Pnl_Detalle.Controls.Add(this.Btn_consultar);
            this.Pnl_Detalle.Controls.Add(this.Btn_guardar);
            this.Pnl_Detalle.Controls.Add(this.Btn_cancelar);
            this.Pnl_Detalle.Controls.Add(this.Btn_ingresar);
            this.Pnl_Detalle.Controls.Add(this.dataGridView1);
            this.Pnl_Detalle.Location = new System.Drawing.Point(0, 244);
            this.Pnl_Detalle.Name = "Pnl_Detalle";
            this.Pnl_Detalle.Size = new System.Drawing.Size(1180, 384);
            this.Pnl_Detalle.TabIndex = 3;
            // 
            // Lbl_LugarT
            // 
            this.Lbl_LugarT.AutoSize = true;
            this.Lbl_LugarT.Enabled = false;
            this.Lbl_LugarT.Location = new System.Drawing.Point(7, 46);
            this.Lbl_LugarT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_LugarT.Name = "Lbl_LugarT";
            this.Lbl_LugarT.Size = new System.Drawing.Size(68, 20);
            this.Lbl_LugarT.TabIndex = 65;
            this.Lbl_LugarT.Text = "Nombre";
            this.Lbl_LugarT.Visible = false;
            // 
            // CB_LugarT
            // 
            this.CB_LugarT.FormattingEnabled = true;
            this.CB_LugarT.Items.AddRange(new object[] {
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
            this.CB_LugarT.Location = new System.Drawing.Point(82, 43);
            this.CB_LugarT.Name = "CB_LugarT";
            this.CB_LugarT.Size = new System.Drawing.Size(157, 28);
            this.CB_LugarT.TabIndex = 66;
            // 
            // Lbl_Restaurante
            // 
            this.Lbl_Restaurante.AutoSize = true;
            this.Lbl_Restaurante.Enabled = false;
            this.Lbl_Restaurante.Location = new System.Drawing.Point(7, 33);
            this.Lbl_Restaurante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Restaurante.Name = "Lbl_Restaurante";
            this.Lbl_Restaurante.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Restaurante.TabIndex = 63;
            this.Lbl_Restaurante.Text = "Lugar";
            this.Lbl_Restaurante.Visible = false;
            // 
            // CB_Restaurante
            // 
            this.CB_Restaurante.FormattingEnabled = true;
            this.CB_Restaurante.Items.AddRange(new object[] {
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
            this.CB_Restaurante.Location = new System.Drawing.Point(128, 30);
            this.CB_Restaurante.Name = "CB_Restaurante";
            this.CB_Restaurante.Size = new System.Drawing.Size(121, 28);
            this.CB_Restaurante.TabIndex = 64;
            // 
            // CB_Menu
            // 
            this.CB_Menu.FormattingEnabled = true;
            this.CB_Menu.Items.AddRange(new object[] {
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
            this.CB_Menu.Location = new System.Drawing.Point(128, 64);
            this.CB_Menu.Name = "CB_Menu";
            this.CB_Menu.Size = new System.Drawing.Size(121, 28);
            this.CB_Menu.TabIndex = 66;
            // 
            // Lbl_Menu
            // 
            this.Lbl_Menu.AutoSize = true;
            this.Lbl_Menu.Enabled = false;
            this.Lbl_Menu.Location = new System.Drawing.Point(7, 68);
            this.Lbl_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Menu.Name = "Lbl_Menu";
            this.Lbl_Menu.Size = new System.Drawing.Size(52, 20);
            this.Lbl_Menu.TabIndex = 65;
            this.Lbl_Menu.Text = "Menu";
            this.Lbl_Menu.Visible = false;
            // 
            // CB_Hotel
            // 
            this.CB_Hotel.FormattingEnabled = true;
            this.CB_Hotel.Items.AddRange(new object[] {
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
            this.CB_Hotel.Location = new System.Drawing.Point(119, 25);
            this.CB_Hotel.Name = "CB_Hotel";
            this.CB_Hotel.Size = new System.Drawing.Size(121, 28);
            this.CB_Hotel.TabIndex = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(394, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 28);
            this.comboBox1.TabIndex = 60;
            // 
            // Lbl_Hotel
            // 
            this.Lbl_Hotel.AutoSize = true;
            this.Lbl_Hotel.Enabled = false;
            this.Lbl_Hotel.Location = new System.Drawing.Point(23, 25);
            this.Lbl_Hotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Hotel.Name = "Lbl_Hotel";
            this.Lbl_Hotel.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Hotel.TabIndex = 59;
            this.Lbl_Hotel.Text = "Lugar";
            this.Lbl_Hotel.Visible = false;
            // 
            // Lbl_Habitacion
            // 
            this.Lbl_Habitacion.AutoSize = true;
            this.Lbl_Habitacion.Enabled = false;
            this.Lbl_Habitacion.Location = new System.Drawing.Point(23, 67);
            this.Lbl_Habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Habitacion.Name = "Lbl_Habitacion";
            this.Lbl_Habitacion.Size = new System.Drawing.Size(89, 20);
            this.Lbl_Habitacion.TabIndex = 61;
            this.Lbl_Habitacion.Text = "Habitacion";
            this.Lbl_Habitacion.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(258, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "No. Habitaciones";
            this.label2.Visible = false;
            // 
            // CB_Habitacion
            // 
            this.CB_Habitacion.FormattingEnabled = true;
            this.CB_Habitacion.Items.AddRange(new object[] {
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
            this.CB_Habitacion.Location = new System.Drawing.Point(119, 64);
            this.CB_Habitacion.Name = "CB_Habitacion";
            this.CB_Habitacion.Size = new System.Drawing.Size(121, 28);
            this.CB_Habitacion.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 233);
            this.dataGridView1.TabIndex = 0;
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
            this.Btn_ingresar.Location = new System.Drawing.Point(1060, 4);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(95, 79);
            this.Btn_ingresar.TabIndex = 71;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
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
            this.Btn_cancelar.Location = new System.Drawing.Point(1060, 91);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(95, 79);
            this.Btn_cancelar.TabIndex = 72;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
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
            this.Btn_guardar.Location = new System.Drawing.Point(1060, 178);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(95, 79);
            this.Btn_guardar.TabIndex = 73;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
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
            this.Btn_consultar.Location = new System.Drawing.Point(1059, 265);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(96, 79);
            this.Btn_consultar.TabIndex = 74;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            // 
            // Grb_LugarT
            // 
            this.Grb_LugarT.Controls.Add(this.CB_LugarT);
            this.Grb_LugarT.Controls.Add(this.Lbl_LugarT);
            this.Grb_LugarT.Location = new System.Drawing.Point(785, 8);
            this.Grb_LugarT.Name = "Grb_LugarT";
            this.Grb_LugarT.Size = new System.Drawing.Size(245, 82);
            this.Grb_LugarT.TabIndex = 59;
            this.Grb_LugarT.TabStop = false;
            this.Grb_LugarT.Text = "Lugar Turistico";
            // 
            // Grb_Restaurante
            // 
            this.Grb_Restaurante.Controls.Add(this.Lbl_Restaurante);
            this.Grb_Restaurante.Controls.Add(this.CB_Restaurante);
            this.Grb_Restaurante.Controls.Add(this.CB_Menu);
            this.Grb_Restaurante.Controls.Add(this.Lbl_Menu);
            this.Grb_Restaurante.Location = new System.Drawing.Point(500, 8);
            this.Grb_Restaurante.Name = "Grb_Restaurante";
            this.Grb_Restaurante.Size = new System.Drawing.Size(270, 100);
            this.Grb_Restaurante.TabIndex = 75;
            this.Grb_Restaurante.TabStop = false;
            this.Grb_Restaurante.Text = "Restaurante";
            // 
            // Grb_Hotel
            // 
            this.Grb_Hotel.Controls.Add(this.CB_Hotel);
            this.Grb_Hotel.Controls.Add(this.CB_Habitacion);
            this.Grb_Hotel.Controls.Add(this.comboBox1);
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
            // Frm_Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.Pnl_Detalle);
            this.Controls.Add(this.Pnl_Encabezado);
            this.Controls.Add(this.Pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Cotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cotizacion";
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.Pnl_Encabezado.ResumeLayout(false);
            this.Pnl_Encabezado.PerformLayout();
            this.Pnl_Detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Grb_LugarT.ResumeLayout(false);
            this.Grb_LugarT.PerformLayout();
            this.Grb_Restaurante.ResumeLayout(false);
            this.Grb_Restaurante.PerformLayout();
            this.Grb_Hotel.ResumeLayout(false);
            this.Grb_Hotel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_Encabezado;
        private System.Windows.Forms.Panel Pnl_Detalle;
        private System.Windows.Forms.ComboBox CB_Pasajero;
        private System.Windows.Forms.Label Lbl_Pasajeros;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker DTM_FechaCot;
        private System.Windows.Forms.TextBox Txt_IdEmpleado;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_LugarT;
        private System.Windows.Forms.ComboBox CB_LugarT;
        private System.Windows.Forms.Label Lbl_Restaurante;
        private System.Windows.Forms.ComboBox CB_Restaurante;
        private System.Windows.Forms.ComboBox CB_Menu;
        private System.Windows.Forms.Label Lbl_Menu;
        private System.Windows.Forms.ComboBox CB_Hotel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lbl_Hotel;
        private System.Windows.Forms.Label Lbl_Habitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Habitacion;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.GroupBox Grb_Hotel;
        private System.Windows.Forms.GroupBox Grb_Restaurante;
        private System.Windows.Forms.GroupBox Grb_LugarT;
        private System.Windows.Forms.Button Btn_consultar;
    }
}