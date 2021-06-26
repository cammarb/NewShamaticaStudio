
namespace CapaPresentacion
{
    partial class FrmHorariosMasFrecuentados
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
            this.chartHorarioFrecuentado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHorarioFrecuentado)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHorarioFrecuentado
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHorarioFrecuentado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHorarioFrecuentado.Legends.Add(legend1);
            this.chartHorarioFrecuentado.Location = new System.Drawing.Point(35, 91);
            this.chartHorarioFrecuentado.Name = "chartHorarioFrecuentado";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Serie";
            this.chartHorarioFrecuentado.Series.Add(series1);
            this.chartHorarioFrecuentado.Size = new System.Drawing.Size(735, 333);
            this.chartHorarioFrecuentado.TabIndex = 0;
            this.chartHorarioFrecuentado.Text = "chart1";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(312, 44);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(179, 17);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Horarios mas frecuentados";
            // 
            // FrmHorariosMasFrecuentados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.chartHorarioFrecuentado);
            this.Name = "FrmHorariosMasFrecuentados";
            this.Text = "FrmHorariosMasFrecuentados";
            this.Load += new System.EventHandler(this.FrmHorariosMasFrecuentados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHorarioFrecuentado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHorarioFrecuentado;
        private System.Windows.Forms.Label lblTexto;
    }
}