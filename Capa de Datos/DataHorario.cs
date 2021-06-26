using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataHorario
    {
        public string AgregarHorario(Horario horario)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                contexto.Horarios.Add(horario);
                contexto.SaveChanges();
                return "Se guardo el horario correctamente";
            }
        }

        public string EliminarHorario(int id)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var delete = contexto.Horarios.Find(id);
                contexto.Horarios.Remove(delete);
                contexto.SaveChanges();
                return "El horario se elimino exitosamente";
            }
        }
        public List<Horario> ListarHorarios()
        {
           ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
           return contexto.Horarios.ToList<Horario>();
        }
    }
}
