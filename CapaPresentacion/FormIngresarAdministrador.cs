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
    public partial class FormIngresarAdministrador : Form
    {
        IngresarUsuario objIngresarUsuario = new IngresarUsuario();

        public static string userLogin;
        public static string userRol;


        public FormIngresarAdministrador()
        {
            InitializeComponent();
        }

        private void btnIngresarAdmin_Click(object sender, EventArgs e)
        {

            if (Validacion())
            {
                Usuario objUsuario = new Usuario();
                objUsuario.login = txtDNIIngresoAdmin.Text.Trim();
                objUsuario.password = txtContraIngresoAdmin.Text.Trim();
                var kel = objIngresarUsuario.Login(objUsuario);

                if( kel == null || (kel!=null && kel.rol.Equals("client")))
                {
                    MessageBox.Show("Datos ingresados incorrectos, por favor ingrese un login valido");
                }
                else 
                {
                    userLogin = kel.login;
                    userRol = kel.rol;

                    this.Hide();
                    FormPantallaAdministrador frm = new FormPantallaAdministrador();
                    frm.Closed += (s, args) => this.Close();
                    frm.ShowDialog();
                }
            }

        }

        bool Validacion()
        {
            if(txtDNIIngresoAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un usuario valido");
                return false;
            }
            else
            {
                if(txtContraIngresoAdmin.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese una contraseña valida");
                    return false;
                }
            }
            return true;
        }

        private void FormIngresarAdministrador_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(67, 137, 162), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(67, 137, 162), Color.FromArgb(120, 255, 214), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
