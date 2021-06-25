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
    public partial class FormIngresoCliente : Form
    {
        IngresarUsuario objIngresarUsuario = new IngresarUsuario();
        public static string userLogin;
        public static string userRol;

        DataCliente objDataCliente = new DataCliente();

        public FormIngresoCliente()
        {
            InitializeComponent();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Usuario objUsuario = new Usuario();
                objUsuario.login = txtDNILoginCliente.Text.Trim();
                objUsuario.password = txtContraLoginCliente.Text.Trim();
                var kel = objIngresarUsuario.Login(objUsuario);

                if (kel == null || (kel != null && kel.rol.Equals("admin")))
                {
                    MessageBox.Show("Datos ingresados incorrectos, por favor ingrese un login valido");
                }
                else 
                {
                    userLogin = kel.login;
                    userRol = kel.rol;

                    Cliente objcliente = objDataCliente.BuscarCliente(Convert.ToInt32(objUsuario.login));
                    FormPantallaCliente frm = new FormPantallaCliente(objcliente);
                    frm.ShowDialog();
                }
            }

        }

        bool Validacion()
        {
            if (txtDNILoginCliente.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un usuario valido");
                return false;
            }
            else
            {
                if (txtContraLoginCliente.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese una contraseña valida");
                    return false;
                }
            }
            return true;
        }

        private void FormIngresoCliente_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(92, 37, 141), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(92, 37, 141), Color.FromArgb(67, 137, 162), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
    
}
