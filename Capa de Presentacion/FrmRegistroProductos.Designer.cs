namespace Capa_de_Presentacion
{
    partial class FrmRegistroProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroProductos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cancelar = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.PictureBox();
            this.nuevo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkISV = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nuevacat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioVenta4 = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta3 = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta2 = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta1 = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cant_existencia_min = new System.Windows.Forms.NumericUpDown();
            this.cant_existencia = new System.Windows.Forms.NumericUpDown();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaingreso = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imprimir = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreciosVenta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.restore = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cant_existencia_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_existencia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 437);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::Capa_de_Presentacion.Properties.Resources.pantallaaa1;
            this.tabPage1.Controls.Add(this.cancelar);
            this.tabPage1.Controls.Add(this.guardar);
            this.tabPage1.Controls.Add(this.nuevo);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Producto";
            // 
            // cancelar
            // 
            this.cancelar.Image = global::Capa_de_Presentacion.Properties.Resources._19239827_471449833201500_175946913_n;
            this.cancelar.Location = new System.Drawing.Point(490, 342);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(63, 63);
            this.cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancelar.TabIndex = 39;
            this.cancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.cancelar, "Cancelar");
            // 
            // guardar
            // 
            this.guardar.Image = global::Capa_de_Presentacion.Properties.Resources.guardar;
            this.guardar.Location = new System.Drawing.Point(389, 342);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(63, 63);
            this.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardar.TabIndex = 37;
            this.guardar.TabStop = false;
            this.toolTip1.SetToolTip(this.guardar, "Guardar");
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = global::Capa_de_Presentacion.Properties.Resources.nuevo;
            this.nuevo.Location = new System.Drawing.Point(285, 342);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(63, 63);
            this.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuevo.TabIndex = 38;
            this.nuevo.TabStop = false;
            this.toolTip1.SetToolTip(this.nuevo, "Nuevo");
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            this.nuevo.MouseEnter += new System.EventHandler(this.nuevo_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chkISV);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.nuevacat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cant_existencia_min);
            this.panel1.Controls.Add(this.cant_existencia);
            this.panel1.Controls.Add(this.cboProveedor);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtpFechaingreso);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigoBarra);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboCategoria);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpFechaVencimiento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(28, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 331);
            this.panel1.TabIndex = 0;
            // 
            // chkISV
            // 
            this.chkISV.AutoSize = true;
            this.chkISV.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkISV.Location = new System.Drawing.Point(3, 302);
            this.chkISV.Name = "chkISV";
            this.chkISV.Size = new System.Drawing.Size(92, 22);
            this.chkISV.TabIndex = 54;
            this.chkISV.Text = "Aplica ISV";
            this.chkISV.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label17.Location = new System.Drawing.Point(344, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 33);
            this.label17.TabIndex = 52;
            this.label17.Text = "+";
            // 
            // nuevacat
            // 
            this.nuevacat.AutoSize = true;
            this.nuevacat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevacat.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.nuevacat.Location = new System.Drawing.Point(343, 153);
            this.nuevacat.Name = "nuevacat";
            this.nuevacat.Size = new System.Drawing.Size(33, 33);
            this.nuevacat.TabIndex = 39;
            this.nuevacat.Text = "+";
            this.nuevacat.Click += new System.EventHandler(this.nuevacat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioVenta4);
            this.groupBox1.Controls.Add(this.txtPrecioVenta3);
            this.groupBox1.Controls.Add(this.txtPrecioVenta2);
            this.groupBox1.Controls.Add(this.txtPrecioVenta1);
            this.groupBox1.Controls.Add(this.txtPrecioCosto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(490, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 218);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // txtPrecioVenta4
            // 
            this.txtPrecioVenta4.Location = new System.Drawing.Point(144, 179);
            this.txtPrecioVenta4.Name = "txtPrecioVenta4";
            this.txtPrecioVenta4.Size = new System.Drawing.Size(158, 24);
            this.txtPrecioVenta4.TabIndex = 59;
            // 
            // txtPrecioVenta3
            // 
            this.txtPrecioVenta3.Location = new System.Drawing.Point(144, 141);
            this.txtPrecioVenta3.Name = "txtPrecioVenta3";
            this.txtPrecioVenta3.Size = new System.Drawing.Size(158, 24);
            this.txtPrecioVenta3.TabIndex = 58;
            // 
            // txtPrecioVenta2
            // 
            this.txtPrecioVenta2.Location = new System.Drawing.Point(144, 102);
            this.txtPrecioVenta2.Name = "txtPrecioVenta2";
            this.txtPrecioVenta2.Size = new System.Drawing.Size(158, 24);
            this.txtPrecioVenta2.TabIndex = 57;
            // 
            // txtPrecioVenta1
            // 
            this.txtPrecioVenta1.Location = new System.Drawing.Point(143, 63);
            this.txtPrecioVenta1.Name = "txtPrecioVenta1";
            this.txtPrecioVenta1.Size = new System.Drawing.Size(158, 24);
            this.txtPrecioVenta1.TabIndex = 56;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(143, 23);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(158, 24);
            this.txtPrecioCosto.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 55;
            this.label10.Text = "Precio Venta 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 18);
            this.label12.TabIndex = 54;
            this.label12.Text = "Precio Venta 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Precio Venta 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Precio Venta 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Precio Compra";
            // 
            // cant_existencia_min
            // 
            this.cant_existencia_min.Location = new System.Drawing.Point(141, 121);
            this.cant_existencia_min.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cant_existencia_min.Name = "cant_existencia_min";
            this.cant_existencia_min.Size = new System.Drawing.Size(120, 24);
            this.cant_existencia_min.TabIndex = 49;
            // 
            // cant_existencia
            // 
            this.cant_existencia.Location = new System.Drawing.Point(140, 86);
            this.cant_existencia.Name = "cant_existencia";
            this.cant_existencia.Size = new System.Drawing.Size(120, 24);
            this.cant_existencia.TabIndex = 48;
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(141, 193);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(200, 26);
            this.cboProveedor.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 46;
            this.label14.Text = "Proveedor";
            // 
            // dtpFechaingreso
            // 
            this.dtpFechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaingreso.Location = new System.Drawing.Point(141, 231);
            this.dtpFechaingreso.Name = "dtpFechaingreso";
            this.dtpFechaingreso.Size = new System.Drawing.Size(135, 24);
            this.dtpFechaingreso.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Fecha Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Existencia Mínima";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(141, 15);
            this.txtCodigoBarra.MaxLength = 14;
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(157, 24);
            this.txtCodigoBarra.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Código de Barra";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(141, 156);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(200, 26);
            this.cboCategoria.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Categoría";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(141, 267);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(135, 24);
            this.dtpFechaVencimiento.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Existencia ";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(140, 51);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(292, 24);
            this.txtProducto.TabIndex = 18;
            this.txtProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtProducto_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Producto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.imprimir);
            this.tabPage2.Controls.Add(this.editar);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.txtBuscarProducto);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imprimir
            // 
            this.imprimir.Image = global::Capa_de_Presentacion.Properties.Resources._19433418_472718866407930_1597699217_n;
            this.imprimir.Location = new System.Drawing.Point(462, 340);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(63, 63);
            this.imprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imprimir.TabIndex = 41;
            this.imprimir.TabStop = false;
            // 
            // editar
            // 
            this.editar.Image = global::Capa_de_Presentacion.Properties.Resources.editar;
            this.editar.Location = new System.Drawing.Point(344, 340);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(63, 63);
            this.editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editar.TabIndex = 40;
            this.editar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvProductos);
            this.panel3.Location = new System.Drawing.Point(6, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 281);
            this.panel3.TabIndex = 12;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.CodBarra,
            this.NombreProducto,
            this.Existencia,
            this.ExistenciaMin,
            this.PrecioCosto,
            this.PreciosVenta,
            this.FechaIngreso,
            this.FechaVencimiento,
            this.Imagen,
            this.Proveedor,
            this.Categoria});
            this.dgvProductos.Location = new System.Drawing.Point(2, -1);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(839, 277);
            this.dgvProductos.TabIndex = 0;
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
            // PreciosVenta
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "L 0.00";
            this.PreciosVenta.DefaultCellStyle = dataGridViewCellStyle1;
            this.PreciosVenta.HeaderText = "Precios de venta";
            this.PreciosVenta.Name = "PreciosVenta";
            this.PreciosVenta.ReadOnly = true;
            this.PreciosVenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PreciosVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PreciosVenta.Width = 150;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
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
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(83, 16);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(524, 21);
            this.txtBuscarProducto.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Buscar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(347, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 59);
            this.label11.TabIndex = 21;
            this.label11.Text = "Productos";
            // 
            // restore
            // 
            this.restore.Image = global::Capa_de_Presentacion.Properties.Resources.iconRestaurar1;
            this.restore.Location = new System.Drawing.Point(875, 3);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(21, 21);
            this.restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restore.TabIndex = 24;
            this.restore.TabStop = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // close
            // 
            this.close.Image = global::Capa_de_Presentacion.Properties.Resources.iconCierre1;
            this.close.Location = new System.Drawing.Point(902, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 21);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 23;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Image = global::Capa_de_Presentacion.Properties.Resources.iconMini11;
            this.minimize.Location = new System.Drawing.Point(848, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(21, 21);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 22;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Capa_de_Presentacion.Properties.Resources._1497960351_Cart;
            this.pictureBox10.Location = new System.Drawing.Point(2, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(28, 29);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRegistroProductos
            // 
            this.AccessibleName = "325396";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_de_Presentacion.Properties.Resources.pantalla2;
            this.ClientSize = new System.Drawing.Size(928, 496);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistroProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRegistroProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cant_existencia_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_existencia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtpFechaingreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox imprimir;
        private System.Windows.Forms.PictureBox editar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cant_existencia_min;
        private System.Windows.Forms.NumericUpDown cant_existencia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label nuevacat;
        private System.Windows.Forms.PictureBox cancelar;
        private System.Windows.Forms.PictureBox guardar;
        private System.Windows.Forms.PictureBox nuevo;
        private System.Windows.Forms.TextBox txtPrecioVenta4;
        private System.Windows.Forms.TextBox txtPrecioVenta3;
        private System.Windows.Forms.TextBox txtPrecioVenta2;
        private System.Windows.Forms.TextBox txtPrecioVenta1;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.PictureBox restore;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkISV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewComboBoxColumn PreciosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewLinkColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}