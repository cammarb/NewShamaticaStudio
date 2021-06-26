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
        void DataGridViewDefault()
        {
            dgClientes.DataSource = objOpCliente.ListarCliente();
        }

        private void FrmListadoCliente_Load(object sender, EventArgs e)
        {
            lblPromedio.Text = "Promedio de edades genera;es: " + objOpCliente.PromedioGeneralDeEdadesDeCliente();
            DataGridViewDefault();
            LimpiarDataGridView();
        }
        void LimpiarDataGridView()
        {
            dgClientes.Columns["cli_dni"].HeaderText = "DNI";
            dgClientes.Columns["cli_nombre"].HeaderText = "Nombre";
            dgClientes.Columns["cli_edad"].HeaderText = "Edad";
            dgClientes.Columns["cli_universidad"].HeaderText = "Universidad";
            dgClientes.Columns["cli_distrito"].HeaderText = "Distrito";
            dgClientes.Columns["cli_sexo"].HeaderText = "Sexo";
            dgClientes.Columns["cli_correo"].Visible = false;
            dgClientes.Columns["codigo_sala"].Visible = false;
            dgClientes.Columns["cli_banda"].Visible = false;
           // dgClientes.Columns["Reserva"].Visible = false;
        }

        private void tbxMiscelaneo_TextChanged(object sender, EventArgs e)
        {
            if (cbxFiltrado.Text != "")
            {
                if (cbxFiltrado.Text.Equals("Nombre"))
                {
                    dgClientes.DataSource= objOpCliente.ListarClientePorNombre(tbxMiscelaneo.Text); LimpiarDataGridView();
                }
                if (cbxFiltrado.Text.Equals("Edad"))
                {
                    if (tbxMiscelaneo.Text.Equals(""))
                    {
                        tbxMiscelaneo.Text = "0";
                    }
                    dgClientes.DataSource = objOpCliente.ListarClientePorEdad(Convert.ToInt32(tbxMiscelaneo.Text)); LimpiarDataGridView();
                }
                if (cbxFiltrado.Text.Equals("Distrito"))
                {
                    dgClientes.DataSource = objOpCliente.LIstarClientePorDistrito(tbxMiscelaneo.Text); LimpiarDataGridView();
                }
                if (cbxFiltrado.Text.Equals("Sexo"))
                {
                    dgClientes.DataSource = objOpCliente.ListarClientePorSexo(tbxMiscelaneo.Text); LimpiarDataGridView();
                }
                if (cbxFiltrado.Text.Equals("Universidad"))
                {
                    dgClientes.DataSource = objOpCliente.ListarClientePorUniversidad(tbxMiscelaneo.Text); LimpiarDataGridView();
                }
                if (cbxFiltrado.Text.Equals("Dni"))
                {
                    dgClientes.DataSource = objOpCliente.ListarClientePorDNI(tbxMiscelaneo.Text); LimpiarDataGridView();
                    if (tbxMiscelaneo.Text.Equals(""))
                    {
                        tbxMiscelaneo.Text = "0";
                    }
                }
            }
            else
            {
               
                MessageBox.Show("Porfavor seleccion una metodo de filtrado");
                DataGridViewDefault();
                LimpiarDataGridView();
            }
           

        }
    }
}
