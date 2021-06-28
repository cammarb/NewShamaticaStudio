using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CapaPresentacion
{
    public partial class FormPantallaAdministrador : Form
    {
        public FormPantallaAdministrador()
        {
            InitializeComponent();
        }

        // Pintar degradado del form
        private void FormPantallaAdministrador_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(67, 137, 162), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(67, 137, 162), Color.FromArgb(120, 255, 214), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void btnGestionarInstrumentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGestionInstrumentos frm = new FrmGestionInstrumentos();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnVerCliRegistrados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListadoCliente frm = new FrmListadoCliente();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGestionarCliente frm = new FrmGestionarCliente();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnReportePorGenero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReportePorGenero frm = new FrmReportePorGenero();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVerReservasAdministrador frm = new FrmVerReservasAdministrador();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnSalasYHorarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHorariosYSalas frm = new FrmHorariosYSalas();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnHorarioMasReservado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHorariosMasFrecuentados frm = new FrmHorariosMasFrecuentados();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void btnClientesFrecuentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmClientesQueMasReservan frm = new FrmClientesQueMasReservan();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();

        }

        private void btnGraficoInstrumentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInstrumentosReservadosPorFecha frm = new FrmInstrumentosReservadosPorFecha();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }
    
    }
}
