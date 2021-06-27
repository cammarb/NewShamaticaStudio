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
    public partial class FrmGestionInstrumentos : Form
    {
        OpInstrumento objOpInstrumento = new OpInstrumento();
        private bool sortAscending = false;
        public FrmGestionInstrumentos()
        {
            InitializeComponent();
        }
        private void ActualizarDataGrid()
        {
            dgInstrumentos.DataSource = objOpInstrumento.ListarInstrumentos();
            dgInstrumentos.Columns["id_instrumento"].Visible = false;
            dgInstrumentos.Columns["nombre_instrumento"].HeaderText = "Nombre";
            dgInstrumentos.Columns["costo_instrumento"].HeaderText = "Costo";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            tbxNombre.Text = "";
            tbxCosto.Text = "";
            tbxNombre.Focus();

            lblInventarioTotal.Text = "Inventario total: S/." + objOpInstrumento.CalcularInventario();
        }

        private void CalcularInventario()
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text != "")
            {
                Instrumento objInstrumento = new Instrumento();
                objInstrumento.nombre_instrumento = tbxNombre.Text;
                objInstrumento.costo_instrumento = Convert.ToInt32(tbxCosto.Text);
                MessageBox.Show(objOpInstrumento.RegistarInstrumento(objInstrumento));
            }
            else
            {
                MessageBox.Show("No se ha podido registrar el instrumento");
            }
            ActualizarDataGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgInstrumentos.SelectedRows[0].Cells[0].Value);
            Instrumento objInstrumento = new Instrumento();
            objInstrumento.nombre_instrumento = tbxNombre.Text;
            objInstrumento.costo_instrumento = Convert.ToInt32(tbxCosto.Text);
            MessageBox.Show(objOpInstrumento.ModificarInstrumento(objInstrumento));
            ActualizarDataGrid();
        }

        private void FrmGestionInstrumentos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgInstrumentos.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(objOpInstrumento.EliminarInstrumento(id));
            ActualizarDataGrid();
        }

        private void dgInstrumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow filaselect = dgInstrumentos.Rows[e.RowIndex];
                tbxNombre.Text = filaselect.Cells["nombre_instrumento"].Value.ToString();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void dgInstrumentos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IEnumerable<Instrumento> listado = objOpInstrumento.ListarInstrumentos();
            String NombreColumSelec = dgInstrumentos.Columns[e.ColumnIndex].Name;
            if (sortAscending)
            {
                dgInstrumentos.DataSource = listado.OrderBy(_ => _.GetType().GetProperty(NombreColumSelec).GetValue(_)).ToList();
            }
            else
            {
                dgInstrumentos.DataSource = listado.OrderByDescending(_ => _.GetType().GetProperty(NombreColumSelec).GetValue(_)).ToList();
            }
            sortAscending = !sortAscending;
        }

        private void dgInstrumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Pintar background con degradado
        private void FormRegistrarCliente_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(92, 37, 141), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(92, 37, 141), Color.FromArgb(67, 137, 162), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
