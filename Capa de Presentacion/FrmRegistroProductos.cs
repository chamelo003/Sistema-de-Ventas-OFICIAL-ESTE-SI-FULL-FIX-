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
        int x, y;
        bool arrastre;

        String Mensaje = "";

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
            String Mensaje;         
            P.Cod_Barra = txtCodigoBarra.Text;
            P.NombreProducto = txtProducto.Text;
            P.Unidad_Exis = Convert.ToInt32(cant_existencia.Value);
            P.Existencia_Min = Convert.ToInt32(cant_existencia_min.Value);
                                                            
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
            
            Validaciones1();           
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            y = e.Y;
            x = e.X;
            arrastre = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            arrastre = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastre)
            {
                // this.Location = this.PointToScreen(new Point(this.MousePosition.X - this.Location.X - x, this.MousePosition.Y - this.Location.Y - y))
            }
        }

        private void nuevo_MouseEnter(object sender, EventArgs e)
        {
            nuevo.Cursor = Cursors.Hand;
        }
      
        private void Validaciones1()
        {            
            if (txtCodigoBarra.Text == "")
            {
                errorProviderProductos.SetError(txtCodigoBarra, "No puede dejar este campo vacio");
                txtCodigoBarra.Focus();
                return;
                             
            }
            else
            {              
                if (txtCodigoBarra.Text.Length < 14)
                {
                    errorProviderProductos.SetError(txtCodigoBarra, "Faltan datos");
                    DevComponents.DotNetBar.MessageBoxEx.Show("Debe ingresar almenos 14 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoBarra.Focus();
                    return;
                }
                else
                {
                    errorProviderProductos.SetError(txtCodigoBarra, "");

                    if (txtProducto.Text == "")
                    {
                        errorProviderProductos.SetError(txtProducto, "No puede dejar este campo vacio");
                        txtProducto.Focus();                                              
                    }
                    else
                    {
                        errorProviderProductos.SetError(txtProducto, "");                       

                        if (cant_existencia.Value == 0)
                        {
                            errorProviderProductos.SetError(cant_existencia, "No puede dejar este campo sin valor");
                            cant_existencia.Focus();
                            return;
                        }
                        else
                        {
                            errorProviderProductos.SetError(cant_existencia, "");

                            if (cant_existencia_min.Value == 0)
                            {
                                errorProviderProductos.SetError(cant_existencia_min, "No puede dejar este campo sin valor");
                                cant_existencia.Focus();
                                return;
                            }
                            else
                            {                               
                                errorProviderProductos.SetError(cant_existencia_min, "");

                                if (txtPrecioCosto.Text == "")
                                {
                                    errorProviderProductos.SetError(txtPrecioCosto, "No puede dejar este campo vacio");
                                    txtPrecioCosto.Focus();
                                    return;
                                }
                                else
                                {
                                    errorProviderProductos.SetError(txtPrecioCosto, "");
                                    if (txtPrecioVenta1.Text == "")
                                    {
                                        errorProviderProductos.SetError(txtPrecioVenta1, "No puede dejar este campo vacio");
                                        txtPrecioVenta1.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        errorProviderProductos.SetError(txtPrecioVenta1, "");

                                        if (txtPrecioVenta2.Text == "")
                                        {
                                            errorProviderProductos.SetError(txtPrecioVenta2, "No puede dejar este campo vacio");
                                            txtPrecioVenta2.Focus();
                                            return;
                                        }
                                        else
                                        {
                                            errorProviderProductos.SetError(txtPrecioVenta2, "");

                                            if (txtPrecioVenta3.Text == "")
                                            {
                                                errorProviderProductos.SetError(txtPrecioVenta3, "No puede dejar este campo vacio");
                                                txtPrecioVenta3.Focus();
                                                return;
                                            }
                                            else
                                            {
                                                errorProviderProductos.SetError(txtPrecioVenta3, "");

                                                if (txtPrecioVenta4.Text == "")
                                                {
                                                    errorProviderProductos.SetError(txtPrecioVenta4, "No puede dejar este campo vacio");
                                                    txtPrecioVenta4.Focus();
                                                    return;
                                                }
                                                else
                                                {
                                                    errorProviderProductos.SetError(txtPrecioVenta4, "");
                                                    Mensaje = P.RegistrarProductos();

                                                    if (Mensaje == "Este producto ya existe")
                                                    {
                                                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        errorProviderProductos.SetError(txtProducto, "Cambie el nombre del producto");
                                                        txtProducto.Focus();
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                                           
                                                        P.Precio_Costo = Convert.ToDecimal(txtPrecioCosto.Text);
                                                        P.Precio_Venta1 = Convert.ToDecimal(txtPrecioVenta1.Text);
                                                        P.Precio_Venta2 = Convert.ToDecimal(txtPrecioVenta2.Text);
                                                        P.Precio_Venta3 = Convert.ToDecimal(txtPrecioVenta3.Text);
                                                        P.Precio_Venta4 = Convert.ToDecimal(txtPrecioVenta4.Text);

                                                        txtCodigoBarra.Text = "";
                                                        txtProducto.Text = "";
                                                        cant_existencia.Value = 0;
                                                        cant_existencia_min.Value = 0;
                                                        txtPrecioCosto.Text = "";
                                                        txtPrecioVenta1.Text = "";
                                                        txtPrecioVenta2.Text = "";
                                                        txtPrecioVenta3.Text = "";
                                                        txtPrecioVenta4.Text = "";
                                                    }                                                                                                   
                                                }
                                            }
                                        }
                                    }
                                }
                            }                                                                                                                                           
                        }                        
                    }                    
                }
            }         
        }       

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProviderProductos.SetError(txtPrecioCosto, "Solo se permiten numeros");
                txtPrecioCosto.Focus();
                return;
            }
        }

      
        private void txtPrecioVenta1_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProviderProductos.SetError(txtPrecioVenta1, "Solo se permiten numeros");
                txtPrecioVenta1.Focus();
                return;
            }
        }

      
        private void txtPrecioVenta2_KeyPress(object sender, KeyPressEventArgs e)
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
                  errorProviderProductos.SetError(txtPrecioVenta2, "Solo se permiten numeros");
                  txtPrecioVenta2.Focus();
                  return;
             }
        }
      
        private void txtPrecioVenta3_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProviderProductos.SetError(txtPrecioVenta3, "Solo se permiten numeros");
                txtPrecioVenta3.Focus();
                return;
            }
        }

        private void txtPrecioVenta4_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProviderProductos.SetError(txtPrecioVenta3, "Solo se permiten numeros");
                txtPrecioVenta3.Focus();
                return;
            }
        }
    }
}

 