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
    }
}
