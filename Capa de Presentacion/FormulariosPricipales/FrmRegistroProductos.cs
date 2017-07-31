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
            P.Precio_Costo = Convert.ToDecimal(txtPrecioCosto.Text);
            P.Precio_Venta1 = Convert.ToDecimal(txtPrecioVenta1.Text);
            P.Precio_Venta2 = Convert.ToDecimal(txtPrecioVenta2.Text);
            P.Precio_Venta3 = Convert.ToDecimal(txtPrecioVenta3.Text);
            P.Precio_Venta4 = Convert.ToDecimal(txtPrecioVenta4.Text);
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
            // TODO: This line of code loads data into the 'pOSIXPrecioProduct.PRODUCTOS' table. You can move, or remove it, as needed.
            cargarComboCat();
            cargarComboProveedor();
            CargarListado();
        }


        private void CargarListado()
        {
            DataTable dt = new DataTable();
            dt = P.MostrarProductos();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString(); //id
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString(); //codbarra
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString(); //nombre
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString(); //unidad exis
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString(); // existencia min
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString(); //precio costo
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString(); //pventa1
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString(); //pventa2
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString(); //pventa3
                    dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString(); //pventa4
                    dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString(); //isv
                    dataGridView1.Rows[i].Cells[11].Value = Convert.ToDateTime(dt.Rows[i][11].ToString()); //fecha ingreso
                    dataGridView1.Rows[i].Cells[12].Value = Convert.ToDateTime(dt.Rows[i][12].ToString()); // fecha vencimiento
                    dataGridView1.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString(); //foto
                    dataGridView1.Rows[i].Cells[14].Value = dt.Rows[i][14].ToString(); //proveedor
                    dataGridView1.Rows[i].Cells[15].Value = dt.Rows[i][15].ToString(); //categoira
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

        private void nuevacat_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria c = new FrmRegistrarCategoria();
            c.Show();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            guardar.Enabled = true;
            txtCodigoBarra.Focus();
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
                if (txtCodigoBarra.Text.Length < 13)
                {
                    errorProviderProductos.SetError(txtCodigoBarra, "Faltan datos");
                    DevComponents.DotNetBar.MessageBoxEx.Show("Debe ingresar 13 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cancelar_Click(object sender, EventArgs e)
        {
            txtCodigoBarra.Text = "";
            txtProducto.Text = "";
            cant_existencia.Value = 0;
            cant_existencia_min.Value = 0;
            txtPrecioCosto.Text = "";
            txtPrecioVenta1.Text = "";
            txtPrecioVenta2.Text = "";
            txtPrecioVenta3.Text = "";
            txtPrecioVenta4.Text = "";

            errorProviderProductos.SetError(txtCodigoBarra, "");
            errorProviderProductos.SetError(txtProducto, "");
            errorProviderProductos.SetError(cant_existencia, "");
            errorProviderProductos.SetError(cant_existencia_min, "");
            errorProviderProductos.SetError(txtPrecioCosto, "");
            errorProviderProductos.SetError(txtPrecioVenta1, "");
            errorProviderProductos.SetError(txtPrecioVenta2, "");
            errorProviderProductos.SetError(txtPrecioVenta3, "");
            errorProviderProductos.SetError(txtPrecioVenta4, "");

            txtCodigoBarra.Focus();


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

 