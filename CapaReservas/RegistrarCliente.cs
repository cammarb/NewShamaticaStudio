﻿using System;
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
        public List<Cliente> ListarClientePorNombre(string contenido)
        {
            return objDataCliente.ListarClientePorNombre(contenido);
        }
        public List<Cliente> ListarClientePorDNI(int dni)
        {
            return objDataCliente.ListarClientePorDNI(dni);
        }
        public List<Cliente> ListarClientePorSexo(string sexo)
        {
            return objDataCliente.ListarClientePorSexo(sexo);
        }
        public List<Cliente> LIstarClientePorDistrito(string distrito)
        {
            return objDataCliente.ListarClientesPorDistrito(distrito);
        }
        public List<Cliente> ListarClientePorUniversidad(string universidad)
        {
            return objDataCliente.ListarClientePorUniversidad(universidad);
        }
        public List<Cliente> ListarClientePorEdad(int edad)
        {
            return objDataCliente.ListarClientePorEdad(Convert.ToString(edad));
        }


    }
}
