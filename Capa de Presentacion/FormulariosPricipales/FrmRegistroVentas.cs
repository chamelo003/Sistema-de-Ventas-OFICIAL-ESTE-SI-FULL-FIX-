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
    public partial class FrmRegistroVentas : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsVentas Ventas = new clsVentas();
        clsDetalleVenta Detalle = new clsDetalleVenta();

        private List<clsVenta> lst = new List<clsVenta>();

        public FrmRegistroVentas()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            DialogForms.ShowClientes c = new DialogForms.ShowClientes();
            c.ShowDialog();
            txtRTN.Text = Convert.ToString(c.dgvClientes.CurrentRow.Cells[1].Value);
            txtnombre.Text = Convert.ToString(c.dgvClientes.CurrentRow.Cells[2].Value) +' '+
            Convert.ToString(c.dgvClientes.CurrentRow.Cells[3].Value);
        }

        private void BuscarProducto_Click(object sender, EventArgs e)
        {
            DialogForms.ShowProductos frmrp = new DialogForms.ShowProductos();
            frmrp.ShowDialog();
            txtCodigo.Text = Convert.ToString(frmrp.dgvProductos.CurrentRow.Cells[0].Value);
            txtProducto.Text = Convert.ToString(frmrp.dgvProductos.CurrentRow.Cells[2].Value);
        }
    }
}
