using System;
using System.Runtime.InteropServices;

namespace OOP___Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDiarias = 10;
            Console.WriteLine("|+---------------------------+|");
            Console.WriteLine("| Qual Veiculo deseja Alugar? |");
            Console.WriteLine("| [1] Carro                   |");
            Console.WriteLine("| [2] Moto                    |");
            Console.WriteLine("|+---------------------------+|");
            ConsoleKeyInfo opcao = Console.ReadKey(true);
            Console.ReadLine();

            if (opcao.KeyChar == '1')
            {
                Carro carro = new Carro();
                double valorTotalCarro = carro.CalcularValorTotal(numDiarias);
                Console.WriteLine($"O Valor total à pagar para 10 diárias de carro: R$ {valorTotalCarro:F2}");
            }
            else if (opcao.KeyChar == '2')
            {
                Moto moto = new Moto();
                double valorTotalMoto = moto.CalcularValorTotal(numDiarias);
                Console.WriteLine($"O Valor total à pagar para 10 diárias de moto: R$ {valorTotalMoto:F2}");
            }

            Console.ReadLine();
        }
    }
}
