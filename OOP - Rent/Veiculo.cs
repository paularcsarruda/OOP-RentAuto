namespace OOP___Rent
{
    public abstract class Veiculo
    {
        protected double TaxaDiaria { get; set; }

        public Veiculo(double taxaDiaria)
        {
            TaxaDiaria = taxaDiaria;
        }
        public abstract double CalcularValorTotal(int numDiarias);
    }
}