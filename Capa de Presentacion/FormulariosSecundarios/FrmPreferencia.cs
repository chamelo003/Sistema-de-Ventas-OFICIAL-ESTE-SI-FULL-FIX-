﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public partial class FrmPreferencia : Form
    {
        public FrmPreferencia()
        {
            InitializeComponent();
        }

        private void aggCat_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria C = new FrmRegistrarCategoria();
            C.ShowDialog();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
