using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataAdmin
    {
        public string RegistrarAdministrador(Administrador objadmin)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                contexto.Administradores.Add(objadmin);
                contexto.SaveChanges();
                return "Se registro exitosamente";
            }
        }
        public string Eliminaradministrador(string dni)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var delete = contexto.Administradores.Find(dni);
                contexto.Administradores.Remove(delete);
                contexto.SaveChanges();
                return "El administrador se elimino exitosamente";

            }
        }
        public Administrador AdminExistente(Administrador objAdmin)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var result = (from someone in contexto.Administradores
                              where someone.dni_admin == objAdmin.dni_admin
                              
                              select someone).SingleOrDefault();
                return result;
            }

        }
        public Administrador AdmiExiste(Administrador objadmin)
        {
            using(var contexto = new ShamaticaStudioEntities())
            {
                var result = (from someone in contexto.Administradores
                              where someone.dni_admin == objadmin.dni_admin
                              
                              select someone).SingleOrDefault();
                return result;
            }

        }
    }
}
