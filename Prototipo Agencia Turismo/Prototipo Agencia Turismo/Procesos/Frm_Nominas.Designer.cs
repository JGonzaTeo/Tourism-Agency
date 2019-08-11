namespace Prototipo_Agencia_Turismo.Procesos
{
    partial class Frm_Nominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Nominas));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Gpb_datosgenerales = new System.Windows.Forms.GroupBox();
            this.Dtp_FechaEmi = new System.Windows.Forms.DateTimePicker();
            this.Txt_coddoc = new System.Windows.Forms.TextBox();
            this.Lbl_fechaemision = new System.Windows.Forms.Label();
            this.Lbl_codnomina = new System.Windows.Forms.Label();
            this.Gpb_Datosemp = new System.Windows.Forms.GroupBox();
            this.Txt_sueldoliquido = new System.Windows.Forms.TextBox();
            this.Lbl_sueldoliquido = new System.Windows.Forms.Label();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_consultaEmp = new System.Windows.Forms.Button();
            this.Txt_sueldobase = new System.Windows.Forms.TextBox();
            this.Lbl_sueldobase = new System.Windows.Forms.Label();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_puesto = new System.Windows.Forms.Label();
            this.Txt_numerocuenta = new System.Windows.Forms.TextBox();
            this.Lbl_numerocuenta = new System.Windows.Forms.Label();
            this.Txt_dias = new System.Windows.Forms.TextBox();
            this.Txt_codempleado = new System.Windows.Forms.TextBox();
            this.Lbl_diastrabajados = new System.Windows.Forms.Label();
            this.Lbl_datosemp = new System.Windows.Forms.Label();
            this.Lbl_bonos = new System.Windows.Forms.Label();
            this.Cmb_Bonos = new System.Windows.Forms.ComboBox();
            this.Txt_bono = new System.Windows.Forms.TextBox();
            this.Lbl_desc = new System.Windows.Forms.Label();
            this.Gpb_operaciones = new System.Windows.Forms.GroupBox();
            this.Txt_coddescus = new System.Windows.Forms.TextBox();
            this.Txt_codbonos = new System.Windows.Forms.TextBox();
            this.Btn_ingresardescuento = new System.Windows.Forms.Button();
            this.Btn_ingresarbono = new System.Windows.Forms.Button();
            this.Txt_descuentos = new System.Windows.Forms.TextBox();
            this.Cmb_Descuentos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            this.Gpb_datosgenerales.SuspendLayout();
            this.Gpb_Datosemp.SuspendLayout();
            this.Gpb_operaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_principal.Controls.Add(this.Btn_ayuda);
            this.Pnl_principal.Controls.Add(this.Btn_minimizar);
            this.Pnl_principal.Controls.Add(this.Btn_cerrar);
            this.Pnl_principal.Controls.Add(this.Lbl_titulo);
            this.Pnl_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_principal.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(1180, 40);
            this.Pnl_principal.TabIndex = 3;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(1020, 1);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(35, 37);
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
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(35, 37);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(34, 16);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(82, 20);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Nominas";
            // 
            // Gpb_datosgenerales
            // 
            this.Gpb_datosgenerales.Controls.Add(this.Dtp_FechaEmi);
            this.Gpb_datosgenerales.Controls.Add(this.Txt_coddoc);
            this.Gpb_datosgenerales.Controls.Add(this.Lbl_fechaemision);
            this.Gpb_datosgenerales.Controls.Add(this.Lbl_codnomina);
            this.Gpb_datosgenerales.Location = new System.Drawing.Point(39, 62);
            this.Gpb_datosgenerales.Name = "Gpb_datosgenerales";
            this.Gpb_datosgenerales.Size = new System.Drawing.Size(1077, 70);
            this.Gpb_datosgenerales.TabIndex = 4;
            this.Gpb_datosgenerales.TabStop = false;
            this.Gpb_datosgenerales.Text = "Datos Generales";
            // 
            // Dtp_FechaEmi
            // 
            this.Dtp_FechaEmi.CustomFormat = "yyyy-MM-dd";
            this.Dtp_FechaEmi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_FechaEmi.Location = new System.Drawing.Point(666, 37);
            this.Dtp_FechaEmi.Name = "Dtp_FechaEmi";
            this.Dtp_FechaEmi.Size = new System.Drawing.Size(125, 22);
            this.Dtp_FechaEmi.TabIndex = 109;
            // 
            // Txt_coddoc
            // 
            this.Txt_coddoc.Location = new System.Drawing.Point(198, 37);
            this.Txt_coddoc.Name = "Txt_coddoc";
            this.Txt_coddoc.Size = new System.Drawing.Size(100, 22);
            this.Txt_coddoc.TabIndex = 2;
            this.Txt_coddoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_fechaemision
            // 
            this.Lbl_fechaemision.AutoSize = true;
            this.Lbl_fechaemision.Location = new System.Drawing.Point(537, 37);
            this.Lbl_fechaemision.Name = "Lbl_fechaemision";
            this.Lbl_fechaemision.Size = new System.Drawing.Size(123, 17);
            this.Lbl_fechaemision.TabIndex = 1;
            this.Lbl_fechaemision.Text = "Fecha de emision:";
            // 
            // Lbl_codnomina
            // 
            this.Lbl_codnomina.AutoSize = true;
            this.Lbl_codnomina.Location = new System.Drawing.Point(42, 37);
            this.Lbl_codnomina.Name = "Lbl_codnomina";
            this.Lbl_codnomina.Size = new System.Drawing.Size(156, 17);
            this.Lbl_codnomina.TabIndex = 0;
            this.Lbl_codnomina.Text = "Numero De Documento";
            // 
            // Gpb_Datosemp
            // 
            this.Gpb_Datosemp.Controls.Add(this.Txt_sueldoliquido);
            this.Gpb_Datosemp.Controls.Add(this.Lbl_sueldoliquido);
            this.Gpb_Datosemp.Controls.Add(this.Btn_borrar);
            this.Gpb_Datosemp.Controls.Add(this.Btn_ingresar);
            this.Gpb_Datosemp.Controls.Add(this.Btn_consultaEmp);
            this.Gpb_Datosemp.Controls.Add(this.Txt_sueldobase);
            this.Gpb_Datosemp.Controls.Add(this.Lbl_sueldobase);
            this.Gpb_Datosemp.Controls.Add(this.Txt_direccion);
            this.Gpb_Datosemp.Controls.Add(this.Lbl_puesto);
            this.Gpb_Datosemp.Controls.Add(this.Txt_numerocuenta);
            this.Gpb_Datosemp.Controls.Add(this.Lbl_numerocuenta);
            this.Gpb_Datosemp.Controls.Add(this.Txt_dias);
            this.Gpb_Datosemp.Controls.Add(this.Txt_codempleado);
            this.Gpb_Datosemp.Controls.Add(this.Lbl_diastrabajados);
            this.Gpb_Datosemp.Controls.Add(this.Lbl_datosemp);
            this.Gpb_Datosemp.Location = new System.Drawing.Point(39, 165);
            this.Gpb_Datosemp.Name = "Gpb_Datosemp";
            this.Gpb_Datosemp.Size = new System.Drawing.Size(1077, 138);
            this.Gpb_Datosemp.TabIndex = 5;
            this.Gpb_Datosemp.TabStop = false;
            this.Gpb_Datosemp.Text = "Datos Empleado";
            // 
            // Txt_sueldoliquido
            // 
            this.Txt_sueldoliquido.Location = new System.Drawing.Point(816, 89);
            this.Txt_sueldoliquido.Name = "Txt_sueldoliquido";
            this.Txt_sueldoliquido.Size = new System.Drawing.Size(100, 22);
            this.Txt_sueldoliquido.TabIndex = 123;
            // 
            // Lbl_sueldoliquido
            // 
            this.Lbl_sueldoliquido.AutoSize = true;
            this.Lbl_sueldoliquido.Location = new System.Drawing.Point(713, 89);
            this.Lbl_sueldoliquido.Name = "Lbl_sueldoliquido";
            this.Lbl_sueldoliquido.Size = new System.Drawing.Size(97, 17);
            this.Lbl_sueldoliquido.TabIndex = 122;
            this.Lbl_sueldoliquido.Text = "Sueldo liquido";
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.Location = new System.Drawing.Point(971, 86);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(85, 35);
            this.Btn_borrar.TabIndex = 121;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Location = new System.Drawing.Point(971, 34);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(85, 35);
            this.Btn_ingresar.TabIndex = 120;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Btn_consultaEmp
            // 
            this.Btn_consultaEmp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_consultaEmp.Enabled = false;
            this.Btn_consultaEmp.FlatAppearance.BorderSize = 3;
            this.Btn_consultaEmp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultaEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultaEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaEmp.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultaEmp.Image")));
            this.Btn_consultaEmp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultaEmp.Location = new System.Drawing.Point(304, 37);
            this.Btn_consultaEmp.Name = "Btn_consultaEmp";
            this.Btn_consultaEmp.Size = new System.Drawing.Size(65, 22);
            this.Btn_consultaEmp.TabIndex = 119;
            this.Btn_consultaEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultaEmp.UseVisualStyleBackColor = false;
            this.Btn_consultaEmp.Click += new System.EventHandler(this.Btn_consultaPerfil_Click);
            // 
            // Txt_sueldobase
            // 
            this.Txt_sueldobase.Location = new System.Drawing.Point(816, 34);
            this.Txt_sueldobase.Name = "Txt_sueldobase";
            this.Txt_sueldobase.Size = new System.Drawing.Size(100, 22);
            this.Txt_sueldobase.TabIndex = 9;
            // 
            // Lbl_sueldobase
            // 
            this.Lbl_sueldobase.AutoSize = true;
            this.Lbl_sueldobase.Location = new System.Drawing.Point(723, 37);
            this.Lbl_sueldobase.Name = "Lbl_sueldobase";
            this.Lbl_sueldobase.Size = new System.Drawing.Size(87, 17);
            this.Lbl_sueldobase.TabIndex = 8;
            this.Lbl_sueldobase.Text = "Sueldo base";
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Location = new System.Drawing.Point(478, 89);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(171, 22);
            this.Txt_direccion.TabIndex = 7;
            // 
            // Lbl_puesto
            // 
            this.Lbl_puesto.AutoSize = true;
            this.Lbl_puesto.Location = new System.Drawing.Point(396, 89);
            this.Lbl_puesto.Name = "Lbl_puesto";
            this.Lbl_puesto.Size = new System.Drawing.Size(67, 17);
            this.Lbl_puesto.TabIndex = 6;
            this.Lbl_puesto.Text = "Direccion";
            // 
            // Txt_numerocuenta
            // 
            this.Txt_numerocuenta.Location = new System.Drawing.Point(198, 86);
            this.Txt_numerocuenta.Name = "Txt_numerocuenta";
            this.Txt_numerocuenta.Size = new System.Drawing.Size(100, 22);
            this.Txt_numerocuenta.TabIndex = 5;
            // 
            // Lbl_numerocuenta
            // 
            this.Lbl_numerocuenta.AutoSize = true;
            this.Lbl_numerocuenta.Location = new System.Drawing.Point(119, 86);
            this.Lbl_numerocuenta.Name = "Lbl_numerocuenta";
            this.Lbl_numerocuenta.Size = new System.Drawing.Size(75, 17);
            this.Lbl_numerocuenta.TabIndex = 4;
            this.Lbl_numerocuenta.Text = "No.Cuenta";
            // 
            // Txt_dias
            // 
            this.Txt_dias.Location = new System.Drawing.Point(514, 34);
            this.Txt_dias.Name = "Txt_dias";
            this.Txt_dias.Size = new System.Drawing.Size(100, 22);
            this.Txt_dias.TabIndex = 3;
            // 
            // Txt_codempleado
            // 
            this.Txt_codempleado.Location = new System.Drawing.Point(198, 37);
            this.Txt_codempleado.Name = "Txt_codempleado";
            this.Txt_codempleado.Size = new System.Drawing.Size(100, 22);
            this.Txt_codempleado.TabIndex = 2;
            // 
            // Lbl_diastrabajados
            // 
            this.Lbl_diastrabajados.AutoSize = true;
            this.Lbl_diastrabajados.Location = new System.Drawing.Point(396, 37);
            this.Lbl_diastrabajados.Name = "Lbl_diastrabajados";
            this.Lbl_diastrabajados.Size = new System.Drawing.Size(112, 17);
            this.Lbl_diastrabajados.TabIndex = 1;
            this.Lbl_diastrabajados.Text = "Dias Trabajados";
            // 
            // Lbl_datosemp
            // 
            this.Lbl_datosemp.AutoSize = true;
            this.Lbl_datosemp.Location = new System.Drawing.Point(42, 37);
            this.Lbl_datosemp.Name = "Lbl_datosemp";
            this.Lbl_datosemp.Size = new System.Drawing.Size(145, 17);
            this.Lbl_datosemp.TabIndex = 0;
            this.Lbl_datosemp.Text = "Codigo De Empleado:";
            // 
            // Lbl_bonos
            // 
            this.Lbl_bonos.AutoSize = true;
            this.Lbl_bonos.Location = new System.Drawing.Point(19, 32);
            this.Lbl_bonos.Name = "Lbl_bonos";
            this.Lbl_bonos.Size = new System.Drawing.Size(52, 17);
            this.Lbl_bonos.TabIndex = 6;
            this.Lbl_bonos.Text = "Bonos:";
            // 
            // Cmb_Bonos
            // 
            this.Cmb_Bonos.FormattingEnabled = true;
            this.Cmb_Bonos.Location = new System.Drawing.Point(78, 32);
            this.Cmb_Bonos.Name = "Cmb_Bonos";
            this.Cmb_Bonos.Size = new System.Drawing.Size(121, 24);
            this.Cmb_Bonos.TabIndex = 7;
            this.Cmb_Bonos.SelectedIndexChanged += new System.EventHandler(this.Cmb_Bonos_SelectedIndexChanged);
            // 
            // Txt_bono
            // 
            this.Txt_bono.Location = new System.Drawing.Point(205, 33);
            this.Txt_bono.Name = "Txt_bono";
            this.Txt_bono.Size = new System.Drawing.Size(100, 22);
            this.Txt_bono.TabIndex = 8;
            this.Txt_bono.TextChanged += new System.EventHandler(this.Txt_bono_TextChanged);
            // 
            // Lbl_desc
            // 
            this.Lbl_desc.AutoSize = true;
            this.Lbl_desc.Location = new System.Drawing.Point(596, 39);
            this.Lbl_desc.Name = "Lbl_desc";
            this.Lbl_desc.Size = new System.Drawing.Size(87, 17);
            this.Lbl_desc.TabIndex = 9;
            this.Lbl_desc.Text = "Descuentos:";
            // 
            // Gpb_operaciones
            // 
            this.Gpb_operaciones.Controls.Add(this.Txt_coddescus);
            this.Gpb_operaciones.Controls.Add(this.Txt_codbonos);
            this.Gpb_operaciones.Controls.Add(this.Btn_ingresardescuento);
            this.Gpb_operaciones.Controls.Add(this.Btn_ingresarbono);
            this.Gpb_operaciones.Controls.Add(this.Txt_descuentos);
            this.Gpb_operaciones.Controls.Add(this.Cmb_Descuentos);
            this.Gpb_operaciones.Controls.Add(this.Txt_bono);
            this.Gpb_operaciones.Controls.Add(this.Lbl_desc);
            this.Gpb_operaciones.Controls.Add(this.Lbl_bonos);
            this.Gpb_operaciones.Controls.Add(this.Cmb_Bonos);
            this.Gpb_operaciones.Location = new System.Drawing.Point(39, 325);
            this.Gpb_operaciones.Name = "Gpb_operaciones";
            this.Gpb_operaciones.Size = new System.Drawing.Size(1064, 100);
            this.Gpb_operaciones.TabIndex = 10;
            this.Gpb_operaciones.TabStop = false;
            this.Gpb_operaciones.Text = "Operaciones";
            // 
            // Txt_coddescus
            // 
            this.Txt_coddescus.Location = new System.Drawing.Point(816, 61);
            this.Txt_coddescus.Name = "Txt_coddescus";
            this.Txt_coddescus.Size = new System.Drawing.Size(100, 22);
            this.Txt_coddescus.TabIndex = 124;
            // 
            // Txt_codbonos
            // 
            this.Txt_codbonos.Location = new System.Drawing.Point(205, 61);
            this.Txt_codbonos.Name = "Txt_codbonos";
            this.Txt_codbonos.Size = new System.Drawing.Size(100, 22);
            this.Txt_codbonos.TabIndex = 123;
            // 
            // Btn_ingresardescuento
            // 
            this.Btn_ingresardescuento.Location = new System.Drawing.Point(922, 27);
            this.Btn_ingresardescuento.Name = "Btn_ingresardescuento";
            this.Btn_ingresardescuento.Size = new System.Drawing.Size(85, 35);
            this.Btn_ingresardescuento.TabIndex = 122;
            this.Btn_ingresardescuento.Text = "Ingresar";
            this.Btn_ingresardescuento.UseVisualStyleBackColor = true;
            this.Btn_ingresardescuento.Click += new System.EventHandler(this.Btn_ingresardescuento_Click);
            // 
            // Btn_ingresarbono
            // 
            this.Btn_ingresarbono.Location = new System.Drawing.Point(343, 28);
            this.Btn_ingresarbono.Name = "Btn_ingresarbono";
            this.Btn_ingresarbono.Size = new System.Drawing.Size(85, 35);
            this.Btn_ingresarbono.TabIndex = 121;
            this.Btn_ingresarbono.Text = "Ingresar";
            this.Btn_ingresarbono.UseVisualStyleBackColor = true;
            this.Btn_ingresarbono.Click += new System.EventHandler(this.Btn_ingresarbono_Click);
            // 
            // Txt_descuentos
            // 
            this.Txt_descuentos.Location = new System.Drawing.Point(816, 34);
            this.Txt_descuentos.Name = "Txt_descuentos";
            this.Txt_descuentos.Size = new System.Drawing.Size(100, 22);
            this.Txt_descuentos.TabIndex = 11;
            // 
            // Cmb_Descuentos
            // 
            this.Cmb_Descuentos.FormattingEnabled = true;
            this.Cmb_Descuentos.Location = new System.Drawing.Point(689, 36);
            this.Cmb_Descuentos.Name = "Cmb_Descuentos";
            this.Cmb_Descuentos.Size = new System.Drawing.Size(121, 24);
            this.Cmb_Descuentos.TabIndex = 10;
            this.Cmb_Descuentos.SelectedIndexChanged += new System.EventHandler(this.Cmb_Descuentos_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 123;
            this.button1.Text = "Completado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(942, 1);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(35, 35);
            this.Btn_ayuda.TabIndex = 103;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Frm_Nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gpb_operaciones);
            this.Controls.Add(this.Gpb_Datosemp);
            this.Controls.Add(this.Gpb_datosgenerales);
            this.Controls.Add(this.Pnl_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Nominas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Nominas";
            this.Load += new System.EventHandler(this.Frm_Nominas_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.Pnl_principal.PerformLayout();
            this.Gpb_datosgenerales.ResumeLayout(false);
            this.Gpb_datosgenerales.PerformLayout();
            this.Gpb_Datosemp.ResumeLayout(false);
            this.Gpb_Datosemp.PerformLayout();
            this.Gpb_operaciones.ResumeLayout(false);
            this.Gpb_operaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox Gpb_datosgenerales;
        private System.Windows.Forms.TextBox Txt_coddoc;
        private System.Windows.Forms.Label Lbl_fechaemision;
        private System.Windows.Forms.Label Lbl_codnomina;
        private System.Windows.Forms.DateTimePicker Dtp_FechaEmi;
        private System.Windows.Forms.GroupBox Gpb_Datosemp;
        private System.Windows.Forms.TextBox Txt_sueldobase;
        private System.Windows.Forms.Label Lbl_sueldobase;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label Lbl_puesto;
        private System.Windows.Forms.TextBox Txt_numerocuenta;
        private System.Windows.Forms.Label Lbl_numerocuenta;
        private System.Windows.Forms.TextBox Txt_dias;
        private System.Windows.Forms.TextBox Txt_codempleado;
        private System.Windows.Forms.Label Lbl_diastrabajados;
        private System.Windows.Forms.Label Lbl_datosemp;
        private System.Windows.Forms.Button Btn_consultaEmp;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Label Lbl_bonos;
        private System.Windows.Forms.ComboBox Cmb_Bonos;
        private System.Windows.Forms.TextBox Txt_bono;
        private System.Windows.Forms.Label Lbl_desc;
        private System.Windows.Forms.GroupBox Gpb_operaciones;
        private System.Windows.Forms.TextBox Txt_descuentos;
        private System.Windows.Forms.ComboBox Cmb_Descuentos;
        private System.Windows.Forms.Button Btn_ingresardescuento;
        private System.Windows.Forms.Button Btn_ingresarbono;
        private System.Windows.Forms.TextBox Txt_sueldoliquido;
        private System.Windows.Forms.Label Lbl_sueldoliquido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_coddescus;
        private System.Windows.Forms.TextBox Txt_codbonos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}