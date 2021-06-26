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
    }
}
