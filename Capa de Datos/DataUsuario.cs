using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataUsuario
    {
        

        public Usuario Login(Usuario objusuario)
        {   using (var contexto = new ShamaticaStudioEntities())
            {
                var result = (from someone in contexto.Usuarios
                              where someone.login == objusuario.login
                              && someone.password == objusuario.password
                              && someone.status == true
                              select someone).SingleOrDefault();
                return result;
            }
        }
        public string  RegistrarUsuario(Usuario objUsuario)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                contexto.Usuarios.Add(objUsuario);
                contexto.SaveChanges();
                return "Se registro exitosamente";
            }
        }
    }
}
