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
    public partial class FrmRegistroCliente : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCliente C = new clsCliente();

        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            C.RTN = mktRTN.Text;
            C.Nombres = txtNombres.Text;
            C.Apellidos = txtApellidos.Text;
            C.Telefono = mktTelefono.Text;
            C.Celular = mktCelular.Text;
            C.Correo = txtCorreo.Text;
            C.IdMunicipio = Convert.ToInt32(cboMunicipio.SelectedValue);
            C.Direccion = txtDireccion.Text;
            C.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);

            Mensaje = C.RegistrarCliente();

            if (Mensaje == "Este cliente ya existe")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        int IdDepto;
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

                if(cboDepto.Items.Count != 0)
                {
                    IdDepto = Convert.ToInt32(cboDepto.SelectedValue);
                    cargarComboMunicipio(IdDepto);
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
                string query = "select * from MUNICIPIO WHERE IdDepto = "+ idDepto;
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

        private void nuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void Nuevo_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            cargarComboDepto();
            cargarComboSexo();
        }

        private void cboDepto_SelectedValueChanged(object sender, EventArgs e)
        {
            IdDepto = Convert.ToInt32(cboDepto.SelectedValue);
            cargarComboMunicipio(IdDepto);
        }

        private void aggDepto_Click(object sender, EventArgs e)
        {
            FrmDepartamento D = new FrmDepartamento();
            D.ShowDialog();
            if(D.IsDisposed == true)
            {
                cargarComboDepto();                
            }
        }

        private void aggMuni_Click(object sender, EventArgs e)
        {
            FrmMunicipio M = new FrmMunicipio();
            M.ShowDialog();
            if(M.IsDisposed == true)
            {
                IdDepto = Convert.ToInt32(cboDepto.SelectedValue);
                cargarComboMunicipio(IdDepto);
            }
        }

        
    }
}
