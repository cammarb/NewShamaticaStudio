
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
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReservasClientes
            // 
            this.dgReservasClientes.AllowUserToAddRows = false;
            this.dgReservasClientes.AllowUserToDeleteRows = false;
            this.dgReservasClientes.AllowUserToResizeColumns = false;
            this.dgReservasClientes.AllowUserToResizeRows = false;
            this.dgReservasClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReservasClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgReservasClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservasClientes.Location = new System.Drawing.Point(49, 137);
            this.dgReservasClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgReservasClientes.MultiSelect = false;
            this.dgReservasClientes.Name = "dgReservasClientes";
            this.dgReservasClientes.RowHeadersWidth = 51;
            this.dgReservasClientes.RowTemplate.Height = 24;
            this.dgReservasClientes.Size = new System.Drawing.Size(476, 463);
            this.dgReservasClientes.TabIndex = 0;
            this.dgReservasClientes.AllowUserToAddRowsChanged += new System.EventHandler(this.False);
            this.dgReservasClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReservasClientes_CellClick);
            this.dgReservasClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReservasClientes_CellContentClick);
            // 
            // btnDetalle
            // 
            this.btnDetalle.AutoSize = true;
            this.btnDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnDetalle.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(45, 62);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(352, 41);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "Reservas Registradas";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumPurple;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(347, 641);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(179, 55);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmReservasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 711);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dgReservasClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmReservasCliente";
            this.Text = "FrmReservasCliente";
            this.Load += new System.EventHandler(this.FrmReservasCliente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmReservasCliente_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReservasClientes;
        private System.Windows.Forms.Label btnDetalle;
        private System.Windows.Forms.Button btnVolver;
    }
}