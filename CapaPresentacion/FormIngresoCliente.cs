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

namespace CapaPresentacion
{
    public partial class FormIngresoCliente : Form
    {
        IngresarUsuario objIngresarUsuario = new IngresarUsuario();
        public static string userLogin;
        public static string userRol;


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

                if (kel == null)
                {
                    MessageBox.Show("Datos ingresados incorrectos, por favor ingrese un login valido");
                }
                else
                {
                    userLogin = kel.login;
                    userRol = kel.rol;

                    FormPantallaCliente frm = new FormPantallaCliente();
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
    }
    
}
