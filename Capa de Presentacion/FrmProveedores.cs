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
    public partial class FrmProveedores : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsProveedores P = new clsProveedores();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            mktRTN.Focus();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            P.RTN = mktRTN.Text;
            P.Nombre = txtNombre.Text;
            P.Direccion = txtDireccion.Text;
            P.IdMunicipio = Convert.ToInt32(cboMunicipio.SelectedValue);
            P.IdTipoProveedor = Convert.ToInt32(cbotipoProveedor.SelectedValue);
            P.Contacto = txtContacto.Text;
            P.TelefContacto = mktTelefonoContacto.Text;
            P.Correo = txtCorreo.Text;
            String Mensaje = "";
            Mensaje = P.RegistrarProveedor();
            if (Mensaje == "Proveedor agregado exitosamente.")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void llenarComboTipoProveedor()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String query = "SELECT * FROM TIPO_PROVEEDOR";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbotipoProveedor.DisplayMember = "TipoProveedor";
                cbotipoProveedor.ValueMember = "IdTipoProveedor";
                cbotipoProveedor.DataSource = dt;
            }

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

                if (cboDepto.Items.Count != 0)
                {
                    int idDepto = Convert.ToInt32(cboDepto.SelectedValue);
                    cargarComboMunicipio(idDepto);
                }
                else
                {
                    cboMunicipio.DataSource = null;
                }
            }
        }

        private void cargarComboMunicipio(int idDepto)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from MUNICIPIO WHERE IdDepto = " + idDepto;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cboMunicipio.DisplayMember = "Municipio";
                cboMunicipio.ValueMember = "IdMunicipio";
                cboMunicipio.DataSource = dt;
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cargarComboDepto();
            llenarComboTipoProveedor();
        }

        private void Nuevo_MouseEnter(object sender, EventArgs e)
        {
            Nuevo.Cursor = Cursors.Hand;
        }
    }
}
