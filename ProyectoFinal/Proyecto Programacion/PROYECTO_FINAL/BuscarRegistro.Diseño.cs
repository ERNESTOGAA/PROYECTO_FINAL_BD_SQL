namespace ConexionCSharpconMySQL
{
    partial class Basedatos
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basedatos));
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.txtApellido = new System.Windows.Forms.TextBox();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnAceptar = new System.Windows.Forms.Button();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.dgvBuscar = new System.Windows.Forms.DataGridView();
        	this.btnBuscar = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.groupBox1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.BackColor = System.Drawing.Color.Transparent;
        	this.groupBox1.Controls.Add(this.pictureBox1);
        	this.groupBox1.Controls.Add(this.txtApellido);
        	this.groupBox1.Controls.Add(this.btnCancelar);
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Controls.Add(this.btnAceptar);
        	this.groupBox1.Controls.Add(this.txtNombre);
        	this.groupBox1.Controls.Add(this.dgvBuscar);
        	this.groupBox1.Controls.Add(this.btnBuscar);
        	this.groupBox1.Controls.Add(this.label2);
        	this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.groupBox1.Location = new System.Drawing.Point(27, 3);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(629, 344);
        	this.groupBox1.TabIndex = 12;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Busqueda Registros";
        	// 
        	// txtApellido
        	// 
        	this.txtApellido.BackColor = System.Drawing.SystemColors.MenuText;
        	this.txtApellido.ForeColor = System.Drawing.SystemColors.Window;
        	this.txtApellido.Location = new System.Drawing.Point(16, 92);
        	this.txtApellido.Name = "txtApellido";
        	this.txtApellido.Size = new System.Drawing.Size(161, 20);
        	this.txtApellido.TabIndex = 3;
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.BackColor = System.Drawing.Color.Red;
        	this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.btnCancelar.Location = new System.Drawing.Point(533, 113);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(75, 26);
        	this.btnCancelar.TabIndex = 11;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = false;
        	this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.label1.Location = new System.Drawing.Point(16, 17);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(67, 16);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Nombre:";
        	this.label1.Click += new System.EventHandler(this.Label1Click);
        	// 
        	// btnAceptar
        	// 
        	this.btnAceptar.BackColor = System.Drawing.Color.Red;
        	this.btnAceptar.Location = new System.Drawing.Point(533, 29);
        	this.btnAceptar.Name = "btnAceptar";
        	this.btnAceptar.Size = new System.Drawing.Size(75, 27);
        	this.btnAceptar.TabIndex = 10;
        	this.btnAceptar.Text = "Aceptar";
        	this.btnAceptar.UseVisualStyleBackColor = false;
        	this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.BackColor = System.Drawing.SystemColors.MenuText;
        	this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
        	this.txtNombre.Location = new System.Drawing.Point(16, 36);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(161, 20);
        	this.txtNombre.TabIndex = 1;
        	// 
        	// dgvBuscar
        	// 
        	this.dgvBuscar.BackgroundColor = System.Drawing.Color.Black;
        	this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvBuscar.GridColor = System.Drawing.SystemColors.AppWorkspace;
        	this.dgvBuscar.Location = new System.Drawing.Point(6, 174);
        	this.dgvBuscar.Name = "dgvBuscar";
        	this.dgvBuscar.ReadOnly = true;
        	this.dgvBuscar.Size = new System.Drawing.Size(617, 150);
        	this.dgvBuscar.TabIndex = 9;
        	// 
        	// btnBuscar
        	// 
        	this.btnBuscar.BackColor = System.Drawing.Color.Red;
        	this.btnBuscar.Location = new System.Drawing.Point(207, 116);
        	this.btnBuscar.Name = "btnBuscar";
        	this.btnBuscar.Size = new System.Drawing.Size(75, 23);
        	this.btnBuscar.TabIndex = 4;
        	this.btnBuscar.Text = "Buscar";
        	this.btnBuscar.UseVisualStyleBackColor = false;
        	this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.label2.Location = new System.Drawing.Point(16, 73);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(74, 16);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Apellido: ";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(183, 9);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(112, 95);
        	this.pictureBox1.TabIndex = 12;
        	this.pictureBox1.TabStop = false;
        	// 
        	// Basedatos
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.ClientSize = new System.Drawing.Size(668, 359);
        	this.Controls.Add(this.groupBox1);
        	this.MaximizeBox = false;
        	this.Name = "Basedatos";
        	this.Text = "Buscar Registro";
        	this.Load += new System.EventHandler(this.BuscarClienteLoad);
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        
        void BuscarClienteLoad(object sender, System.EventArgs e)
        {
        	
        }
        
        void Label1Click(object sender, System.EventArgs e)
        {
        	
        }
    }
}