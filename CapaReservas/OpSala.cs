using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaReservas
{
    public class OpSala
    {
        DataSala objSala = new DataSala();
        public string RegistrarDSala(Sala sala)
        {
            return objSala.RegistrarSala(sala);
        }
        public string EliminarSala(int sala)
        {
            return objSala.EliminarSala(sala);
        }
        public List<Sala> ListarSalas()
        {
            return objSala.Listaralasregistrados();
        }
    }
}
