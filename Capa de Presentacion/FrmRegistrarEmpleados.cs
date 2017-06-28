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
    public partial class FrmRegistrarEmpleados : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsCargo C = new clsCargo();
        clsEmpleado E = new clsEmpleado();
        int Listado = 0;
        public FrmRegistrarEmpleados()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEmpleados_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            CargarComboBox();
        }

        private void CargarComboBox(){
            cboCargo.DataSource = C.Listar();
            cboCargo.DisplayMember = "Descripcion";
            cboCargo.ValueMember = "IdCargo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrarCargo C = new FrmRegistrarCargo();
            C.Show();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
          
            E.IdEmpleado = Convert.ToInt32(txtIdE.Text);
            E.IdCargo = Convert.ToInt32(cboCargo.SelectedValue);
            E.Dni = mktCodEmpleado.Text;
            E.Apellidos = txtApellidos.Text;
            E.Nombres = txtNombres.Text;
            E.Sexo=rbnMasculino.Checked==true?'M':'F';
         
            E.Direccion = txtDireccion.Text;
            DevComponents.DotNetBar.MessageBoxEx.Show(E.MantenimientoEmpleados(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Limpiar();
        }

        private void Limpiar() {
            txtApellidos.Clear();
            txtDireccion.Clear();
            mktCodEmpleado.Clear();
            txtNombres.Clear();
            rbnMasculino.Checked = true;
            txtIdE.Clear();
            Program.IdCargo = 0;
            cboCargo.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado) {
                case 0: CargarComboBox(); break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void FrmRegistrarEmpleados_Activated(object sender, EventArgs e)
        {
            if (Program.IdCargo != 0)
                cboCargo.SelectedValue = Program.IdCargo;
            else
                cbxEstadoCivil.SelectedIndex = 0;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
