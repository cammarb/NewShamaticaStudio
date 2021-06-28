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

        public List<EntityHorarioMasReservado> HorarioMasFrecuentado(DateTime fechaInicio, DateTime fechaFin)
        {
            List<EntityHorarioMasReservado> objNum = new List<EntityHorarioMasReservado>();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
          
            var result = from horario in contexto.Horarios
                          join reserva in contexto.Reservas on horario.id_horario equals reserva.codigo_horario
                          where reserva.fecha_reserva >= fechaInicio && reserva.fecha_reserva <= fechaFin
                          group horario by horario.hora_reserva into NuevoGrupo
                         // orderby NuevoGrupo.Key
                          select NuevoGrupo;
            foreach(var abcde in result)
            {
                EntityHorarioMasReservado obj = new EntityHorarioMasReservado();
                obj.horario = abcde.Key;
                obj.cantidadhorariosrepetidos = abcde.Count();
                objNum.Add(obj);
            }
            return objNum;
        }        
    }
}
