using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataDetalleReserva
    {
        public void AgregarDetalleReserva(DetalleReserva objdetallereserva)
        {
            using(var contexto = new ShamaticaStudioEntities())
            {
                contexto.DetalleReservas.Add(objdetallereserva);
                contexto.SaveChanges();
            }
        }
       public DetalleReserva BuscarDetalleReserva(int idreserva)
       {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var outcome = (from detalle in contexto.DetalleReservas
                                    where detalle.id2_reserva == idreserva
                               select detalle).SingleOrDefault();
                return outcome;
            }

       }
    }
}
