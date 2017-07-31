using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace Capa_de_Presentacion.DialogForms
{
    public partial class ShowClientes : Form
    {
        public ShowClientes()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private clsCliente C = new clsCliente();

        int Listado = 0;


        private void ShowClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        #region funciones
        private void ListarClientes()
        {
            DataTable dt = new DataTable();
            dt = C.MostrarClientes();
            try
            {
                dgvClientes.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvClientes.Rows.Add(dt.Rows[i][0]);
                    dgvClientes.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvClientes.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dgvClientes.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dgvClientes.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dgvClientes.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dgvClientes.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dgvClientes.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dgvClientes.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                    dgvClientes.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    dgvClientes.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                }
                dgvClientes.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }

        #endregion
    }
}
