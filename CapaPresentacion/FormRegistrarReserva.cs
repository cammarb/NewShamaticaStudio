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
using CapaDatos;
using CapaReservas;

namespace CapaPresentacion
{
    public partial class FormRegistrarReserva : Form
    {
        Cliente objCliente;
        RegistrarReserva objRegistrarReserva = new RegistrarReserva();
        public FormRegistrarReserva(Cliente objcliente)
        {
            InitializeComponent();
            objCliente = objcliente;
        }

        // Pintar rectángulo con degradado
        private void FormRegistrarReserva_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(92, 37, 141), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(92, 37, 141), Color.FromArgb(67, 137, 162), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Reserva objReserva = new Reserva();

            objReserva.id_reserva = 1;
            objReserva.cli_dni = Convert.ToInt32(objCliente.cli_dni);
            objReserva.id_horario = Convert.ToInt32(cboxHorario.Text);
            objReserva.cod_sala = Convert.ToInt32(cboxSala.Text);
            DateTime x = new DateTime();
          
          

            var res = objRegistrarReserva.ReservaExistente(objReserva);

            MessageBox.Show("Hola");
            if (res == null)
            {
                MessageBox.Show("Hola2");
                MessageBox.Show(objRegistrarReserva.RegistrarReservation(objReserva));
            }
            else
            {
                MessageBox.Show("Por favor vuelva a intentarlo");
              
            }

        }
    }
}
