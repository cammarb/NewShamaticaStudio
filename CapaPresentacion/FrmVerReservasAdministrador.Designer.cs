
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasPorFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReservasPorFecha
            // 
            this.dgReservasPorFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservasPorFecha.Location = new System.Drawing.Point(30, 127);
            this.dgReservasPorFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dgReservasPorFecha.Name = "dgReservasPorFecha";
            this.dgReservasPorFecha.RowHeadersWidth = 51;
            this.dgReservasPorFecha.RowTemplate.Height = 24;
            this.dgReservasPorFecha.Size = new System.Drawing.Size(661, 248);
            this.dgReservasPorFecha.TabIndex = 0;
            // 
            // dTimeSelect
            // 
            this.dTimeSelect.Location = new System.Drawing.Point(200, 92);
            this.dTimeSelect.Margin = new System.Windows.Forms.Padding(2);
            this.dTimeSelect.Name = "dTimeSelect";
            this.dTimeSelect.Size = new System.Drawing.Size(208, 20);
            this.dTimeSelect.TabIndex = 1;
            this.dTimeSelect.ValueChanged += new System.EventHandler(this.dTimeSelect_ValueChanged);
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrado.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrado.ForeColor = System.Drawing.Color.White;
            this.lblFiltrado.Location = new System.Drawing.Point(32, 92);
            this.lblFiltrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(164, 19);
            this.lblFiltrado.TabIndex = 2;
            this.lblFiltrado.Text = "Seleccione una fecha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(560, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(29, 29);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(189, 35);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Ver Reservas";
            // 
            // FrmVerReservasAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 472);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFiltrado);
            this.Controls.Add(this.dTimeSelect);
            this.Controls.Add(this.dgReservasPorFecha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVerReservasAdministrador";
            this.Text = "FrmVerReservasAdministrador";
            this.Load += new System.EventHandler(this.FrmVerReservasAdministrador_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmVerReservasAdministrador_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasPorFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReservasPorFecha;
        private System.Windows.Forms.DateTimePicker dTimeSelect;
        private System.Windows.Forms.Label lblFiltrado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTexto;
    }
}