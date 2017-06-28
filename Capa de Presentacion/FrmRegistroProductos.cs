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
    public partial class FrmRegistroProductos : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCategoria C = new clsCategoria();
        private clsProducto P = new clsProducto();

        public FrmRegistroProductos()
        {
            InitializeComponent();
        }

        private void FrmRegistroProductos_Load(object sender, EventArgs e)
        {
            ListarElementos();
        }

        private void ListarElementos() {
            if (IdC.Text.Trim() != "")
            {
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DataSource = C.Listar();
                cboCategoria.SelectedValue = IdC.Text;
            }
            else
            {
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DataSource = C.Listar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            if (txtProducto.Text.Trim() != "")
            {
                if (txtMarca.Text.Trim() != "")
                {
                    if (txtPreCompra.Text.Trim() != "")
                    {
                        if (txtPrecioVenta1.Text.Trim() != "")
                        {
                            if (txtExistencia.Text.Trim() != "")
                            {
                                if (Program.Evento == 0)
                                {
                                    P.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                                    P.Producto = txtProducto.Text;
                                    P.Marca = txtMarca.Text;
                                    P.PrecioCompra = Convert.ToDecimal(txtPreCompra.Text);
                                    P.PrecioVenta = Convert.ToDecimal(txtPrecioVenta1.Text);
                                    P.Stock = Convert.ToInt32(txtExistencia.Text);
                                    P.FechaVencimiento = Convert.ToDateTime(dtpFechaVencimiento.Value);
                                    Mensaje = P.RegistrarProductos();
                                    if (Mensaje == "Este Producto ya ha sido Registrado."){
                                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }else{
                                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Limpiar();
                                    }
                                }
                                else
                                {
                                    P.IdP = Convert.ToInt32(txtIdP.Text);
                                    P.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                                    P.Producto = txtProducto.Text;
                                    P.Marca = txtMarca.Text;
                                    P.PrecioCompra = Convert.ToDecimal(txtPreCompra.Text);
                                    P.PrecioVenta = Convert.ToDecimal(txtPrecioVenta1.Text);
                                    P.Stock = Convert.ToInt32(txtExistencia.Text);
                                    P.FechaVencimiento = Convert.ToDateTime(dtpFechaVencimiento.Value);
                                    DevComponents.DotNetBar.MessageBoxEx.Show(P.ActualizarProductos(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Stock del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtExistencia.Focus();
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Precio de Venta del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPrecioVenta1.Focus();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Precio de Compra del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPreCompra.Focus();
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Marca del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarca.Focus();
                }
            }
            else {
                DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Nombre del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProducto.Focus();
            }
            FrmListadoProductos LP = new FrmListadoProductos();
            LP.timer1.Start();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria C = new FrmRegistrarCategoria();
            C.Show();
        }

        private void Limpiar() {
            txtProducto.Text = "";
            txtMarca.Clear();
            txtPreCompra.Clear();
            txtPrecioVenta1.Clear();
            IdC.Clear();
            txtIdP.Clear();
            txtExistencia.Clear();
            dtpFechaVencimiento.Value = DateTime.Now;
            txtProducto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPreCompra.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtPVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPrecioVenta1.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                } 
        }

    

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
