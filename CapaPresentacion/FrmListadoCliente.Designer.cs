
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
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.Location = new System.Drawing.Point(18, 110);
            this.lblFiltrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(50, 13);
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
            this.cbxFiltrado.Location = new System.Drawing.Point(97, 110);
            this.cbxFiltrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFiltrado.Name = "cbxFiltrado";
            this.cbxFiltrado.Size = new System.Drawing.Size(109, 21);
            this.cbxFiltrado.TabIndex = 1;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(18, 36);
            this.lblListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(416, 35);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Listado de clientes registrados";
            // 
            // tbxMiscelaneo
            // 
            this.tbxMiscelaneo.Location = new System.Drawing.Point(250, 111);
            this.tbxMiscelaneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMiscelaneo.Name = "tbxMiscelaneo";
            this.tbxMiscelaneo.Size = new System.Drawing.Size(137, 20);
            this.tbxMiscelaneo.TabIndex = 3;
            this.tbxMiscelaneo.TextChanged += new System.EventHandler(this.tbxMiscelaneo_TextChanged);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(11, 145);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(862, 343);
            this.dgClientes.TabIndex = 4;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(670, 118);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(105, 13);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "Promedio de Edades";
            // 
            // FrmListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 499);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.tbxMiscelaneo);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.cbxFiltrado);
            this.Controls.Add(this.lblFiltrado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmListadoCliente";
            this.Text = "FrmListadoCliente";
            this.Load += new System.EventHandler(this.FrmListadoCliente_Load);
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
    }
}