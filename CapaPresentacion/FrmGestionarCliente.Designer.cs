
namespace CapaPresentacion
{
    partial class FrmGestionarCliente
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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.txtBandaCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDistritoCliente = new System.Windows.Forms.ComboBox();
            this.cboUNICliente = new System.Windows.Forms.ComboBox();
            this.cboSexoCliente = new System.Windows.Forms.ComboBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtEdadCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(472, 52);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(542, 386);
            this.dgClientes.TabIndex = 0;
            // 
            // txtBandaCliente
            // 
            this.txtBandaCliente.Location = new System.Drawing.Point(283, 210);
            this.txtBandaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBandaCliente.Name = "txtBandaCliente";
            this.txtBandaCliente.Size = new System.Drawing.Size(152, 22);
            this.txtBandaCliente.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(282, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 68;
            this.label9.Text = "Banda:";
            // 
            // cboDistritoCliente
            // 
            this.cboDistritoCliente.FormattingEnabled = true;
            this.cboDistritoCliente.Items.AddRange(new object[] {
            "Los Olivos",
            "Surco",
            "Jesus Maria",
            "San Miguel",
            "Callao",
            "SJL",
            "Comas",
            "Miraflores",
            "San Isidro",
            "Barranco",
            "San Borja",
            "Pueblo Libre",
            "Rimac"});
            this.cboDistritoCliente.Location = new System.Drawing.Point(49, 278);
            this.cboDistritoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDistritoCliente.Name = "cboDistritoCliente";
            this.cboDistritoCliente.Size = new System.Drawing.Size(163, 24);
            this.cboDistritoCliente.TabIndex = 67;
            // 
            // cboUNICliente
            // 
            this.cboUNICliente.FormattingEnabled = true;
            this.cboUNICliente.Items.AddRange(new object[] {
            "UPC",
            "UPN",
            "CATOLICA",
            "AGRARIA",
            "SAN MARCOS",
            "UNI",
            "UTEC",
            "VILLAREAL"});
            this.cboUNICliente.Location = new System.Drawing.Point(283, 78);
            this.cboUNICliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUNICliente.Name = "cboUNICliente";
            this.cboUNICliente.Size = new System.Drawing.Size(155, 24);
            this.cboUNICliente.TabIndex = 66;
            // 
            // cboSexoCliente
            // 
            this.cboSexoCliente.FormattingEnabled = true;
            this.cboSexoCliente.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "No Binario"});
            this.cboSexoCliente.Location = new System.Drawing.Point(283, 142);
            this.cboSexoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSexoCliente.Name = "cboSexoCliente";
            this.cboSexoCliente.Size = new System.Drawing.Size(155, 24);
            this.cboSexoCliente.TabIndex = 65;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(49, 210);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(163, 22);
            this.txtCorreoCliente.TabIndex = 64;
            // 
            // txtEdadCliente
            // 
            this.txtEdadCliente.Location = new System.Drawing.Point(49, 142);
            this.txtEdadCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdadCliente.Name = "txtEdadCliente";
            this.txtEdadCliente.Size = new System.Drawing.Size(163, 22);
            this.txtEdadCliente.TabIndex = 63;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(49, 74);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(163, 22);
            this.txtNombreCliente.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(279, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(279, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Universidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Distrito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nombre:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(105, 352);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(328, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmGestionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBandaCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboDistritoCliente);
            this.Controls.Add(this.cboUNICliente);
            this.Controls.Add(this.cboSexoCliente);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.txtEdadCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgClientes);
            this.Name = "FrmGestionarCliente";
            this.Text = "FrmGestionarUsuario";
            this.Load += new System.EventHandler(this.FrmGestionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtBandaCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDistritoCliente;
        private System.Windows.Forms.ComboBox cboUNICliente;
        private System.Windows.Forms.ComboBox cboSexoCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtEdadCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}