
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
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(36, 85);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(106, 33);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo ";
            // 
            // dgInstrumentos
            // 
            this.dgInstrumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInstrumentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstrumentos.Location = new System.Drawing.Point(40, 332);
            this.dgInstrumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgInstrumentos.Name = "dgInstrumentos";
            this.dgInstrumentos.RowHeadersWidth = 51;
            this.dgInstrumentos.RowTemplate.Height = 24;
            this.dgInstrumentos.Size = new System.Drawing.Size(360, 207);
            this.dgInstrumentos.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(37, 127);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 33);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha ";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(37, 178);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(108, 33);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horario";
            // 
            // lblInstrumentos
            // 
            this.lblInstrumentos.AutoSize = true;
            this.lblInstrumentos.BackColor = System.Drawing.Color.Transparent;
            this.lblInstrumentos.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumentos.ForeColor = System.Drawing.Color.White;
            this.lblInstrumentos.Location = new System.Drawing.Point(33, 287);
            this.lblInstrumentos.Name = "lblInstrumentos";
            this.lblInstrumentos.Size = new System.Drawing.Size(341, 33);
            this.lblInstrumentos.TabIndex = 5;
            this.lblInstrumentos.Text = "Instruementos Reservados";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.Color.Transparent;
            this.lblSala.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.White;
            this.lblSala.Location = new System.Drawing.Point(37, 226);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(68, 33);
            this.lblSala.TabIndex = 6;
            this.lblSala.Text = "Sala";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(75, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 33);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Detalle De La Reserva";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumPurple;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(221, 560);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(179, 55);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmDetalleReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 647);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblInstrumentos);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgInstrumentos);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDetalleReserva";
            this.Text = "Detalle de reserva";
            this.Load += new System.EventHandler(this.FrmDetalleReserva_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmDetalleReserva_Paint);
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
        private System.Windows.Forms.Button btnVolver;
    }
}