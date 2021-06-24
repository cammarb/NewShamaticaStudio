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

}
