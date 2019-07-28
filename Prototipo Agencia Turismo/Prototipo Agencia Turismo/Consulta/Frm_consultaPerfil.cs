<<<<<<< HEAD
﻿using System;
=======
﻿/* 
 -----------------------------------------------------
            AUTOR: Edson Juarez
  -----------------------------------------------------
*/


using System;
>>>>>>> Integracion-Ivan-José
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using System.Data.Odbc;
>>>>>>> Integracion-Ivan-José

namespace Prototipo_Agencia_Turismo.Consulta
{
    public partial class Frm_consultaPerfil : Form
    {
<<<<<<< HEAD
=======
        string consultaPerfil = " ";

>>>>>>> Integracion-Ivan-José
        public Frm_consultaPerfil()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
<<<<<<< HEAD
=======

        private void Frm_consultaPerfil_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaPerfil.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CargarDatos()
        {
            try
            {
                consultaPerfil = "SELECT * FROM tbl_perfil WHERE estado = 1;";
                OdbcCommand comm = new OdbcCommand(consultaPerfil, Conexion.nuevaConexion());
                OdbcDataReader cargarDgv = comm.ExecuteReader();

                while (cargarDgv.Read())
                {
                    Dgv_consultaPerfil.Refresh();
                    Dgv_consultaPerfil.Rows.Add(cargarDgv.GetString(0), cargarDgv.GetString(1),
                        cargarDgv.GetString(2), cargarDgv.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaPerfil.Rows.Clear();
            CargarDatos();
        }

        private void Btn_consultaPerfil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_consultaPerfil.Text.Trim()) == false)
            {
                Dgv_consultaPerfil.Rows.Clear();

                try
                {
                    consultaPerfil = "SELECT * FROM tbl_perfil WHERE nombre_Perfil LIKE ('%" + Txt_consultaPerfil.Text.Trim() + "%') AND estado = 1;";
                    OdbcCommand comm = new OdbcCommand(consultaPerfil, Conexion.nuevaConexion());
                    OdbcDataReader cargarDgv = comm.ExecuteReader();

                    while (cargarDgv.Read())
                    {
                        Dgv_consultaPerfil.Refresh();
                        Dgv_consultaPerfil.Rows.Add(cargarDgv.GetString(0), cargarDgv.GetString(1),
                            cargarDgv.GetString(2), cargarDgv.GetString(3));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado ningún campo");
            }
        }
>>>>>>> Integracion-Ivan-José
    }
}
