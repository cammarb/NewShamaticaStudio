using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmInstrumentosReservadosPorFecha : Form
    {
        DataReservaInstrumento objDataReservaInstrumento = new DataReservaInstrumento();
        public FrmInstrumentosReservadosPorFecha()
        {
            InitializeComponent();
        }

        private void FrmInstrumentosReservadosPorFecha_Load(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chartInstrumento.DataSource = objDataReservaInstrumento.PromedioDeInstrumentosReservadosPorFecha((DatePicker.Value).Date);
            chartInstrumento.Series["Serie"].XValueMember = "nombre_instrumento";

            chartInstrumento.Series["Serie"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartInstrumento.Series["Serie"].YValueMembers = "contador_instrumento";
            chartInstrumento.Series["Serie"].IsValueShownAsLabel = true;

            chartInstrumento.Series["Serie"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chartInstrumento.DataBind();
            lblPromedioInstrumentosReservados.Text += " "+Convert.ToString(objDataReservaInstrumento.PromedioDeInstrumentosPorFechaEnValor(DatePicker.Value.Date));
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lblPromedioInstrumentosReservados_Click(object sender, EventArgs e)
        {

        }

        private void FrmInstrumentosReservadosPorFecha_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(67, 137, 162), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(67, 137, 162), Color.FromArgb(120, 255, 214), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
