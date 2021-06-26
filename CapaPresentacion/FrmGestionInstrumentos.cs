﻿using System;
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
    public partial class FrmGestionInstrumentos : Form
    {
        OpInstrumento objOpInstrumento = new OpInstrumento();
        private bool sortAscending = false;
        public FrmGestionInstrumentos()
        {
            InitializeComponent();
        }
        void ActualizarDataGrid()
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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text != "")
            {
                Instrumento objInstrumento = new Instrumento();
                objInstrumento.nombre_instrumento = tbxNombre.Text;
                objInstrumento.costo_instrumento = Convert.ToInt32(tbxCosto.Text);
                objInstrumento.disponibilidad_instrumento = true;
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
    }
}
