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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrarCliente frm = new FormRegistrarCliente();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormRegistrarAdmin frm = new FormRegistrarAdmin();
            //frm.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresarAdministrador frm = new FormIngresarAdministrador();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresoCliente frm = new FormIngresoCliente();
            frm.Closed += (s, args) => this.Show();
            frm.ShowDialog();
        }
    }
}
