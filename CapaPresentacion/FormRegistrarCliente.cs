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
//Correo
using System.Net;
using System.Net.Mail;
using System.Web;


namespace CapaPresentacion
{
    public partial class FormRegistrarCliente : Form
    {
        RegistrarCliente objRegistrarCliente = new RegistrarCliente();
        GuardarUsuario objGuardarUsuario = new GuardarUsuario();
        
        public FormRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente objcliente = new Cliente();
            
            objcliente.cli_nombre = txtNombreCliente.Text;
            objcliente.cli_dni = int.Parse(txtDNICliente.Text.Trim());
            objcliente.cli_distrito = cboDistritoCliente.Text;
            objcliente.cli_correo = txtCorreoCliente.Text;
            objcliente.cli_edad = int.Parse(txtEdadCliente.Text);
            objcliente.cli_universidad = cboUNICliente.Text;
            objcliente.cli_sexo = cboSexoCliente.Text;
            objcliente.cli_banda = txtBandaCliente.Text;
            
            Usuario objUsuario = new Usuario();
            objUsuario.login = Convert.ToString(objcliente.cli_dni);
            objUsuario.password = txtContraseñaCliente.Text.Trim();
            objUsuario.status = true;
            objUsuario.rol = "client";
            var res = objRegistrarCliente.ClienteExistente(objcliente);
           // var res2 = objGuardarUsuario.RegistrarUsuario(objUsuario);

            MessageBox.Show("Hola");
            if ( res == null)
            {
                MessageBox.Show("Hola2");
                MessageBox.Show(objRegistrarCliente.RegistrarClient(objcliente));
                objGuardarUsuario.RegistrarUsuario(objUsuario);
                enviarCorreo(objcliente);
            }
            else
            {
                MessageBox.Show("Ya existe un usuario con estos datos, por favor vuelva a intentarlo");               
            }
        }
        // Enviar correo de confirmación
        public void enviarCorreo(/*Administrador objAdministrador , */Cliente objCliente)
        {
            string to = objCliente.cli_correo;
            string from = "camilamarb98@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the new SMTP client.";
            message.Body = @"Using this new feature, you can send an email message from an application very easily.";
            SmtpClient client = new SmtpClient("465");

            
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(from, "contraseña");

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
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
    }
}
