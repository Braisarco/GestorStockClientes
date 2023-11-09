using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace gestor_stock_clientes.Properties
{
    public class Clientes
    {
        private List<Cliente> listaClientes;

        public Clientes()
        {
            if (this.listaClientes == null)
            {
                this.listaClientes = new List<Cliente>();
            }
        }

        public Clientes(IEnumerable<Cliente> clientes)
        {
            this.listaClientes = clientes.ToList();
        }

        public Clientes(Cliente cliente)
        {
            this.listaClientes = new List<Cliente>();
            this.listaClientes.Add(cliente);
        }

        public void AñadirCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                this.listaClientes.Add(cliente);
            }
            else
            {
                Console.WriteLine("El cliente no puede ser nulo");
            }
        }

        public void EliminarCliente(int cif)
        {
            //Eliminar un cliente con un cif concreto
        }
        
        public IEnumerable<Cliente> ListaClientes
        {
            get => this.listaClientes;
        }
        
        public XElement toXML()
        {
            XElement root = new XElement("clientes");
            foreach (Cliente cliente in this.listaClientes)
            {
                root.Add(cliente.toXML());
            }
            return root;
        }
        
        public void saveXML()
        {
             toXML().Save("Pacientes.xml");
        }
        
        public override string ToString()
        {
            StringBuilder toret = new StringBuilder();
            foreach (Cliente cliente in this.listaClientes)
            {
                toret.Append(cliente.ToString());
                toret.Append("\n---------------\n");
            }
            return toret.ToString();
        }
    }
}