using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaReservas
{
    public class RegistrarCliente
    {
        DataCliente objDataCliente = new DataCliente();
        
        public string RegistrarClient(Cliente objcliente)
        {
            return objDataCliente.RegistrarClient(objcliente);
        }

       public Cliente ClienteExistente (Cliente objcliente)
        {
            return objDataCliente.ClienteExistente(objcliente);
        }
        public Cliente ClienteExiste(Cliente objcliente)
        {
            return objDataCliente.ClienteExiste(objcliente);
        }
        public List<Cliente> ListarCliente()
        {
            return objDataCliente.Listarclientesregistrados();
        }


    }
}
