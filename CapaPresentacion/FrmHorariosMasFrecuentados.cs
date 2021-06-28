using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaReservas;
using System.Drawing.Drawing2D;

namespace CapaPresentacion
{
    public partial class FrmHorariosMasFrecuentados : Form
    {
        OpHorario objOpHorario = new OpHorario();
        public FrmHorariosMasFrecuentados()
        {
            InitializeComponent();
        }

        private void FrmHorariosMasFrecuentados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarHorarios_Click(object sender, EventArgs e)
        {
            chartHorarioFrecuentado.DataSource = objOpHorario.HorarioMasReservado(DatePickerInicio.Value.Date, DatePîckerFin.Value.Date);
            chartHorarioFrecuentado.Series["Serie"].XValueMember = "horario";

            chartHorarioFrecuentado.Series["Serie"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartHorarioFrecuentado.Series["Serie"].YValueMembers = "cantidadhorariosrepetidos";
            chartHorarioFrecuentado.Series["Serie"].IsValueShownAsLabel = true;

            chartHorarioFrecuentado.Series["Serie"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chartHorarioFrecuentado.DataBind();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHorariosMasFrecuentados_Paint(object sender, PaintEventArgs e)
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
