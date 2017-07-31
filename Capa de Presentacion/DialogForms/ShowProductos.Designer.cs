namespace Capa_de_Presentacion.DialogForms
{
    partial class ShowProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(270, 97);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(524, 21);
            this.txtBuscarProducto.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(204, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Buscar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(410, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 55);
            this.label11.TabIndex = 29;
            this.label11.Text = "Productos";
            // 
            // close
            // 
            this.close.Image = global::Capa_de_Presentacion.Properties.Resources.iconCierre1;
            this.close.Location = new System.Drawing.Point(1006, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 21);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 30;
            this.close.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Capa_de_Presentacion.Properties.Resources._1497960351_Cart;
            this.pictureBox10.Location = new System.Drawing.Point(12, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(37, 38);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 31;
            this.pictureBox10.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.CodBarra,
            this.NombreProducto,
            this.Existencia,
            this.ExistenciaMin,
            this.PrecioCosto,
            this.FechaIngreso,
            this.PrecioVenta1,
            this.PrecioVenta2,
            this.PrecioVenta3,
            this.PrecioVenta4,
            this.FechaVencimiento,
            this.Imagen,
            this.Proveedor,
            this.Categoria});
            this.dataGridView1.Location = new System.Drawing.Point(49, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(953, 277);
            this.dataGridView1.TabIndex = 32;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // CodBarra
            // 
            this.CodBarra.HeaderText = "Código de barra ";
            this.CodBarra.Name = "CodBarra";
            this.CodBarra.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 245;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // ExistenciaMin
            // 
            this.ExistenciaMin.HeaderText = "Existencia Mínima";
            this.ExistenciaMin.Name = "ExistenciaMin";
            this.ExistenciaMin.ReadOnly = true;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.HeaderText = "Precio Costo";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // PrecioVenta1
            // 
            this.PrecioVenta1.HeaderText = "PrecioVenta1";
            this.PrecioVenta1.Name = "PrecioVenta1";
            this.PrecioVenta1.ReadOnly = true;
            // 
            // PrecioVenta2
            // 
            this.PrecioVenta2.HeaderText = "PrecioVenta2";
            this.PrecioVenta2.Name = "PrecioVenta2";
            this.PrecioVenta2.ReadOnly = true;
            // 
            // PrecioVenta3
            // 
            this.PrecioVenta3.HeaderText = "PrecioVenta3";
            this.PrecioVenta3.Name = "PrecioVenta3";
            this.PrecioVenta3.ReadOnly = true;
            // 
            // PrecioVenta4
            // 
            this.PrecioVenta4.HeaderText = "PrecioVenta4";
            this.PrecioVenta4.Name = "PrecioVenta4";
            this.PrecioVenta4.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha Vto";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría ";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // ShowProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowProductos";
            this.Text = "ShowProductos";
            this.Load += new System.EventHandler(this.ShowProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewLinkColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}