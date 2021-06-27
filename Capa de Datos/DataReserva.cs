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
                              where
                               reservation.codigo2_sala   == objreserva.codigo2_sala
                              && reservation.fecha_reserva == objreserva.fecha_reserva
                              && reservation.codigo_horario == objreserva.codigo_horario                    
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
       
        public List<Reserva> ListarReserva()
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            return contexto.Reservas.ToList<Reserva>();
        }
        public List<Reserva> ListarReservaPorCliente(Cliente objcliente)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var lista = (from reservas in contexto.Reservas
                             where reservas.cliente_dni == objcliente.cli_dni
                             select reservas).ToList();
                return lista;
            }
        }
        public List<Reserva> ListarReservaPorFecha(DateTime fecha)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var listado = (from reservas in contexto.Reservas
                               where reservas.fecha_reserva == fecha
                               select reservas).ToList();
                return listado;
            }
        }


    }
}
