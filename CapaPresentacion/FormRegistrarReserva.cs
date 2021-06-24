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
        RegistrarReserva objRegistrarReserva = new RegistrarReserva();
        public FormRegistrarReserva()
        {
            InitializeComponent();
        }

        private void FormRegistrarReserva_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(92, 37, 141), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(92, 37, 141), Color.FromArgb(67, 137, 162), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {

        }
    }
}
