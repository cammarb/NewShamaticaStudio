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
    public partial class FrmHorariosYSalas : Form
    {
        OpHorario objHorario = new OpHorario();
        OpSala objSala = new OpSala();
        public FrmHorariosYSalas()
        {
            InitializeComponent();
         
        }

        private void FrmHorariosYSalas_Load(object sender, EventArgs e)
        {
            ActualizarDataGridHorario();
            ActualizarDataSalas();
        }
        void ActualizarDataGridHorario()
        {
            dgHorarios.DataSource = objHorario.ListarHorario();
            dgHorarios.Columns["id_horario"].Visible = false;
            dgHorarios.Columns["hora_reserva"].HeaderText = "Hora Inicio de Reserva";
        }
        void ActualizarDataSalas()
        {
            dgSalas.DataSource = objSala.ListarSalas();
            dgSalas.Columns["cod_sala"].Visible = false;
            dgSalas.Columns["nom_sala"].HeaderText = "Nombre de la Sala";
        }
        
        

        private void btnRegistrarHorario_Click(object sender, EventArgs e)
        {
            
            Horario objhorario = new Horario();

            DateTime time = HorarioPicker.Value;
            objhorario.hora_reserva = time.ToString("hh:00 tt");
            MessageBox.Show(objHorario.AgregarHorario(objhorario));
            ActualizarDataGridHorario();
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgHorarios.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(objHorario.EliminarHorario(id));
            ActualizarDataGridHorario();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Sala objsala = new Sala();
            objsala.nom_sala = tbxNombreSala.Text;
            MessageBox.Show(objSala.RegistrarDSala(objsala));
            ActualizarDataSalas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgSalas.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(objSala.EliminarSala(id));
            ActualizarDataSalas();
        }
    }
}
