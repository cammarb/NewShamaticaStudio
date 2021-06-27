using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaReservas
{
    public class GuardarUsuario
    {
        DataUsuario objDataUsuario = new DataUsuario();
        public string RegistrarUsuario(Usuario objUsuario )
        {
            return objDataUsuario.RegistrarUsuario(objUsuario);
        }
    }
}
