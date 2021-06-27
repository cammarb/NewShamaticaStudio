
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
            this.DatePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.DatePîckerFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarHorarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHorarioFrecuentado)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHorarioFrecuentado
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHorarioFrecuentado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHorarioFrecuentado.Legends.Add(legend1);
            this.chartHorarioFrecuentado.Location = new System.Drawing.Point(32, 144);
            this.chartHorarioFrecuentado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartHorarioFrecuentado.Name = "chartHorarioFrecuentado";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Serie";
            this.chartHorarioFrecuentado.Series.Add(series1);
            this.chartHorarioFrecuentado.Size = new System.Drawing.Size(800, 453);
            this.chartHorarioFrecuentado.TabIndex = 0;
            this.chartHorarioFrecuentado.Text = "chart1";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(29, 25);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(368, 35);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Horarios mas frecuentados";
            // 
            // DatePickerInicio
            // 
            this.DatePickerInicio.CustomFormat = "yyyy-MM-dd";
            this.DatePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerInicio.Location = new System.Drawing.Point(83, 96);
            this.DatePickerInicio.Name = "DatePickerInicio";
            this.DatePickerInicio.Size = new System.Drawing.Size(104, 20);
            this.DatePickerInicio.TabIndex = 2;
            // 
            // DatePîckerFin
            // 
            this.DatePîckerFin.CustomFormat = "yyyy-MM-dd";
            this.DatePîckerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePîckerFin.Location = new System.Drawing.Point(337, 96);
            this.DatePîckerFin.Name = "DatePîckerFin";
            this.DatePîckerFin.Size = new System.Drawing.Size(105, 20);
            this.DatePîckerFin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // btnMostrarHorarios
            // 
            this.btnMostrarHorarios.Location = new System.Drawing.Point(528, 94);
            this.btnMostrarHorarios.Name = "btnMostrarHorarios";
            this.btnMostrarHorarios.Size = new System.Drawing.Size(124, 29);
            this.btnMostrarHorarios.TabIndex = 6;
            this.btnMostrarHorarios.Text = "Mostrar";
            this.btnMostrarHorarios.UseVisualStyleBackColor = true;
            this.btnMostrarHorarios.Click += new System.EventHandler(this.btnMostrarHorarios_Click);
            // 
            // FrmHorariosMasFrecuentados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 634);
            this.Controls.Add(this.btnMostrarHorarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePîckerFin);
            this.Controls.Add(this.DatePickerInicio);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.chartHorarioFrecuentado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DateTimePicker DatePickerInicio;
        private System.Windows.Forms.DateTimePicker DatePîckerFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrarHorarios;
    }
}