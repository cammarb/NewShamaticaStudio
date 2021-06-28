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
using System.Drawing.Drawing2D;

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
            lblCodigo.Text += " "+objDetalle.id2_reserva;
            lblHorario.Text += " "+objDetalle.horario_reserva;
            lblFecha.Text += " "+fecha;
            lblSala.Text += " "+objDetalle.nom_sala;
            dgInstrumentos.DataSource = objDataReservaInstrumento.MostrarInstrumentosReservados(identificador);
        }

        private void FrmDetalleReserva_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(92, 37, 141), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(92, 37, 141), Color.FromArgb(67, 137, 162), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
