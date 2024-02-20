namespace OOP___Rent
{
    public class Carro : Veiculo
    {
        public Carro() : base(50) // Taxa diária de carro é R$ 50
        {
        }
        public override double CalcularValorTotal(int numDiarias)
        {
            return TaxaDiaria * numDiarias;
        }
    }
}