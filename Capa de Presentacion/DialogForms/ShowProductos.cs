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
    public partial class ShowProductos : Form
    {
        private clsProducto P = new clsProducto();
        public ShowProductos()
        {
            InitializeComponent();
        }

        private void CargarListado()
        {
            DataTable dt = new DataTable();
            dt = P.MostrarProductos();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString(); //id
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString(); //codbarra
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString(); //nombre
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString(); //unidad exis
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString(); // existencia min
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString(); //precio costo
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString(); //pventa1
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString(); //pventa2
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString(); //pventa3
                    dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString(); //pventa4
                    dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString(); //isv
                    dataGridView1.Rows[i].Cells[11].Value = Convert.ToDateTime(dt.Rows[i][11].ToString()); //fecha ingreso
                    dataGridView1.Rows[i].Cells[12].Value = Convert.ToDateTime(dt.Rows[i][12].ToString()); // fecha vencimiento
                    dataGridView1.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString(); //foto
                    dataGridView1.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString(); //proveedor
                    dataGridView1.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString(); //categoira
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

        private void ShowProductos_Load(object sender, EventArgs e)
        {
            CargarListado();
        }
    }
}
