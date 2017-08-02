namespace Capa_de_Presentacion
{
    partial class FrmPreferencia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Guardar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.listBoxCategoria = new System.Windows.Forms.ListBox();
            this.listBoxPreferencias = new System.Windows.Forms.ListBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblIdCliente);
            this.groupBox1.Controls.Add(this.listBoxPreferencias);
            this.groupBox1.Controls.Add(this.listBoxCategoria);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(65, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 318);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Guardar
            // 
            this.Guardar.Image = global::Capa_de_Presentacion.Properties.Resources.guardar;
            this.Guardar.Location = new System.Drawing.Point(216, 249);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(63, 63);
            this.Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guardar.TabIndex = 37;
            this.Guardar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Selección cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Categorías";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(89, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 43);
            this.label3.TabIndex = 18;
            this.label3.Text = "Preferencias del Cliente";
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::Capa_de_Presentacion.Properties.Resources.iconCierre1;
            this.Cerrar.Location = new System.Drawing.Point(623, 5);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(21, 21);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 21;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Capa_de_Presentacion.Properties.Resources._1497960351_Cart;
            this.pictureBox8.Location = new System.Drawing.Point(5, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // listBoxCategoria
            // 
            this.listBoxCategoria.FormattingEnabled = true;
            this.listBoxCategoria.Location = new System.Drawing.Point(32, 50);
            this.listBoxCategoria.Name = "listBoxCategoria";
            this.listBoxCategoria.Size = new System.Drawing.Size(152, 173);
            this.listBoxCategoria.TabIndex = 38;
            // 
            // listBoxPreferencias
            // 
            this.listBoxPreferencias.FormattingEnabled = true;
            this.listBoxPreferencias.Location = new System.Drawing.Point(301, 50);
            this.listBoxPreferencias.Name = "listBoxPreferencias";
            this.listBoxPreferencias.Size = new System.Drawing.Size(152, 173);
            this.listBoxPreferencias.TabIndex = 39;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(213, 19);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(61, 18);
            this.lblIdCliente.TabIndex = 40;
            this.lblIdCliente.Text = "idcliente";
            this.lblIdCliente.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(216, 89);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(42, 37);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(216, 151);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(42, 36);
            this.btnQuitar.TabIndex = 42;
            this.btnQuitar.Text = "<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // FrmPreferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_de_Presentacion.Properties.Resources.pantalla2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 448);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPreferencia";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Guardar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.ListBox listBoxPreferencias;
        private System.Windows.Forms.ListBox listBoxCategoria;
    }
}