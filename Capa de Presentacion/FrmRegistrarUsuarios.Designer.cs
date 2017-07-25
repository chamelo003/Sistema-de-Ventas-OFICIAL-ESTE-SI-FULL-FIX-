namespace Capa_de_Presentacion
{
    partial class FrmRegistrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarUsuarios));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.Cancelar = new System.Windows.Forms.PictureBox();
            this.Nuevo = new System.Windows.Forms.PictureBox();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Guardar_Usuario = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderUsuarios = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuevo)).BeginInit();
            this.groupBoxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guardar_Usuario)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Usuarios);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(39, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 401);
            this.tabControl1.TabIndex = 15;
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.Cancelar);
            this.Usuarios.Controls.Add(this.Nuevo);
            this.Usuarios.Controls.Add(this.groupBoxUsuario);
            this.Usuarios.Controls.Add(this.Guardar_Usuario);
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(760, 375);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.Text = "Usuario";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Image = global::Capa_de_Presentacion.Properties.Resources._19239827_471449833201500_175946913_n;
            this.Cancelar.Location = new System.Drawing.Point(446, 304);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(63, 63);
            this.Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cancelar.TabIndex = 47;
            this.Cancelar.TabStop = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Image = global::Capa_de_Presentacion.Properties.Resources.nuevo;
            this.Nuevo.Location = new System.Drawing.Point(256, 304);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(63, 63);
            this.Nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nuevo.TabIndex = 46;
            this.Nuevo.TabStop = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.checkBoxEstado);
            this.groupBoxUsuario.Controls.Add(this.label7);
            this.groupBoxUsuario.Controls.Add(this.label8);
            this.groupBoxUsuario.Controls.Add(this.cboTipoUsuario);
            this.groupBoxUsuario.Controls.Add(this.cboEmpleado);
            this.groupBoxUsuario.Controls.Add(this.label3);
            this.groupBoxUsuario.Controls.Add(this.label2);
            this.groupBoxUsuario.Controls.Add(this.txtPassword);
            this.groupBoxUsuario.Controls.Add(this.label5);
            this.groupBoxUsuario.Controls.Add(this.txtUser);
            this.groupBoxUsuario.Controls.Add(this.label4);
            this.groupBoxUsuario.Enabled = false;
            this.groupBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsuario.Location = new System.Drawing.Point(60, 22);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(633, 271);
            this.groupBoxUsuario.TabIndex = 2;
            this.groupBoxUsuario.TabStop = false;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(168, 197);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEstado.TabIndex = 44;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(383, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 33);
            this.label7.TabIndex = 43;
            this.label7.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(382, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 33);
            this.label8.TabIndex = 42;
            this.label8.Text = "+";
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(169, 153);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(213, 26);
            this.cboTipoUsuario.TabIndex = 41;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(168, 111);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(213, 26);
            this.cboEmpleado.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empleado";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(168, 34);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(214, 21);
            this.txtUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuario";
            // 
            // Guardar_Usuario
            // 
            this.Guardar_Usuario.Enabled = false;
            this.Guardar_Usuario.Image = global::Capa_de_Presentacion.Properties.Resources.guardar;
            this.Guardar_Usuario.Location = new System.Drawing.Point(354, 304);
            this.Guardar_Usuario.Name = "Guardar_Usuario";
            this.Guardar_Usuario.Size = new System.Drawing.Size(63, 63);
            this.Guardar_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guardar_Usuario.TabIndex = 45;
            this.Guardar_Usuario.TabStop = false;
            this.Guardar_Usuario.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listas de Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capa_de_Presentacion.Properties.Resources._19433418_472718866407930_1597699217_n;
            this.pictureBox2.Location = new System.Drawing.Point(403, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Capa_de_Presentacion.Properties.Resources.editar;
            this.pictureBox3.Location = new System.Drawing.Point(305, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(51, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdUsuario";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contraseña ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Empleado";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo Usuario";
            this.Column6.Name = "Column6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Buscar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(419, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(306, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 55);
            this.label11.TabIndex = 29;
            this.label11.Text = "Usuarios";
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::Capa_de_Presentacion.Properties.Resources.iconCierre1;
            this.Cerrar.Location = new System.Drawing.Point(816, 6);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(21, 21);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 31;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_de_Presentacion.Properties.Resources._1497960351_Cart;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderUsuarios
            // 
            this.errorProviderUsuarios.ContainerControl = this;
            // 
            // FrmRegistrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_de_Presentacion.Properties.Resources.pantalla2;
            this.ClientSize = new System.Drawing.Size(845, 532);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRegistrarUsuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.Usuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuevo)).EndInit();
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guardar_Usuario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Cancelar;
        private System.Windows.Forms.PictureBox Nuevo;
        private System.Windows.Forms.PictureBox Guardar_Usuario;
        private System.Windows.Forms.ErrorProvider errorProviderUsuarios;
    }
}