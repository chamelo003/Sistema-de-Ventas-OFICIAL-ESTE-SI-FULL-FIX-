using System;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            String u = Program.NombreEmpleadoLogueado;
            lblLoggedUser.Text = u + " @ Posix:~$";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ventas.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas v = new FrmRegistroVentas();
            v.MdiParent = this;
            v.Show();
        }

        private void productos_Click(object sender, EventArgs e)
        {
            FrmRegistroProductos P = new FrmRegistroProductos();
            P.MdiParent = this;
            P.Show();
        }

        private void productos_MouseEnter(object sender, EventArgs e)
        {
            productos.Cursor = Cursors.Hand;
        }

        private void Clientes_MouseEnter(object sender, EventArgs e)
        {
            Clientes.Cursor = Cursors.Hand;
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente C = new FrmRegistroCliente();
            C.MdiParent = this;
            C.Show();
        }

        private void enlaceproveedor_MouseEnter(object sender, EventArgs e)
        {
            enlaceproveedor.Cursor = Cursors.Hand;
        }

        private void enlaceproveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores P = new FrmProveedores();
            P.MdiParent = this;
            P.Show();
        }

        private void Empleados_MouseEnter(object sender, EventArgs e)
        {
            Empleados.Cursor = Cursors.Hand;
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleados E = new FrmRegistrarEmpleados();
            E.MdiParent = this;
            E.Show();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuarios U = new FrmRegistrarUsuarios();
            U.MdiParent = this;
            U.Show();

        }
    }
}
