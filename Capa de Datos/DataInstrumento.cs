using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataInstrumento
    {
        public string RegistrarInstrumento(Instrumento objInstrumento)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                contexto.Instrumentos.Add(objInstrumento);
                contexto.SaveChanges();
                return "Se registro el instrumento exitosamente";
            }
        }
        public List<Instrumento> ListarInstrumentos()
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            return contexto.Instrumentos.ToList<Instrumento>();
        }

        public string ModificarInstrumento(Instrumento objInstrumento)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var modifi = contexto.Instrumentos.Find(objInstrumento.id_instrumento);
                modifi.costo_instrumento = objInstrumento.costo_instrumento;
                modifi.nombre_instrumento = objInstrumento.nombre_instrumento;
                contexto.SaveChanges();
                return "El instrumento se modifico exitosamente";
            }
        }

        public string EliminarInstrumento(int codinstrumento)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var delete = contexto.Instrumentos.Find(codinstrumento);
                contexto.Instrumentos.Remove(delete);
                contexto.SaveChanges();
                return "El instrumento se elimino exitosamente";

            }
        }
        public string BuscarInstrumento(int id)
        {
            using (var contexto = new ShamaticaStudioEntities())
            {
                var result = (from something in contexto.Instrumentos
                              where something.id_instrumento == id
                              select something).SingleOrDefault();
                return result.nombre_instrumento;
            }
        }
        public int CalcularInventarioInstrumentos()
        {
            ShamaticaStudioEntities contexto = new ShamaticaStudioEntities();
            var outcome = Convert.ToInt32((from instrumento in contexto.Instrumentos
                           select instrumento.costo_instrumento).ToList().Sum());
            return outcome;
        }
        
    }
}
