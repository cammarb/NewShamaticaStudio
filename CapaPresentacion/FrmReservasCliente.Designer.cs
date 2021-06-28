
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
            this.dgReservasClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservasClientes.Location = new System.Drawing.Point(37, 111);
            this.dgReservasClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgReservasClientes.MultiSelect = false;
            this.dgReservasClientes.Name = "dgReservasClientes";
            this.dgReservasClientes.RowHeadersWidth = 51;
            this.dgReservasClientes.RowTemplate.Height = 24;
            this.dgReservasClientes.Size = new System.Drawing.Size(357, 376);
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
            this.btnDetalle.Location = new System.Drawing.Point(34, 50);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(280, 33);
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
            this.btnVolver.Location = new System.Drawing.Point(260, 521);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(134, 45);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmReservasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 578);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dgReservasClientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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