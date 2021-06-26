using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaReservas
{
    public class OpHorario
    {
        DataHorario objHorario = new DataHorario();
        public string AgregarHorario(Horario objhorario)
        {
            return objHorario.AgregarHorario(objhorario);
        }
        public string EliminarHorario(int id)
        {
            return objHorario.EliminarHorario(id);
        }
        public List<Horario> ListarHorario()
        {
            return objHorario.ListarHorarios();
        }
    }
}
