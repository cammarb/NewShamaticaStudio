using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaReservas
{
    public class RegistrarReserva
    {
        DataReserva objDataReserva = new DataReserva();
        public string RegistrarReservation(Reserva objreserva)
        {
            return objDataReserva.RegistrarReservation(objreserva);
        }
        public Reserva ReservaExistente(Reserva objreserva)
        {
            return objDataReserva.ReservaExistente(objreserva);
        }
        public Reserva IDExiste(Reserva objreserva)
        {
            return objDataReserva.IDExiste(objreserva);
        }
    }
}
