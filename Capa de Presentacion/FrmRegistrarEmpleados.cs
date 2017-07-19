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
    public partial class FrmRegistrarEmpleados : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsCargo C = new clsCargo();
        clsEmpleado E = new clsEmpleado();
        int Listado = 0;
        public FrmRegistrarEmpleados()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            E.IdEmpleado = mktCodEmpleado.Text;
            E.Nombres = txtNombres.Text;
            E.Apellidos = txtApellidos.Text;
            E.Telefono = mktTelefono.Text;
            E.Celular = mktCelular.Text;
            E.Direccion = txtDireccion.Text;
            E.IdMunicipio = Convert.ToInt32(cboMunicipio.SelectedValue);
            E.IdCargo = Convert.ToInt32(cboCargo.SelectedValue);
            E.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
            Mensaje = E.RegistrarEmpleado();
            if (Mensaje == "Empleado agregado exitosamente")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void llenarComboCargo()
        {
            DataTable dt = new DataTable();
            using(SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String query = "SELECT * FROM CARGOS_EMPLEADOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cboCargo.DisplayMember = "Cargo";
                cboCargo.ValueMember = "IdCargo";
                cboCargo.DataSource = dt;

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

        private void cargarComboSexo()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from SEXO";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cboSexo.DisplayMember = "Sexo";
                cboSexo.ValueMember = "IdSexo";
                cboSexo.DataSource = dt;
            }
        }

        private void Nuevo_MouseEnter(object sender, EventArgs e)
        {
            Nuevo.Cursor = Cursors.Hand;
        }

        private void Guardar_MouseEnter(object sender, EventArgs e)
        {
            Guardar.Cursor = Cursors.Hand;
        }

        private void FrmRegistrarEmpleados_Load(object sender, EventArgs e)
        {
            cargarComboDepto();
            llenarComboCargo();
            cargarComboSexo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void agregarMunicipio_Click(object sender, EventArgs e)
        {
            FrmMunicipio M = new FrmMunicipio();
            M.ShowDialog();
        }

        private void agregarDepto_Click(object sender, EventArgs e)
        {
            FrmDepartamento D = new FrmDepartamento();
            D.ShowDialog();
        }
    }
}
