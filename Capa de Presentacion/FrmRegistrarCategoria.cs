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
    public partial class FrmRegistrarCategoria : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCategoria C = new clsCategoria();

        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if(txtCategoria.Text.Trim() != "")
            {
                C.Categoria = txtCategoria.Text;
                String Mensaje = "";
                Mensaje = C.RegistrarCategoria();
                if(Mensaje == "Categoria agregada exitosamente.")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "POSIX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCategoria.Clear();
                    txtCategoria.Focus();
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
