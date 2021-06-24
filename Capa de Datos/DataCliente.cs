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

        public string EliminarCliente(int dni)
        {
            using ( var contexto = new ShamaticaStudioEntities())
            {
                var delete = contexto.Clientes.Find(dni);
                contexto.Clientes.Remove(delete);
                contexto.SaveChanges();
                return "El cliente se elimino exitosamente";

            }
        }
        public List<Cliente> ListarClientePorNombre(string contenido)
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var encontrados = (from alguien in contexto.Clientes
                               where (alguien.cli_nombre.Contains(contenido))
                               select alguien).ToList();
            return encontrados;
        }
        public List<Cliente> ListarClientePorDNI(string dni)
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var encontrados = (from alguien in contexto.Clientes
                               where (alguien.cli_dni.ToString().Contains(dni))
                               select alguien).ToList();
            return encontrados;
        }
        public List<Cliente> ListarClientePorUniversidad(string uniservidad)
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var encontrados = (from alguien in contexto.Clientes
                               where (alguien.cli_universidad.Contains(uniservidad))
                               select alguien).ToList();
            return encontrados;
        }
        public List<Cliente> ListarClientePorSexo(string sexo)
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var encontrados = (from alguien in contexto.Clientes
                               where (alguien.cli_sexo.Contains(sexo))
                               select alguien).ToList();
            return encontrados;
        }
        public List<Cliente> ListarClientesPorDistrito(string distrito)
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var encontrados = (from alguien in contexto.Clientes
                               where (alguien.cli_distrito.Contains(distrito))
                               select alguien).ToList();
            return encontrados;
        }
        public List<Cliente> ListarClientePorEdad(string edad)
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var encontrados = (from alguien in contexto.Clientes
                               where (alguien.cli_edad.ToString().Contains(edad))
                               select alguien).ToList();
            return encontrados;
        }
        public List<EntityNumGeneroCliente> ListadoAgrupadoPorGeneroPorDefault()
        {
            List<EntityNumGeneroCliente> objNum = new List<EntityNumGeneroCliente>();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var outcome = from clientes in contexto.Clientes
                          group clientes by clientes.cli_sexo into NuevoGrupo
                          orderby NuevoGrupo.Key
                          select NuevoGrupo;
            foreach(var clientes in outcome)
            {
                EntityNumGeneroCliente obj = new EntityNumGeneroCliente();
                obj.genero = clientes.Key;
                obj.numclientes = clientes.Count();
                objNum.Add(obj);
            }
            return objNum;
        }
        public List<EntityNumClienteporDistrito> ListadoAgrupadoPorDistritoDefault()
        {
            List<EntityNumClienteporDistrito> objNum = new List<EntityNumClienteporDistrito>();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var outcome = from clientes in contexto.Clientes
                          group clientes by clientes.cli_distrito into NuevoGrupo
                          orderby NuevoGrupo.Key
                          select NuevoGrupo;
            foreach(var clientes in outcome)
            {
                EntityNumClienteporDistrito obj = new EntityNumClienteporDistrito();
                obj.distrito = clientes.Key;
                obj.numclientes = clientes.Count();
                objNum.Add(obj);
            }
            return objNum;
        }
        public List<EntityNumClienteporUniversidad> ListadoAgrupadoPorUniversidadDefault()
        {
            List<EntityNumClienteporUniversidad> objNum = new List<EntityNumClienteporUniversidad>();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var outcome = from clientes in contexto.Clientes
                          group clientes by clientes.cli_universidad into NuevoGrupo
                          orderby NuevoGrupo.Key
                          select NuevoGrupo;
            foreach(var clientes in outcome)
            {
                EntityNumClienteporUniversidad obj = new EntityNumClienteporUniversidad();
                obj.universidad = clientes.Key;
                obj.numclientes = clientes.Count();
                objNum.Add(obj);
            }
            return objNum;
        }

    }
}
