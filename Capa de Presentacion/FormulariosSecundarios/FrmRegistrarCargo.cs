﻿using System;
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
    public partial class FrmRegistrarCargo : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCargo C = new clsCargo();

        public FrmRegistrarCargo()
        {
            InitializeComponent();
        }
    }
}
