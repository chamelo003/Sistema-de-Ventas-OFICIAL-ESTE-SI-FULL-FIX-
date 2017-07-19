using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaLogicaNegocio;
using System.Data.SqlClient;

namespace Capa_de_Presentacion
{
    public partial class FrmDepartamento : Form
    {
        private ClsDepto M = new ClsDepto();
        public FrmDepartamento()
        {
            InitializeComponent();
        }
        private void Guardar_MouseEnter(object sender, EventArgs e)
        {
            Guardar.Cursor = Cursors.Hand;
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (txtDepto.Text.Trim() != "")
            {
                String Mensaje = "";
                M.Depto = txtDepto.Text;
                Mensaje = M.RegistrarDepartamento();
                if (Mensaje == "Departamento agregado exitosamente.")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Guardar_Click_1(object sender, EventArgs e)
        {
            if (txtDepto.Text.Trim() != "")
            {
                String Mensaje = "";
                M.Depto = txtDepto.Text;
                Mensaje = M.RegistrarDepto();
                if (Mensaje == "Departamento agregado exitosamente.")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
