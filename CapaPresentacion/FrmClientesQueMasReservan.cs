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
using System.Drawing.Drawing2D;

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

        private void FrmClientesQueMasReservan_Paint(object sender, PaintEventArgs e)
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
