using Parcial2LastraJulian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2LastraJulian.Controller
{
    public class ClientesGenerator
    {
        public List<Cliente> clientesGen()
        {
            List<Cliente> ListClientes = new List<Cliente>();

            Cliente cliente1 = new Cliente();
            cliente1.Email = "cliente1@gmail.com";
            cliente1.Nombre = "Cliente1";
            ListClientes.Add(cliente1);

            Cliente cliente2 = new Cliente();
            cliente2.Email = "cliente2@gmail.com";
            cliente2.Nombre = "Cliente2";
            ListClientes.Add(cliente2);

            Cliente cliente3 = new Cliente();
            cliente3.Email = "cliente3@gmail.com";
            cliente3.Nombre = "Cliente3";
            ListClientes.Add(cliente3);

            Cliente cliente4 = new Cliente();
            cliente4.Email = "cliente4@gmail.com";
            cliente4.Nombre = "Cliente4";
            ListClientes.Add(cliente4);

            Cliente cliente5 = new Cliente();
            cliente5.Email = "cliente5@gmail.com";
            cliente5.Nombre = "Cliente5";
            ListClientes.Add(cliente5);

            return ListClientes;
        }
    }
}
