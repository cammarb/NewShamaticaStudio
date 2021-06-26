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
using CapaDatos;


namespace CapaPresentacion
{
    public partial class FormRegistrarReserva : Form
    {
        Cliente objCliente;
        Sala objSala;
        Instrumento objInstrumento;
        OpHorario objOpHorario;
        OpSala objOpSala;
        OpInstrumento objOpInstrumento;
        Horario objHorario;
        Reserva objReserva;
        
        RegistrarReserva objRegistrarReserva = new RegistrarReserva();
        public FormRegistrarReserva(Cliente objcliente)
        {
            InitializeComponent();
            objCliente = objcliente;
            objSala = new Sala();
            objHorario = new Horario();
            objReserva = new Reserva();
            objOpHorario = new OpHorario();
            objOpSala = new OpSala();
            objOpInstrumento = new OpInstrumento();


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
           // Random rnd = new Random();
           // MessageBox.Show("hola/");
           // objReserva.id_reserva =  rnd.Next(100000,999999);
            objReserva.cliente_dni = objCliente.cli_dni;
            //objHorario.id_horario = int.Parse(cboxHorario.Text);
            objReserva.codigo_horario = objHorario.id_horario;
            // objReserva.id_horario = Convert.ToInt32(cboxHorario.Text);
            objSala.cod_sala = int.Parse(cboxSala.Text);
           // objReserva.Sala = objSala.cod_sala;
            objReserva.codigo2_sala = objSala.cod_sala;
            objReserva.fecha_reserva = DateTimeFecha.Value.Date;
           

            MessageBox.Show("ga");
            //MessageBox.Show(objRegistrarReserva.RegistrarReservation(objReserva));

            //MessageBox.Show(objRegistrarReserva.RegistrarReservation(objReserva));
            var res = objRegistrarReserva.ReservaExistente(objReserva);
            //var res2 = objRegistrarReserva.IDExiste(objReserva);
            
          
            if (res == null )
            {
                MessageBox.Show("hola");              
                MessageBox.Show(objRegistrarReserva.RegistrarReservation(objReserva));               
            }
            else
            {
                MessageBox.Show("Por favor vuelva a intentarlo");
              
            }
            
        }

        private void FormRegistrarReserva_Load(object sender, EventArgs e)
        {
            cboxHorario.DataSource = objOpHorario.ListarHorario();
            cboxHorario.DisplayMember = "hora_reserva";
            cboxHorario.ValueMember = "id_horario";

            cboxSala.DataSource = objOpSala.ListarSalas();
            cboxSala.DisplayMember = "nom_sala";
            cboxSala.ValueMember = "cod_sala";

            //clbInstrumentos.Da
        }
    }
}

