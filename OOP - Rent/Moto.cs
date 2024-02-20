namespace OOP___Rent
{
    public class Moto : Veiculo
    {
        public Moto() : base(25) // Taxa diária de moto é R$ 25
        {
        }
        public override double CalcularValorTotal(int numDiarias)
        {
            return TaxaDiaria * numDiarias;
        }
    }
}