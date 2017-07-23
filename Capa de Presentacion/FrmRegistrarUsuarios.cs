using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogicaNegocio;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace Capa_de_Presentacion
{
    public partial class FrmRegistrarUsuarios : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsUsuarios U = new clsUsuarios();

        public FrmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            U.Usuario = txtUser.Text;
            U.Contrasenha = txtPassword.Text;
            U.IdEmpleado = Convert.ToString(cboEmpleado.SelectedValue);
            U.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);
            U.Estado = checkBoxEstado.Checked;

            Mensaje = U.RegistrarUsuarios();


            if (Mensaje == "Este usuario ya existe")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void CargarComboEmpleado()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT idempleado, nombres+' '+apellidos as NombreCompleto FROM EMPLEADOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cboEmpleado.DisplayMember = "NombreCompleto";
                cboEmpleado.ValueMember = "IdEmpleado";
                cboEmpleado.DataSource = dt;

            }

        }

        private void CargarTipoUsuario()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=POSIX;Integrated Security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM TIPOS_USUARIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cboTipoUsuario.DisplayMember = "TipoUsuario";
                cboTipoUsuario.ValueMember = "IdTipoUsuario";
                cboTipoUsuario.DataSource = dt;

            }

        }


        private void FrmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            CargarComboEmpleado();
            CargarTipoUsuario();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            groupBoxUsuario.Enabled = true;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "";
            this.txtPassword.Text = "";
            this.cboEmpleado.SelectedValue = -1;
           
        }
    }
}