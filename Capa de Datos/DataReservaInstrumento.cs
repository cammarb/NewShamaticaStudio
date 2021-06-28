using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataReservaInstrumento
    {
        public void AgregarReservaInstrumento(int identificadorreserva, int identificadorinstrumento)
        {
            ReservaInstrumento InstrumentoReservado = new ReservaInstrumento();
            InstrumentoReservado.id_reservarel = identificadorreserva;
            InstrumentoReservado.id_instrumento = identificadorinstrumento;
            using (var contexto = new ShamaticaStudioEntities())
            {
                contexto.ReservasInstrumentos.Add(InstrumentoReservado);
                contexto.SaveChanges();
            }
        }
        public void EliminarReservaInstrumento(int id)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var delete = contexto.ReservasInstrumentos.Find(id);
                contexto.ReservasInstrumentos.Remove(delete);
                contexto.SaveChanges();
            }
        }
        public List<EntityInstrumentoReservado> MostrarInstrumentosReservados(int id)
        {
            List<EntityInstrumentoReservado> lista = new List<EntityInstrumentoReservado>();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var random = (from reserva in contexto.ReservasInstrumentos
                          where reserva.id_reservarel == id
                          join instroomento in contexto.Instrumentos on reserva.id_instrumento equals instroomento.id_instrumento
                          group instroomento by instroomento.id_instrumento into NuevoGrupo
                          select NuevoGrupo).ToList();
            foreach (var abc in random)
            {
                EntityInstrumentoReservado obj = new EntityInstrumentoReservado();
                obj.Codigo = abc.Key;
                DataInstrumento tmpinstrumento = new DataInstrumento();
                obj.Nombre = tmpinstrumento.BuscarInstrumento(obj.Codigo);
                lista.Add(obj);
            }
            return lista;
        }
        public List<EntityPromedioDeInstrumentosReservados> PromedioDeInstrumentosReservadosPorFecha(DateTime fecha)
        {
            List<EntityPromedioDeInstrumentosReservados> lista = new List<EntityPromedioDeInstrumentosReservados>();
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            /*var random = (from reserva in contexto.Reservas
                          where reserva.fecha_reserva == fecha.Date
                          join reservainstrumento in contexto.ReservasInstrumentos on reserva.id_reserva equals reservainstrumento.id_reservarel
                          group reservainstrumento by reservainstrumento.id_instrumento into GrupoIdInstrumentos
                          from instrumento in contexto.Instrumentos
                          where instrumento.id_instrumento == GrupoIdInstrumentos.Key
                          group instrumento by instrumento.nombre_instrumento into InstrumentosAgrupados
                          select InstrumentosAgrupados);*/
            var random = from reservas in contexto.Reservas
                         join reservainstrumento in contexto.ReservasInstrumentos on reservas.id_reserva equals reservainstrumento.id_reservarel
                         where reservas.fecha_reserva == fecha.Date
                         group reservainstrumento by reservainstrumento.id_instrumento into GrupoIds
                         select GrupoIds;


            foreach(var abc in random)
            {
                EntityPromedioDeInstrumentosReservados obj = new EntityPromedioDeInstrumentosReservados();
                DataInstrumento dinst = new DataInstrumento();
                obj.nombre_instrumento = dinst.BuscarInstrumento((int)abc.Key);
                obj.contador_instrumento = abc.Count();
                lista.Add(obj);
            }
            return lista;
        }
    }
}
