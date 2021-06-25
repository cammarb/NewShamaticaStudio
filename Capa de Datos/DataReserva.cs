using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataReserva
    {
        Random rnd = new Random();
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
                var result = (from  reservation in contexto.Reservas
                              where reservation.id_reserva == objreserva.id_reserva ||(
                               reservation.codigo2_sala   == objreserva.codigo2_sala
                              && reservation.fecha_reserva == objreserva.fecha_reserva
                              && reservation.codigo_horario == objreserva.codigo_horario)                      
                              select reservation).SingleOrDefault();
                return result;
            }
        
        }
        public Reserva IDExiste(Reserva objreserva)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var result = (from someone in contexto.Reservas
                              where someone.id_reserva == objreserva.id_reserva
                              select someone).SingleOrDefault();
                return result;
            }
        }
       /* public Reserva IDRandom(Reserva objreserva)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var newID = rnd.Next(100000, 999999);
                objreserva.id_reserva = newID  ;
                return newID;
            }
        }
       */
        public List<Reserva> Listarreservasregistrados()
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            return contexto.Reservas.ToList<Reserva>();
        }
    }
}
