
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInstrumento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblIndicaccion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPromedioInstrumentosReservados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartInstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // chartInstrumento
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInstrumento.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInstrumento.Legends.Add(legend1);
            this.chartInstrumento.Location = new System.Drawing.Point(34, 98);
            this.chartInstrumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartInstrumento.Name = "chartInstrumento";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Serie";
            this.chartInstrumento.Series.Add(series1);
            this.chartInstrumento.Size = new System.Drawing.Size(411, 244);
            this.chartInstrumento.TabIndex = 0;
            this.chartInstrumento.Click += new System.EventHandler(this.chart1_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(178, 63);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(225, 20);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblIndicaccion
            // 
            this.lblIndicaccion.AutoSize = true;
            this.lblIndicaccion.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicaccion.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaccion.ForeColor = System.Drawing.Color.White;
            this.lblIndicaccion.Location = new System.Drawing.Point(81, 58);
            this.lblIndicaccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicaccion.Name = "lblIndicaccion";
            this.lblIndicaccion.Size = new System.Drawing.Size(61, 23);
            this.lblIndicaccion.TabIndex = 2;
            this.lblIndicaccion.Text = "Fecha";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(455, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Instrumentos Reservados Por Fecha";
            // 
            // lblPromedioInstrumentosReservados
            // 
            this.lblPromedioInstrumentosReservados.AutoSize = true;
            this.lblPromedioInstrumentosReservados.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioInstrumentosReservados.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioInstrumentosReservados.ForeColor = System.Drawing.Color.White;
            this.lblPromedioInstrumentosReservados.Location = new System.Drawing.Point(32, 371);
            this.lblPromedioInstrumentosReservados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedioInstrumentosReservados.Name = "lblPromedioInstrumentosReservados";
            this.lblPromedioInstrumentosReservados.Size = new System.Drawing.Size(381, 23);
            this.lblPromedioInstrumentosReservados.TabIndex = 4;
            this.lblPromedioInstrumentosReservados.Text = "El promedio de instrumentos reservados es";
            this.lblPromedioInstrumentosReservados.Click += new System.EventHandler(this.lblPromedioInstrumentosReservados_Click);
            // 
            // FrmInstrumentosReservadosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 426);
            this.Controls.Add(this.lblPromedioInstrumentosReservados);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblIndicaccion);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.chartInstrumento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInstrumentosReservadosPorFecha";
            this.Text = "Instrumentos reservados por fecha";
            this.Load += new System.EventHandler(this.FrmInstrumentosReservadosPorFecha_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmInstrumentosReservadosPorFecha_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.chartInstrumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInstrumento;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label lblIndicaccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPromedioInstrumentosReservados;
    }
}