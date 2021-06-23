
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
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.Location = new System.Drawing.Point(12, 52);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(69, 17);
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
            "Universidad"});
            this.cbxFiltrado.Location = new System.Drawing.Point(118, 52);
            this.cbxFiltrado.Name = "cbxFiltrado";
            this.cbxFiltrado.Size = new System.Drawing.Size(121, 24);
            this.cbxFiltrado.TabIndex = 1;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(192, 9);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(201, 17);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Listado de clientes registrados";
            // 
            // tbxMiscelaneo
            // 
            this.tbxMiscelaneo.Location = new System.Drawing.Point(273, 54);
            this.tbxMiscelaneo.Name = "tbxMiscelaneo";
            this.tbxMiscelaneo.Size = new System.Drawing.Size(120, 22);
            this.tbxMiscelaneo.TabIndex = 3;
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(12, 99);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(421, 221);
            this.dgClientes.TabIndex = 4;
            // 
            // FrmListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.tbxMiscelaneo);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.cbxFiltrado);
            this.Controls.Add(this.lblFiltrado);
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
    }
}