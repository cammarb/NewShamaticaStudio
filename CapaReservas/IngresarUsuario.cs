using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaReservas
{
    public class IngresarUsuario
    {
        DataUsuario objDataUsuario = new DataUsuario();

        public Usuario Login(Usuario objusuario)
        {
            return objDataUsuario.Login(objusuario);
        }
    }
}
