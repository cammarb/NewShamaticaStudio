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
        /*public DetalleReserva BuscarDetalleReserva(int idreserva)
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            DetalleReserva encontrado = contexto.DetalleReservas.Find(idreserva);
            return 
        }*/
    }
}
