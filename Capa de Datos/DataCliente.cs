using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class DataCliente
   {
        public string RegistrarClient (Cliente objcliente)
        {
            using(var contexto = new ShamaticaStudioEntities())
            {
                contexto.Clientes.Add(objcliente);
                contexto.SaveChanges();
                return "Se registro exitosamente";
            }
        }
        public Cliente ClienteExistente(Cliente objcliente)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var result = (from someone in contexto.Clientes
                              where someone.cli_dni.Equals(objcliente.cli_dni)
                              select someone).SingleOrDefault();
                return result;
            }

        }
        public Cliente ClienteExiste(Cliente objcliente)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var result = (from someone in contexto.Clientes
                              where someone.cli_dni.Equals(objcliente.cli_dni)
                              
                              select someone).SingleOrDefault();
                return result;
            }

        }
        public List<Cliente> Listarclientesregistrados()
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            return contexto.Clientes.ToList<Cliente>();
        }

        public string ModificarCliente(Cliente objcliente)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var modifi = contexto.Clientes.Find(objcliente.cli_dni);
                modifi.cli_nombre = objcliente.cli_nombre;
                modifi.cli_edad = objcliente.cli_edad;
                modifi.cli_distrito = objcliente.cli_distrito;
                modifi.cli_correo = objcliente.cli_correo;
                modifi.cli_banda = objcliente.cli_banda;
                modifi.cli_sexo = objcliente.cli_sexo;
                modifi.cod_sala = objcliente.cod_sala;
                modifi.cli_dni = objcliente.cli_dni;
                modifi.cli_universidad = objcliente.cli_universidad;
                contexto.SaveChanges();
                return "El cliente se modifico exitosamente";
            }
        }

        public string EliminarCliente(string dni)
        {
            using ( var contexto = new ShamaticaStudioEntities())
            {
                var delete = contexto.Clientes.Find(dni);
                contexto.Clientes.Remove(delete);
                contexto.SaveChanges();
                return "El cliente se elimino exitosamente";

            }
        }
        
   }
}
