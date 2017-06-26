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
            this.WindowState = FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas v = new FrmRegistroVentas();
            v.MdiParent = this;
            v.Show();
        }
    }
}
