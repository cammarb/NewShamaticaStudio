
namespace CapaPresentacion
{
    partial class FrmReportePorGenero
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.charGenero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEspecificacion = new System.Windows.Forms.Label();
            this.lblFiltrado = new System.Windows.Forms.Label();
            this.cbxFiltrado = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.charGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // charGenero
            // 
            this.charGenero.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.charGenero.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.charGenero.Legends.Add(legend2);
            this.charGenero.Location = new System.Drawing.Point(21, 171);
            this.charGenero.Margin = new System.Windows.Forms.Padding(2);
            this.charGenero.Name = "charGenero";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Serie";
            this.charGenero.Series.Add(series2);
            this.charGenero.Size = new System.Drawing.Size(678, 349);
            this.charGenero.TabIndex = 0;
            this.charGenero.Text = "chart1";
            this.charGenero.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblEspecificacion
            // 
            this.lblEspecificacion.AutoSize = true;
            this.lblEspecificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecificacion.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecificacion.Location = new System.Drawing.Point(199, 146);
            this.lblEspecificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecificacion.Name = "lblEspecificacion";
            this.lblEspecificacion.Size = new System.Drawing.Size(280, 23);
            this.lblEspecificacion.TabIndex = 1;
            this.lblEspecificacion.Text = "Division por general por defecto";
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrado.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrado.ForeColor = System.Drawing.Color.White;
            this.lblFiltrado.Location = new System.Drawing.Point(41, 103);
            this.lblFiltrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(95, 19);
            this.lblFiltrado.TabIndex = 2;
            this.lblFiltrado.Text = "Filtrado por";
            // 
            // cbxFiltrado
            // 
            this.cbxFiltrado.FormattingEnabled = true;
            this.cbxFiltrado.Items.AddRange(new object[] {
            "Genero",
            "Distrito",
            "Universidad"});
            this.cbxFiltrado.Location = new System.Drawing.Point(149, 105);
            this.cbxFiltrado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFiltrado.Name = "cbxFiltrado";
            this.cbxFiltrado.Size = new System.Drawing.Size(144, 21);
            this.cbxFiltrado.TabIndex = 3;
            this.cbxFiltrado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightCoral;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(552, 539);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 53);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(40, 37);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(219, 35);
            this.lblTexto.TabIndex = 31;
            this.lblTexto.Text = "Listado clientes";
            // 
            // FrmReportePorGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 620);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbxFiltrado);
            this.Controls.Add(this.lblFiltrado);
            this.Controls.Add(this.lblEspecificacion);
            this.Controls.Add(this.charGenero);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportePorGenero";
            this.Text = "Reportes Clientes";
            this.Load += new System.EventHandler(this.FrmReportePorGenero_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmReportePorGenero_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.charGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart charGenero;
        private System.Windows.Forms.Label lblEspecificacion;
        private System.Windows.Forms.Label lblFiltrado;
        private System.Windows.Forms.ComboBox cbxFiltrado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTexto;
    }
}