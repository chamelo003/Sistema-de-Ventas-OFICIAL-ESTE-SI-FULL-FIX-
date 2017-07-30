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

namespace Capa_de_Presentacion
{
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsUsuarios U = new clsUsuarios();
        public String u;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está seguro que desea salir.?", "POSIX", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                Application.Exit();
            }
               
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "")
            {
                if (txtPassword.Text.Trim() != "")
                {
                    String Mensaje = "";
                    U.m_Usuario = txtUser.Text;
                    U.m_Contrasenha = txtPassword.Text;
                    Mensaje = U.IniciarSesion();
                    if (Mensaje == "Su contraseña es incorrecta.")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                    else
                        if (Mensaje == "El nombre de usuario no existe.")
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            txtUser.Clear();
                            txtPassword.Clear();
                            txtUser.Focus();
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            frmMDI MP = new frmMDI();
                            RecuperarDatosSesion();
                            MP.Show();
                            this.Hide();
                        }
                }else {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por favor ingrese su contraseña.","Sistema de Ventas.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }else{
                DevComponents.DotNetBar.MessageBoxEx.Show("Por favor ingrese nombre de usuario.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                }
        }
        private void RecuperarDatosSesion()
        {
            DataRow row;
            DataTable dt = new DataTable();
            dt = U.DevolverDatosSesion(txtUser.Text, txtPassword.Text);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                Program.IdEmpleadoLogueado = row[0].ToString();
                Program.NombreEmpleadoLogueado = row[1].ToString();
            }
        }
    }
}
