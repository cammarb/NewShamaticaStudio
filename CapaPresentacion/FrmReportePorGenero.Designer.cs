﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.charGenero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEspecificacion = new System.Windows.Forms.Label();
            this.lblFiltrado = new System.Windows.Forms.Label();
            this.cbxFiltrado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.charGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // charGenero
            // 
            this.charGenero.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.charGenero.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charGenero.Legends.Add(legend1);
            this.charGenero.Location = new System.Drawing.Point(21, 171);
            this.charGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.charGenero.Name = "charGenero";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Serie";
            this.charGenero.Series.Add(series1);
            this.charGenero.Size = new System.Drawing.Size(678, 349);
            this.charGenero.TabIndex = 0;
            this.charGenero.Text = "chart1";
            this.charGenero.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblEspecificacion
            // 
            this.lblEspecificacion.AutoSize = true;
            this.lblEspecificacion.Location = new System.Drawing.Point(251, 156);
            this.lblEspecificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecificacion.Name = "lblEspecificacion";
            this.lblEspecificacion.Size = new System.Drawing.Size(157, 13);
            this.lblEspecificacion.TabIndex = 1;
            this.lblEspecificacion.Text = "Division por general por defecto";
            // 
            // lblFiltrado
            // 
            this.lblFiltrado.AutoSize = true;
            this.lblFiltrado.Location = new System.Drawing.Point(46, 79);
            this.lblFiltrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrado.Name = "lblFiltrado";
            this.lblFiltrado.Size = new System.Drawing.Size(59, 13);
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
            this.cbxFiltrado.Location = new System.Drawing.Point(126, 76);
            this.cbxFiltrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFiltrado.Name = "cbxFiltrado";
            this.cbxFiltrado.Size = new System.Drawing.Size(144, 21);
            this.cbxFiltrado.TabIndex = 3;
            this.cbxFiltrado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmReportePorGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 543);
            this.Controls.Add(this.cbxFiltrado);
            this.Controls.Add(this.lblFiltrado);
            this.Controls.Add(this.lblEspecificacion);
            this.Controls.Add(this.charGenero);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmReportePorGenero";
            this.Text = "Reportes Clientes";
            this.Load += new System.EventHandler(this.FrmReportePorGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart charGenero;
        private System.Windows.Forms.Label lblEspecificacion;
        private System.Windows.Forms.Label lblFiltrado;
        private System.Windows.Forms.ComboBox cbxFiltrado;
    }
}