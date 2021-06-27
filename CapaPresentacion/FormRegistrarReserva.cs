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
        OpHorario objOpHorario;
        OpSala objOpSala;
        OpInstrumento objOpInstrumento;
        DataReservaInstrumento objReservaInstruemento;
        Reserva objReserva;
        DataDetalleReserva objDataDetalleReserva;
      
        
        RegistrarReserva objRegistrarReserva = new RegistrarReserva();
        public FormRegistrarReserva(Cliente objcliente)
        {
            InitializeComponent();
            objCliente = objcliente;
            objReserva = new Reserva();
            objOpHorario = new OpHorario();
            objOpSala = new OpSala();
            objOpInstrumento = new OpInstrumento();
            objReservaInstruemento = new DataReservaInstrumento();
            objDataDetalleReserva = new DataDetalleReserva();


        }
        private void FormRegistrarReserva_Load(object sender, EventArgs e)
        {
            cboxHorario.DataSource = objOpHorario.ListarHorario();
            cboxHorario.DisplayMember = "hora_reserva";
            cboxHorario.ValueMember = "id_horario";//int
            //cboxHorario.BindingContext = this->BindingContext;

            cboxSala.DataSource = objOpSala.ListarSalas();
            cboxSala.DisplayMember = "nom_sala";
            cboxSala.ValueMember = "cod_sala";//int

            clbInstrumentos.DataSource = objOpInstrumento.ListarInstrumentos();
            clbInstrumentos.DisplayMember = "nombre_instrumento";
            clbInstrumentos.ValueMember = "id_instrumento";
            
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
            objReserva.cliente_dni = objCliente.cli_dni;
            objReserva.codigo_horario = (int)cboxHorario.SelectedValue;
            objReserva.codigo2_sala = (int)cboxSala.SelectedValue;
            objReserva.fecha_reserva = DateTimeFecha.Value.Date;
            objCliente.cli_ultimareserva = objReserva.fecha_reserva;
            
            var res = objRegistrarReserva.ReservaExistente(objReserva);

            if (res == null )
            {
                MessageBox.Show("hola");              
                MessageBox.Show(objRegistrarReserva.RegistrarReservation(objReserva)); 
            }
            else
            {
                MessageBox.Show("Por favor vuelva a intentarlo");
            }
            
           //objdetalle.
           // objDataDetalleReserva.AgregarDetalleReserva
            foreach(Instrumento x in clbInstrumentos.CheckedItems)
            {
                objReservaInstruemento.AgregarReservaInstrumento(objReserva.id_reserva, x.id_instrumento);
            }
            DetalleReserva objdetalle = new DetalleReserva();
            objdetalle.horario_reserva = cboxHorario.Text;
            objdetalle.id2_reserva = objReserva.id_reserva;
            objdetalle.nombre_cliente = objCliente.cli_nombre;
            objdetalle.nom_sala = cboxSala.Text;
            objDataDetalleReserva.AgregarDetalleReserva(objdetalle);



        }

    }
}

