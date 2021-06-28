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
    public partial class FrmReservasCliente : Form
    {
        RegistrarReserva objReserva = new RegistrarReserva();
        Cliente objCliente;
        public FrmReservasCliente(Cliente objcliente)
        {
            InitializeComponent();
            objCliente = objcliente;
        }
        void ActualizarDataGridView()
        {
            dgReservasClientes.DataSource = objReserva.ListarReservaPorCliente(objCliente);
            dgReservasClientes.Columns["id_reserva"].HeaderText = "ID de la reserva";
            dgReservasClientes.Columns["cliente_dni"].Visible = false;
            dgReservasClientes.Columns["codigo_horario"].Visible = false;
            dgReservasClientes.Columns["codigo2_sala"].Visible = false;
            dgReservasClientes.Columns["fecha_reserva"].HeaderText = "Fecha";
        }

        private void FrmReservasCliente_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void dgReservasClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgReservasClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow filaSeleccionada = dgReservasClientes.Rows[e.RowIndex];
                int id = Convert.ToInt32(dgReservasClientes.SelectedRows[0].Cells[0].Value);
                string fecha= Convert.ToString(dgReservasClientes.SelectedRows[0].Cells[4].Value);
                //fecha = fecha.();
                FrmDetalleReserva frm = new FrmDetalleReserva(id,fecha);
                frm.ShowDialog();
            }
            
        }

        private void False(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReservasCliente_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(92, 37, 141), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(92, 37, 141), Color.FromArgb(67, 137, 162), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
