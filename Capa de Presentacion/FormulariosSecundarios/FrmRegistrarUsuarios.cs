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

        String Mensaje = "";

        public FrmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
            U.Usuario = txtUser.Text;
            U.Contrasenha = txtPassword.Text;
            U.IdEmpleado = Convert.ToString(cboEmpleado.SelectedValue);
            U.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);
            U.Estado = checkBoxEstado.Checked;

            ValidacionUsuarios();
            

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
            Guardar_Usuario.Enabled = true;
            txtUser.Focus();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "";
            this.txtPassword.Text = "";
            this.cboEmpleado.SelectedValue = -1;

            errorProviderUsuarios.SetError(txtUser, "");
            errorProviderUsuarios.SetError(txtPassword, "");


            this.txtUser.Focus();
            
        }

        private void ValidacionUsuarios()
        {
            if (txtUser.Text == "")
            {
                errorProviderUsuarios.SetError(txtUser, "No puede dejar este campo vacio");
                txtUser.Focus();
                return;
            }
            
            else
            {
                errorProviderUsuarios.SetError(txtUser, "");
                if (txtPassword.Text == "")
                {
                    errorProviderUsuarios.SetError(txtPassword, "No puede dejar vacio este campo");
                    txtPassword.Focus();
                    return;
                }
                else
                {                   
                    errorProviderUsuarios.SetError(txtPassword, "");
                    Mensaje = U.RegistrarUsuarios();

                    if (Mensaje == "Este usuario ya existe")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProviderUsuarios.SetError(txtUser, "error");
                        DevComponents.DotNetBar.MessageBoxEx.Show("Verifique el RTN ingresado", "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Focus();
                        return;
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUser.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }
        }

    }
}