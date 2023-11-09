using System.Collections.Generic;

namespace gestor_stock_clientes
{
    public class Piezas
    {
        private List<Pieza> listaPiezas;

        public Piezas(List<Pieza> piezas)
        {
            this.listaPiezas = piezas;
        }

        public List<Pieza> ListaPiezas
        {
            get => this.listaPiezas;
        }
    }
}