using System.Collections.Generic;
using System.Xml.Linq;

namespace gestor_stock_clientes.Properties
{
    public class Cliente
    {
        private string cif;
        private string nombre;
        private string direccionFacturacion;
        private List<int> codigoPiezasVendidas;

        public Cliente(string cif, string nombre)
        {
            this.cif = cif;
            this.nombre = nombre;
        }

        public Cliente(string cif, string nombre, string direccion, IEnumerable<Pieza> piezas)
        {
            this.cif = cif;
            this.nombre = nombre;
            this.direccionFacturacion = direccion;
            this.codigoPiezasVendidas = new List<int>();
            foreach (Pieza p in piezas)
            {
                this.codigoPiezasVendidas.Add(p.CIF);
            }
        }

        public XElement toXML()
        {
            //Devolve un XElement de un cliente
        }
        
        public string CIF
        {
            get => this.cif;
        }

        public string Nombre
        {
            get => this.nombre;
        }

        public string DireccionFacturacion
        {
            get => this.direccionFacturacion;
            set => this.direccionFacturacion = value;
        }

        public List<int> CodigoPiezasVendidas
        {
            get => this.codigoPiezasVendidas;
        }
        
        public override string ToString()
        {
            return $"CIF: {this.cif}\nNombre: {this.nombre}\nDireccion: {this.direccionFacturacion}";
        }
    }
}