using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CapaLogicaNegocio;
using System.Data.SqlClient;

namespace Capa_de_Presentacion
{
    public partial class FrmRegistroProductos : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCategoria C = new clsCategoria();
        private clsProducto P = new clsProducto();
        

        public FrmRegistroProductos()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //validarcamposvacios();
            String Mensaje = "";
            P.Cod_Barra = txtCodigoBarra.Text;
            P.NombreProducto = txtProducto.Text;
            P.Unidad_Exis = Convert.ToInt32(cant_existencia.Value);
            P.Existencia_Min = Convert.ToInt32(cant_existencia_min.Value);
            P.Precio_Costo = Convert.ToDecimal(txtPrecioCosto.Text);
            P.Precio_Venta1 = Convert.ToDecimal(txtPrecioVenta1.Text);
            P.Precio_Venta2 = Convert.ToDecimal(txtPrecioVenta2.Text);
            P.Precio_Venta3 = Convert.ToDecimal(txtPrecioVenta3.Text);
            P.Precio_Venta4 = Convert.ToDecimal(txtPrecioVenta4.Text);
            if (chkISV.Checked == true)
            {
                P.ISV = true;
            }
            else
            {
                P.ISV = false;
            }
            P.Fecha_Ingreso = dtpFechaingreso.Value;
            P.Fecha_Caduc = dtpFechaVencimiento.Value;
            P.Imagen = "NULL";
            P.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
            P.IdProveedor = Convert.ToInt32(cboProveedor.SelectedValue);
            Mensaje = P.RegistrarProductos();

            if (Mensaje == "Este producto ya existe")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarComboCat()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from CATEGORIAS_PRODUCTOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cboCategoria.DisplayMember = "Categoria";
            cboCategoria.ValueMember = "IdCategoria";
            cboCategoria.DataSource = dt;
        }

        private void cargarComboProveedor()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select IdProveedor,Nombre from PROVEEDORES";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cboProveedor.DisplayMember = "Nombre";
            cboProveedor.ValueMember = "IdProveedor";
            cboProveedor.DataSource = dt;
        }

        private void FrmRegistroProductos_Load(object sender, EventArgs e)
        {
            cargarComboCat();
            cargarComboProveedor();
            //llenarDTGVProductosxD();
        }

        private void txtProducto_Validating(object sender, CancelEventArgs e)
        {
            if(txtProducto.Text == "")
            {
                errorProvider1.SetError(txtProducto, "Este campo no puede quedar vacio");
            }
            else
            {
                errorProvider1.SetError(txtProducto, "");
            }
        }

        void llenarDTGVProductosxD()
        {
            DataTable dt = new DataTable();
            dt = P.MostrarProductos();
            try
            {
                dgvProductos.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvProductos.Rows.Add(dt.Rows[i][0]);
                    dgvProductos.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dgvProductos.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dgvProductos.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dgvProductos.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dgvProductos.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dgvProductos.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dgvProductos.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    //dgvProductos.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvProductos.ClearSelection();
        }

        private void nuevacat_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria c = new FrmRegistrarCategoria();
            c.Show();   
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void nuevo_MouseEnter(object sender, EventArgs e)
        {
            nuevo.Cursor = Cursors.Hand;
        }
    }
}
