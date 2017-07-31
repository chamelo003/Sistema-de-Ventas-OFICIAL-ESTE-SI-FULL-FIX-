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
using System.Net.Mail;

namespace Capa_de_Presentacion
{
    public partial class FrmRegistroCliente : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCliente C = new clsCliente();
        String Mensaje;

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


            ValidacionesClientes();


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

                if (cboDepto.Items.Count != 0)
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

        private void nuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void Nuevo_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            Guardar.Enabled = true;
            mktRTN.Focus();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {          
            cargarComboDepto();
            cargarComboSexo();
            ListarClientes();
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
            if (D.IsDisposed == true)
            {
                cargarComboDepto();
            }
        }

        private void aggMuni_Click(object sender, EventArgs e)
        {
            FrmMunicipio M = new FrmMunicipio();
            M.ShowDialog();
            if (M.IsDisposed == true)
            {
                IdDepto = Convert.ToInt32(cboDepto.SelectedValue);
                cargarComboMunicipio(IdDepto);
            }
        }

        private void ValidacionesClientes()
        {
            if (mktRTN.Text == "")
            {
                errorProviderClientes.SetError(mktRTN, "No puede dejar este campo vacio");
                mktRTN.Focus();
                return;
            }
            else
            {
                errorProviderClientes.SetError(mktRTN, "");

                if (mktRTN.MaskCompleted==false)
                {
                    errorProviderClientes.SetError(mktRTN, "Faltan caracteres");
                    mktRTN.Focus();
                    return;
                }
                else
                {
                    errorProviderClientes.SetError(mktRTN, "");

                    if (txtNombres.Text == "")
                    {
                        errorProviderClientes.SetError(txtNombres, "No puede dejar este campo vacio");
                        txtNombres.Focus();
                        return;
                    }
                    else
                    {
                        errorProviderClientes.SetError(txtNombres, "");

                        if (txtApellidos.Text == "")
                        {
                            errorProviderClientes.SetError(txtApellidos, "No puede dejar este campo vacio");
                            txtApellidos.Focus();
                            return;
                        }
                        else
                        {
                            errorProviderClientes.SetError(txtApellidos, "");

                            if (mktCelular.Text == "")
                            {
                                errorProviderClientes.SetError(mktCelular, "No puede dejar este campo vacio");
                                txtApellidos.Focus();
                                return;
                            }
                            else
                            {
                                errorProviderClientes.SetError(mktCelular, "");

                                if (mktCelular.MaskCompleted==false)
                                {
                                    errorProviderClientes.SetError(mktCelular, "Falta caracteres");
                                    mktCelular.Focus();
                                    return;
                                }
                                else
                                {
                                    errorProviderClientes.SetError(mktCelular, "");

                                    if (txtCorreo.Text == "")
                                    {
                                        errorProviderClientes.SetError(txtCorreo, "No puede dejar este campo vacio");
                                        txtCorreo.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        errorProviderClientes.SetError(txtCorreo, "");
                                        Mensaje = C.RegistrarCliente();

                                        if (Mensaje == "Este cliente ya existe")
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            errorProviderClientes.SetError(mktRTN,"error");
                                            DevComponents.DotNetBar.MessageBoxEx.Show("Verifique el RTN ingresado", "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            mktRTN.Focus();
                                            return;
                                        }
                                        else
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            mktRTN.Text = "";
                                            txtNombres.Text = "";
                                            txtApellidos.Text = "";
                                            mktTelefono.Text = "";
                                            mktCelular.Text = "";
                                            txtCorreo.Text = "";
                                            txtDireccion.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void mktRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProviderClientes.SetError(mktRTN, "Solo se permiten numeros");
                mktRTN.Focus();
                return;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            
            mktRTN.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            mktTelefono.Text = "";
            mktCelular.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";

            errorProviderClientes.SetError(mktRTN, "");
            errorProviderClientes.SetError(txtNombres, "");
            errorProviderClientes.SetError(txtApellidos, "");
            errorProviderClientes.SetError(mktTelefono, "");
            errorProviderClientes.SetError(mktCelular, "");
            errorProviderClientes.SetError(txtCorreo, "");
            errorProviderClientes.SetError(txtDireccion, "");

            mktRTN.Focus();

        }

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


    }
}