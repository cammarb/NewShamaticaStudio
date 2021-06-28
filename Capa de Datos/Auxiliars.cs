using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EntityClienteSala
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public int codsala { get; set; }
        public int numsala { get; set; }
    }
    public class EntityNumGeneroCliente
    {
        public string genero { get; set; }
        public int numclientes { get; set; }
    }
    public class EntityNumClienteporDistrito
    {
        public string distrito { get; set; }
        public int numclientes { get; set; }
    }
    public class EntityNumClienteporUniversidad
    {
        public string universidad { get; set; }
        public int numclientes { get; set; }
    }
    public class EntityHorarioMasReservado
    {
        public int cantidadhorariosrepetidos { get; set; }
        public string horario { get; set; }

    }

    public class EntityClienteQueMasReserva
    {
        public int dni { get; set; }
        public string name { get; set; }
        public string correo { get; set; }
        public int cantidadDeReservasCliente { get; set; }
    }
    
    public class EntityInstrumentoReservado
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }

    public class EntityPromedioDeInstrumentosReservados
    {
        public int contador_instrumento { get; set; }
        public string nombre_instrumento { get; set; }
    }

}
