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

        private void FormPantallaAdministrador_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(168, 255, 120), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(168, 255, 120), Color.FromArgb(120, 255, 214), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void btnGestionarInstrumentos_Click(object sender, EventArgs e)
        {
            FrmGestionInstrumentos frm = new FrmGestionInstrumentos();
            frm.ShowDialog();
        }

        private void btnVerCliRegistrados_Click(object sender, EventArgs e)
        {
            FrmListadoCliente frm = new FrmListadoCliente();
            frm.ShowDialog();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            FrmGestionarCliente frm = new FrmGestionarCliente();
            frm.ShowDialog();
        }

        private void btnReportePorGenero_Click(object sender, EventArgs e)
        {
            FrmReportePorGenero frm = new FrmReportePorGenero();
            frm.ShowDialog();
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            FrmVerReservasAdministrador frm = new FrmVerReservasAdministrador();
            frm.ShowDialog();
        }

        private void btnSalasYHorarios_Click(object sender, EventArgs e)
        {
            FrmHorariosYSalas frm = new FrmHorariosYSalas();
            frm.ShowDialog();
        }

        private void btnHorarioMasReservado_Click(object sender, EventArgs e)
        {
            FrmHorariosMasFrecuentados frm = new FrmHorariosMasFrecuentados();
            frm.ShowDialog();
            this.Close();
        }
    }
}
