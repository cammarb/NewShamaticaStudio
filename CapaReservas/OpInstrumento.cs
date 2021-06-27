using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaReservas
{
    public class OpInstrumento
    {
        DataInstrumento objInstrumento = new DataInstrumento();

        public string RegistarInstrumento(Instrumento instrumento)
        {
            return objInstrumento.RegistrarInstrumento(instrumento);
        }
        public string ModificarInstrumento(Instrumento instrumento)
        {
            return objInstrumento.ModificarInstrumento(instrumento);
        }
        public string EliminarInstrumento(int codinstrumento)
        {
            return objInstrumento.EliminarInstrumento(codinstrumento);
        }
        public List<Instrumento> ListarInstrumentos()
        {
            return objInstrumento.ListarInstrumentos();
        }

        public int CalcularInventario()
        {
            return objInstrumento.CalcularInventarioInstrumentos();
        }
    }
}
