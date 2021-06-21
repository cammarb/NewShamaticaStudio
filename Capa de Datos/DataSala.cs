using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataSala
    {
        public string RegistrarSala(Sala objsala)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                contexto.Salas.Add(objsala);
                contexto.SaveChanges();
                return "Se registro exitosamente";
            }
        }
        public List<Sala> Listarsalasregistrados()
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            return contexto.Salas.ToList<Sala>();
        }

        public string ModificarSala(Sala objsala)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var modifi = contexto.Salas.Find(objsala.cod_sala);
                modifi.cod_sala = objsala.cod_sala;
                modifi.num_sala = objsala.num_sala;
                contexto.SaveChanges();
                return "La sala se modifico exitosamente";
            }
        }

        public string EliminarSala(string codisala)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var delete = contexto.Salas.Find(codisala);
                contexto.Salas.Remove(delete);
                contexto.SaveChanges();
                return "La sala se elimino exitosamente";

            }
        }
    }
}
