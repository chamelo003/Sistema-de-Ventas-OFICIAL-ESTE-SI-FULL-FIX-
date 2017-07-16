namespace Capa_de_Presentacion
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enlaceproveedor = new System.Windows.Forms.PictureBox();
            this.Clientes = new System.Windows.Forms.PictureBox();
            this.productos = new System.Windows.Forms.PictureBox();
            this.ventas = new System.Windows.Forms.PictureBox();
            this.Empleados = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enlaceproveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblLoggedUser);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Maximize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 31);
            this.panel1.TabIndex = 2;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(11, 4);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(16, 20);
            this.lblLoggedUser.TabIndex = 8;
            this.lblLoggedUser.Text = "-";
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimize.Image = global::Capa_de_Presentacion.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(871, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(22, 21);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 5;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Maximize.Image = global::Capa_de_Presentacion.Properties.Resources.restore;
            this.Maximize.Location = new System.Drawing.Point(899, 3);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(22, 21);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximize.TabIndex = 6;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.Image = global::Capa_de_Presentacion.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(927, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(22, 21);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 4;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "POSIX";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.Empleados);
            this.panel2.Controls.Add(this.enlaceproveedor);
            this.panel2.Controls.Add(this.Clientes);
            this.panel2.Controls.Add(this.productos);
            this.panel2.Controls.Add(this.ventas);
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 504);
            this.panel2.TabIndex = 4;
            // 
            // enlaceproveedor
            // 
            this.enlaceproveedor.Image = global::Capa_de_Presentacion.Properties.Resources.iconProveedor;
            this.enlaceproveedor.Location = new System.Drawing.Point(13, 214);
            this.enlaceproveedor.Name = "enlaceproveedor";
            this.enlaceproveedor.Size = new System.Drawing.Size(128, 54);
            this.enlaceproveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enlaceproveedor.TabIndex = 3;
            this.enlaceproveedor.TabStop = false;
            this.enlaceproveedor.Click += new System.EventHandler(this.enlaceproveedor_Click);
            this.enlaceproveedor.MouseEnter += new System.EventHandler(this.enlaceproveedor_MouseEnter);
            // 
            // Clientes
            // 
            this.Clientes.Image = global::Capa_de_Presentacion.Properties.Resources.iconClientes;
            this.Clientes.Location = new System.Drawing.Point(15, 154);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(123, 54);
            this.Clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Clientes.TabIndex = 2;
            this.Clientes.TabStop = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            this.Clientes.MouseEnter += new System.EventHandler(this.Clientes_MouseEnter);
            // 
            // productos
            // 
            this.productos.Image = global::Capa_de_Presentacion.Properties.Resources.iconProduc;
            this.productos.Location = new System.Drawing.Point(13, 94);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(123, 54);
            this.productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productos.TabIndex = 1;
            this.productos.TabStop = false;
            this.productos.Click += new System.EventHandler(this.productos_Click);
            this.productos.MouseEnter += new System.EventHandler(this.productos_MouseEnter);
            // 
            // ventas
            // 
            this.ventas.Image = global::Capa_de_Presentacion.Properties.Resources.iconVentas;
            this.ventas.Location = new System.Drawing.Point(15, 34);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(123, 54);
            this.ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ventas.TabIndex = 0;
            this.ventas.TabStop = false;
            this.ventas.Click += new System.EventHandler(this.pictureBox1_Click);
            this.ventas.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // Empleados
            // 
            this.Empleados.Image = global::Capa_de_Presentacion.Properties.Resources.user;
            this.Empleados.Location = new System.Drawing.Point(13, 274);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(128, 54);
            this.Empleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Empleados.TabIndex = 4;
            this.Empleados.TabStop = false;
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            this.Empleados.MouseEnter += new System.EventHandler(this.Empleados_MouseEnter);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Capa_de_Presentacion.Properties.Resources.MDI_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enlaceproveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ventas;
        private System.Windows.Forms.PictureBox productos;
        private System.Windows.Forms.PictureBox Clientes;
        private System.Windows.Forms.PictureBox enlaceproveedor;
        private System.Windows.Forms.PictureBox Empleados;
    }
}