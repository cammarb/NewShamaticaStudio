
namespace CapaPresentacion
{
    partial class FrmListadoCliente
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
            this.lblFiltrado = new System.Windows.Forms.Label();
            this.cbxFiltrado = new System.Windows.Forms.ComboBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.tbxMiscelaneo = new System.Windows.Forms.TextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrado.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrado.ForeColor = System.Drawing.Color.White;
            this.lblFiltrado.Location = new System.Drawing.Point(24, 135);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(104, 24);
            this.lblFiltrado.TabIndex = 0;
            this.lblFiltrado.Text = "Filtrar por";
            // 
            // cbxFiltrado
            // 
            this.cbxFiltrado.FormattingEnabled = true;
            this.cbxFiltrado.Items.AddRange(new object[] {
            "Dni",
            "Edad",
            "Sexo",
            "Universidad",
            "Distrito",
            "Nombre"});
            this.cbxFiltrado.Location = new System.Drawing.Point(152, 137);
            this.cbxFiltrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFiltrado.Name = "cbxFiltrado";
            this.cbxFiltrado.Size = new System.Drawing.Size(144, 24);
            this.cbxFiltrado.TabIndex = 1;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.Transparent;
            this.lblListado.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.White;
            this.lblListado.Location = new System.Drawing.Point(24, 44);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(532, 45);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Listado de clientes registrados";
            // 
            // tbxMiscelaneo
            // 
            this.tbxMiscelaneo.Location = new System.Drawing.Point(356, 138);
            this.tbxMiscelaneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMiscelaneo.Name = "tbxMiscelaneo";
            this.tbxMiscelaneo.Size = new System.Drawing.Size(235, 22);
            this.tbxMiscelaneo.TabIndex = 3;
            this.tbxMiscelaneo.TextChanged += new System.EventHandler(this.tbxMiscelaneo_TextChanged);
            // 
            // dgClientes
            // 
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(15, 178);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(1149, 422);
            this.dgClientes.TabIndex = 4;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(807, 139);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(195, 24);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "Promedio de Edades";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightGreen;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(985, 622);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(179, 55);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 697);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.tbxMiscelaneo);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.cbxFiltrado);
            this.Controls.Add(this.lblFiltrado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmListadoCliente";
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.FrmListadoCliente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmListadoCliente_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrado;
        private System.Windows.Forms.ComboBox cbxFiltrado;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.TextBox tbxMiscelaneo;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnVolver;
    }
}