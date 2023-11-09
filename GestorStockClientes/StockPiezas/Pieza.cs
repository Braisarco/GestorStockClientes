namespace gestor_stock_clientes
{
    public class Pieza
    {
        private int cif;

        public Pieza(int numero)
        {
            this.cif = numero;
        }

        public int CIF
        {
            get => this.cif;
        }
    }
}