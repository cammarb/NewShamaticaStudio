
namespace CapaPresentacion
{
    partial class FrmReservasCliente
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
            this.dgReservasClientes = new System.Windows.Forms.DataGridView();
            this.btnDetalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReservasClientes
            // 
            this.dgReservasClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservasClientes.Location = new System.Drawing.Point(193, 125);
            this.dgReservasClientes.Name = "dgReservasClientes";
            this.dgReservasClientes.RowHeadersWidth = 51;
            this.dgReservasClientes.RowTemplate.Height = 24;
            this.dgReservasClientes.Size = new System.Drawing.Size(371, 226);
            this.dgReservasClientes.TabIndex = 0;
            // 
            // btnDetalle
            // 
            this.btnDetalle.AutoSize = true;
            this.btnDetalle.Location = new System.Drawing.Point(236, 51);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(148, 17);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "Reservas Registradas";
            // 
            // FrmReservasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dgReservasClientes);
            this.Name = "FrmReservasCliente";
            this.Text = "FrmReservasCliente";
            this.Load += new System.EventHandler(this.FrmReservasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReservasClientes;
        private System.Windows.Forms.Label btnDetalle;
    }
}