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
            var random = from reserva in contexto.Reservas
                         join reinstrumento in contexto.ReservasInstrumentos on reserva.id_reserva equals id
                         group reinstrumento by reinstrumento.id_instrumento into NuevoGrupo
                         select NuevoGrupo;
            foreach (var instrumento in contexto.Instrumentos)
            {
                EntityInstrumentoReservado obj = new EntityInstrumentoReservado();
                obj.Codigo = instrumento.id_instrumento;
                obj.Nombre = instrumento.nombre_instrumento;
                lista.Add(obj);
            }
            return lista;
        }
    }
}
