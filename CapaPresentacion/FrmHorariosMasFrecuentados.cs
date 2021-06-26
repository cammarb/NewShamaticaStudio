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
            //lblEspecificacion.Text = "Grafico de clientes registrado por Distrito";
            chartHorarioFrecuentado.DataSource = objOpHorario.HorarioMasReservado();
            chartHorarioFrecuentado.Series["Serie"].XValueMember = "horario";

            chartHorarioFrecuentado.Series["Serie"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chartHorarioFrecuentado.Series["Serie"].YValueMembers= "cantidadhorariosrepetidos";

            chartHorarioFrecuentado.Series["Serie"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chartHorarioFrecuentado.DataBind();
        }

    }
}
