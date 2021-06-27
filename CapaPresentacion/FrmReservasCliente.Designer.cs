
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
            this.dgReservasClientes.Location = new System.Drawing.Point(37, 111);
            this.dgReservasClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgReservasClientes.Name = "dgReservasClientes";
            this.dgReservasClientes.RowHeadersWidth = 51;
            this.dgReservasClientes.RowTemplate.Height = 24;
            this.dgReservasClientes.Size = new System.Drawing.Size(734, 376);
            this.dgReservasClientes.TabIndex = 0;
            // 
            // btnDetalle
            // 
            this.btnDetalle.AutoSize = true;
            this.btnDetalle.Location = new System.Drawing.Point(34, 50);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(111, 13);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "Reservas Registradas";
            // 
            // FrmReservasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 527);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dgReservasClientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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