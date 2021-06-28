using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaReservas;
using System.Drawing.Drawing2D;

namespace CapaPresentacion
{
    public partial class FrmReportePorGenero : Form
    {
        RegistrarCliente objCliente = new RegistrarCliente();
        public FrmReportePorGenero()
        {
            InitializeComponent();
        }
        void ActualizarGrafico(string filtrado)
        {
            if(filtrado == "Distrito")
            {
                lblEspecificacion.Text = "Grafico de clientes registrado por Distrito";
                charGenero.DataSource = objCliente.ListadoAgrupadoPorDistritoDefault();
                charGenero.Series["Serie"].XValueMember = "distrito";

                charGenero.Series["Serie"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                charGenero.Series["Serie"].YValueMembers = "numclientes";
                charGenero.Series["Serie"].IsValueShownAsLabel = true;

                charGenero.Series["Serie"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

                charGenero.DataBind();
            }
            if(filtrado == "Genero")
            {
                lblEspecificacion.Text = "Grafico de clientes registrado por genero";
                charGenero.DataSource = objCliente.ListadoClientePorGeneroDefault();
                charGenero.Series["Serie"].XValueMember = "genero";

                charGenero.Series["Serie"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                charGenero.Series["Serie"].YValueMembers = "numclientes";
                charGenero.Series["Serie"].IsValueShownAsLabel = true;

                charGenero.Series["Serie"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

                charGenero.DataBind();
            }
            if(filtrado == "Universidad")
            {
                lblEspecificacion.Text = "Grafico de clientes registrado por universidad";
                charGenero.DataSource = objCliente.ListadoAgrupadoPorUniversadDefault();
                charGenero.Series["Serie"].XValueMember = "universidad";

                charGenero.Series["Serie"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                charGenero.Series["Serie"].YValueMembers = "numclientes";
                charGenero.Series["Serie"].IsValueShownAsLabel = true;

                charGenero.Series["Serie"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

                charGenero.DataBind();
            }
        }

        private void FrmReportePorGenero_Load(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cbxFiltrado.Text;
            ActualizarGrafico(filtro);
        }

        private void FrmReportePorGenero_Paint(object sender, PaintEventArgs e)
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
