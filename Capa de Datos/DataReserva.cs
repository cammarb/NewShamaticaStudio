using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataReserva
    {
        public string RegistrarReservation (Reserva objreserva)
        {
            using(var contexto = new ShamaticaStudioEntities())
            {
                contexto.Reservas.Add(objreserva);
                contexto.SaveChanges();
                return "Se guardó la reserva exitósamente";
            }
        }

        public Reserva ReservaExistente(Reserva objreserva)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var result = (from reservation in contexto.Reservas
                              where reservation.id_reserva.Equals(objreserva.id_reserva)
                              select reservation).SingleOrDefault();
                return result;
            }
        
        }

        public List<Reserva> Listarreservasregistrados()
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            return contexto.Reservas.ToList<Reserva>();
        }
    }
}
