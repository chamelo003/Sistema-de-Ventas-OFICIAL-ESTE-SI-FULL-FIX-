using System;
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
    public partial class FrmDepartamento : Form
    {
        private ClsDepto D = new ClsDepto();
        public FrmDepartamento()
        {
            InitializeComponent();
        }
        private void Guardar_MouseEnter(object sender, EventArgs e)
        {
            Guardar.Cursor = Cursors.Hand;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (txtDepto.Text.Trim() != "")
            {
                String Mensaje = "";
                D.Depto = txtDepto.Text;
                Mensaje = D.RegistrarDepto();
                if (Mensaje == "Departamento agregado exitosamente.")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            llenarDgvDepto();
            txtDepto.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            llenarDgvDepto();
        }

        private void llenarDgvDepto()
        {
            DataTable dt = new DataTable();
            dt = D.MostrarDeptos();
            try
            {
                dgvDepartamento.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvDepartamento.Rows.Add(dt.Rows[i][0]);
                    dgvDepartamento.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvDepartamento.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvDepartamento.ClearSelection();
        }
    }
}
