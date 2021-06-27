
namespace CapaPresentacion
{
    partial class FrmDetalleReserva
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgInstrumentos = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblInstrumentos = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(57, 62);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo ";
            // 
            // dgInstrumentos
            // 
            this.dgInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstrumentos.Location = new System.Drawing.Point(61, 266);
            this.dgInstrumentos.Name = "dgInstrumentos";
            this.dgInstrumentos.RowHeadersWidth = 51;
            this.dgInstrumentos.RowTemplate.Height = 24;
            this.dgInstrumentos.Size = new System.Drawing.Size(360, 207);
            this.dgInstrumentos.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(57, 104);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha ";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(58, 147);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(55, 17);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horario";
            // 
            // lblInstrumentos
            // 
            this.lblInstrumentos.AutoSize = true;
            this.lblInstrumentos.Location = new System.Drawing.Point(58, 234);
            this.lblInstrumentos.Name = "lblInstrumentos";
            this.lblInstrumentos.Size = new System.Drawing.Size(177, 17);
            this.lblInstrumentos.TabIndex = 5;
            this.lblInstrumentos.Text = "Instruementos Reservados";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(58, 186);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(36, 17);
            this.lblSala.TabIndex = 6;
            this.lblSala.Text = "Sala";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(177, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 17);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Detalle De La Reserva";
            // 
            // FrmDetalleReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 510);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblInstrumentos);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgInstrumentos);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmDetalleReserva";
            this.Text = "FrmDetalleReserva";
            this.Load += new System.EventHandler(this.FrmDetalleReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgInstrumentos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblInstrumentos;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblTitulo;
    }
}