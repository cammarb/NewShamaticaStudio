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
    public partial class FrmVerReservasAdministrador : Form
    {
        RegistrarReserva objReserva = new RegistrarReserva();
        public FrmVerReservasAdministrador()
        {
            InitializeComponent();
        }

        private void dTimeSelect_ValueChanged(object sender, EventArgs e)
        {
            dgReservasPorFecha.DataSource = objReserva.ListarReservaPorFecha(dTimeSelect.Value.Date);
            LimpiarDataGridView();
        }

        private void FrmVerReservasAdministrador_Load(object sender, EventArgs e)
        {
            dgReservasPorFecha.DataSource= objReserva.ListarReserva();
            LimpiarDataGridView();
        }
        void LimpiarDataGridView()
        {
        dgReservasPorFecha.Columns["id_reserva"].Visible = false;
        dgReservasPorFecha.Columns["cliente_dni"].HeaderText = "Cliente";
        dgReservasPorFecha.Columns["codigo_horario"].HeaderText = "Hora";
        dgReservasPorFecha.Columns["codigo2_sala"].HeaderText = "Sala";
        dgReservasPorFecha.Columns["fecha_reserva"].HeaderText = "Fecha";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVerReservasAdministrador_Paint(object sender, PaintEventArgs e)
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
