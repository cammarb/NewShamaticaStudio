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
            dgReservasClientes.Columns["id_reserva"].Visible = false;
            dgReservasClientes.Columns["cliente_dni"].Visible = false;
            dgReservasClientes.Columns["codigo_horario"].HeaderText = "Hora";
            dgReservasClientes.Columns["codigo2_sala"].HeaderText = "Sala";
            dgReservasClientes.Columns["fecha_reserva"].HeaderText = "Fecha";

        }

        private void FrmReservasCliente_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
    }
}
