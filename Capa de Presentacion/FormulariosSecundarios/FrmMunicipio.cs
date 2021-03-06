﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaLogicaNegocio;
using System.Data.SqlClient;

namespace Capa_de_Presentacion
{
    public partial class FrmMunicipio : Form
    {
        private clsMunicipio M = new clsMunicipio();
        private ClsDepto D = new ClsDepto();
        public FrmMunicipio()
        {
            InitializeComponent();
        }

        private void Guardar_MouseEnter(object sender, EventArgs e)
        {
            Guardar.Cursor = Cursors.Hand;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if(txtMunicipio.Text.Trim() != "")
            {
                String Mensaje = "";
                M.Municipio = txtMunicipio.Text;
                M.IdDepto = Convert.ToInt32(cboDepto.SelectedValue);
                Mensaje = M.RegistrarMunicipio();
                if (Mensaje == "Municipio agregado exitosamente.")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            llenarDgvMuni();
            txtMunicipio.Clear();
        }
        private void cargarComboDepto()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from DEPARTAMENTO";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cboDepto.DisplayMember = "Departamento";
                cboDepto.ValueMember = "IdDepto";
                cboDepto.DataSource = dt;
            }
        }

        private void llenarDgvMuni()
        {

            DataTable dt = new DataTable();
            dt = D.MostrarDeptos();
            try
            {
                dgvMunicipio.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvMunicipio.Rows.Add(dt.Rows[i][0]);
                    dgvMunicipio.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvMunicipio.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dgvMunicipio.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvMunicipio.ClearSelection();
        }

        private void FrmMunicipio_Load(object sender, EventArgs e)
        {
            cargarComboDepto();
            llenarDgvMuni();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
