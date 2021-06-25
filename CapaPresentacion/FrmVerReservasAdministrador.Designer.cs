
namespace CapaPresentacion
{
    partial class FrmVerReservasAdministrador
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
            this.dgReservasPorFecha = new System.Windows.Forms.DataGridView();
            this.dTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasPorFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReservasPorFecha
            // 
            this.dgReservasPorFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservasPorFecha.Location = new System.Drawing.Point(69, 103);
            this.dgReservasPorFecha.Name = "dgReservasPorFecha";
            this.dgReservasPorFecha.RowHeadersWidth = 51;
            this.dgReservasPorFecha.RowTemplate.Height = 24;
            this.dgReservasPorFecha.Size = new System.Drawing.Size(240, 150);
            this.dgReservasPorFecha.TabIndex = 0;
            // 
            // dTimeSelect
            // 
            this.dTimeSelect.Location = new System.Drawing.Point(250, 57);
            this.dTimeSelect.Name = "dTimeSelect";
            this.dTimeSelect.Size = new System.Drawing.Size(200, 22);
            this.dTimeSelect.TabIndex = 1;
            this.dTimeSelect.ValueChanged += new System.EventHandler(this.dTimeSelect_ValueChanged);
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.Location = new System.Drawing.Point(66, 57);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(144, 17);
            this.lblFiltrado.TabIndex = 2;
            this.lblFiltrado.Text = "Seleccione una fecha";
            // 
            // FrmVerReservasAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFiltrado);
            this.Controls.Add(this.dTimeSelect);
            this.Controls.Add(this.dgReservasPorFecha);
            this.Name = "FrmVerReservasAdministrador";
            this.Text = "FrmVerReservasAdministrador";
            this.Load += new System.EventHandler(this.FrmVerReservasAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasPorFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReservasPorFecha;
        private System.Windows.Forms.DateTimePicker dTimeSelect;
        private System.Windows.Forms.Label lblFiltrado;
    }
}