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
    public partial class FrmGestionarCliente : Form
    {
        RegistrarCliente objCliente = new RegistrarCliente();
        public FrmGestionarCliente()
        {
            InitializeComponent();
        }

        private void FrmGestionarCliente_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
        void ActualizarDataGridView()
        {
            dgClientes.DataSource = objCliente.ListarCliente();
            dgClientes.Columns["cli_dni"].HeaderText = "DNI";
            dgClientes.Columns["cli_nombre"].HeaderText = "Nombre";
            dgClientes.Columns["cli_edad"].HeaderText = "Edad";
            dgClientes.Columns["cli_universidad"].HeaderText = "Universidad";
            dgClientes.Columns["cli_distrito"].HeaderText = "Distrito";
            dgClientes.Columns["cli_sexo"].HeaderText = "Sexo";
            dgClientes.Columns["cli_correo"].HeaderText = "Correo";
            dgClientes.Columns["codigo_sala"].Visible = false;
            dgClientes.Columns["cli_banda"].HeaderText = "Banda";
            dgClientes.Columns["cli_ultimareserva"].HeaderText = "Ultima Reserva";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(dgClientes.SelectedRows[0].Cells[0].Value);

            Cliente tmpCliente = new Cliente();
            tmpCliente.cli_dni = dni;
            tmpCliente.cli_nombre = txtNombreCliente.Text;
            tmpCliente.cli_edad = Convert.ToInt32(txtEdadCliente.Text);
            tmpCliente.cli_correo = txtCorreoCliente.Text;
            tmpCliente.cli_distrito = cboDistritoCliente.Text;
            tmpCliente.cli_universidad = cboUNICliente.Text;
            tmpCliente.cli_sexo = cboSexoCliente.Text;
            MessageBox.Show(objCliente.ModificarCliente(tmpCliente));
            ActualizarDataGridView();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(dgClientes.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(objCliente.EliminarCliente(dni));
            ActualizarDataGridView();
        }

        private void FrmGestionarCliente_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(67, 137, 162), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(67, 137, 162), Color.FromArgb(120, 255, 214), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
