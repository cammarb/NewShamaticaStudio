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

namespace CapaPresentacion
{
    public partial class FrmDetalleReserva : Form
    {
        int identificador;
        DataDetalleReserva objDetalleReserva;
        DetalleReserva objDetalle;
        DataReservaInstrumento objDataReservaInstrumento;
       
        public FrmDetalleReserva(int CodigoDeReserva)
        {
            InitializeComponent();
            identificador = CodigoDeReserva;
            objDetalleReserva = new DataDetalleReserva();
            objDetalle = new DetalleReserva();
            objDetalle = objDetalleReserva.BuscarDetalleReserva(identificador);
            objDataReservaInstrumento = new DataReservaInstrumento();
           
        }

        private void FrmDetalleReserva_Load(object sender, EventArgs e)
        {
            lblCodigo.Text += objDetalle.id2_reserva;
            lblHorario.Text += objDetalle.horario_reserva;
            lblSala.Text += objDetalle.nom_sala;
            dgInstrumentos.DataSource = objDataReservaInstrumento.MostrarInstrumentosReservados(identificador);
        }
    }
}
