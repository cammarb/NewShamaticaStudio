
namespace CapaPresentacion
{
    partial class FrmInstrumentosReservadosPorFecha
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInstrumento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblIndicaccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartInstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // chartInstrumento
            // 
            chartArea3.Name = "ChartArea1";
            this.chartInstrumento.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartInstrumento.Legends.Add(legend3);
            this.chartInstrumento.Location = new System.Drawing.Point(110, 118);
            this.chartInstrumento.Name = "chartInstrumento";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Serie";
            this.chartInstrumento.Series.Add(series3);
            this.chartInstrumento.Size = new System.Drawing.Size(300, 300);
            this.chartInstrumento.TabIndex = 0;
            this.chartInstrumento.Click += new System.EventHandler(this.chart1_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(193, 68);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 22);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblIndicaccion
            // 
            this.lblIndicaccion.AutoSize = true;
            this.lblIndicaccion.Location = new System.Drawing.Point(107, 68);
            this.lblIndicaccion.Name = "lblIndicaccion";
            this.lblIndicaccion.Size = new System.Drawing.Size(47, 17);
            this.lblIndicaccion.TabIndex = 2;
            this.lblIndicaccion.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // FrmInstrumentosReservadosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIndicaccion);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.chartInstrumento);
            this.Name = "FrmInstrumentosReservadosPorFecha";
            this.Text = "FrmInstrumentosReservadosPorFecha";
            this.Load += new System.EventHandler(this.FrmInstrumentosReservadosPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartInstrumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInstrumento;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label lblIndicaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}