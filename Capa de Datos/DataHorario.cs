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

        public List<EntityHorarioMasReservado> HorarioMasFreuentado()
        {
            List<EntityHorarioMasReservado> objNum = new List<EntityHorarioMasReservado>();
            List<EntityHorarioMasReservado> owo = new List<EntityHorarioMasReservado>();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var outcome = from reserva in contexto.Reservas
                          group reserva by reserva.codigo_horario into NuevoGrupo
                          orderby NuevoGrupo.Key
                          select NuevoGrupo;
            /*foreach (var reservass in outcome)
            {
                EntityHorarioMasReservado obj = new EntityHorarioMasReservado();
                obj.horario = (int)reservass.Key;
                obj.cantidadhorariosrepetidos = reservass.Count();
                objNum.Add(obj);
            }*/
           
            var lmaoo = from horario in contexto.Horarios
                          join reserva in contexto.Reservas on horario.id_horario equals reserva.codigo_horario
                          group horario by horario.hora_reserva into NuevoGrupo
                         // orderby NuevoGrupo.Key
                          select NuevoGrupo;
            foreach(var abcde in lmaoo)
            {
                EntityHorarioMasReservado obj = new EntityHorarioMasReservado();
                obj.horario = abcde.Key;
                obj.cantidadhorariosrepetidos = abcde.Count();
                objNum.Add(obj);
            }

            return objNum;

        }
       /* public string RenombrarElementos()
        {
            HorarioMasFreuentado();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var result = (from horario in contexto.Horarios
                          where horario.id_horario == HorarioMasFreuentado(). )
        }*/
        
    }
}
