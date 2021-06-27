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

namespace CapaPresentacion
{
    public partial class FrmClientesQueMasReservan : Form
    {
        DataCliente objDataClientes = new DataCliente();
        public FrmClientesQueMasReservan()
        {
            InitializeComponent();
        }

        private void FrmClientesQueMasReservan_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgClientesFrecuentes.DataSource = objDataClientes.ClientesQueMasFrecuentan(dateInicio.Value.Date, dateFin.Value.Date);
            DgClientesFrecuentes.Columns["dni"].HeaderText = "DNI";
            DgClientesFrecuentes.Columns["name"].HeaderText = "Nombre";
            DgClientesFrecuentes.Columns["correo"].HeaderText = "Correo";
            DgClientesFrecuentes.Columns["cantidadDeReservasCliente"].HeaderText = "Cantidad de reservas realizadas";
        }
    }
}
