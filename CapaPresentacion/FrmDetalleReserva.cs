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
        string fecha;
        DataDetalleReserva objDetalleReserva;
        DetalleReserva objDetalle;
        DataReservaInstrumento objDataReservaInstrumento;
       
        public FrmDetalleReserva(int CodigoDeReserva, string paramfecha)
        {
            InitializeComponent();
            identificador = CodigoDeReserva;
            fecha = paramfecha;
            objDetalleReserva = new DataDetalleReserva();
            objDetalle = new DetalleReserva();
            objDetalle = objDetalleReserva.BuscarDetalleReserva(identificador);
            objDataReservaInstrumento = new DataReservaInstrumento();
           
        }

        private void FrmDetalleReserva_Load(object sender, EventArgs e)
        {
            lblCodigo.Text += objDetalle.id2_reserva;
            lblHorario.Text += objDetalle.horario_reserva;
            lblFecha.Text += fecha;
            lblSala.Text += objDetalle.nom_sala;
            dgInstrumentos.DataSource = objDataReservaInstrumento.MostrarInstrumentosReservados(identificador);
        }
    }
}
