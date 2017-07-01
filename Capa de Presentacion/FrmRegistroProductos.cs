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

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }

        private void validarcamposvacios()
        {
            
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            P.Cod_Barra = Convert.ToInt32(txtCodigoBarra.Text);
            P.NombreProducto = txtProducto.Text;
            P.Unidad_Exis = Convert.ToInt32(cant_existencia.Value);
            P.Existencia_Min = Convert.ToInt32(cant_existencia_min.Value);
            P.IdCategoria = Convert.ToInt32(cboCategoria.ValueMember);
            P.IdProveedor = Convert.ToInt32(cboProveedor.ValueMember);
            P.Fecha_Ingreso = dtpFechaingreso.Value;
            P.Fecha_Caduc = dtpFechaVencimiento.Value;
            P.Precio_Costo = Convert.ToDecimal(txtPrecioCosto.Text);
            P.Precio_Venta1 = Convert.ToDecimal(txtPrecioVenta1.Text);
            P.Precio_Venta2 = Convert.ToDecimal(txtPrecioVenta2.Text);
            P.Precio_Venta3 = Convert.ToDecimal(txtPrecioVenta3.Text);
            P.Precio_Venta4 = Convert.ToDecimal(txtPrecioVenta4.Text);

            try
            {
                validarcamposvacios();

            }
            catch (SqlException ex)
            {

                throw ex;
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
        }
    }
}
