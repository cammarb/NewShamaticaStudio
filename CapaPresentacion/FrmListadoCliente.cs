using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaReservas;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmListadoCliente : Form
    {
        RegistrarCliente objOpCliente = new RegistrarCliente();
        public FrmListadoCliente()
        {
            InitializeComponent();
            
        }

        private void FrmListadoCliente_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
        void ActualizarDataGridView()
        {
            dgClientes.DataSource = objOpCliente.ListarCliente();
            dgClientes.Columns["cli_dni"].HeaderText = "DNI";
            dgClientes.Columns["cli_nombre"].HeaderText = "Nombre";
            dgClientes.Columns["cli_edad"].HeaderText = "Edad";
            dgClientes.Columns["cli_universidad"].HeaderText = "Universidad";
            dgClientes.Columns["cli_distrito"].HeaderText = "Distrito";
            dgClientes.Columns["cli_correo"].Visible = false;
            dgClientes.Columns["cod_sala"].Visible = false;
            dgClientes.Columns["cli_)banda"].Visible = false;
        }
    }
}
