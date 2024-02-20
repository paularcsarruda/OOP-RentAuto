using System;
using System.Runtime.InteropServices;

namespace OOP___Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            int numDiarias = 10;

            while (!sair)
            {
                Console.WriteLine("|+---------------------------+|");
                Console.WriteLine("| Qual Veiculo deseja Alugar? |");
                Console.WriteLine("| [1] Carro                   |");
                Console.WriteLine("| [2] Moto                    |");
                Console.WriteLine("| [0] Sair                    |");
                Console.WriteLine("|+---------------------------+|");
                ConsoleKeyInfo opcao = Console.ReadKey(true);
                Console.ReadLine();
                Console.Clear();

                switch (opcao.KeyChar)
                {
                    case '1':
                        Carro carro = new Carro();
                        double valorTotalCarro = carro.CalcularValorTotal(numDiarias);
                        Console.WriteLine($"Valor total à pagar para 10 diárias de carro: R$ {valorTotalCarro:F2}");
                        Console.ReadLine();
                        break;
                    case '2':
                        Moto moto = new Moto();
                        double valorTotalMoto = moto.CalcularValorTotal(numDiarias);
                        Console.WriteLine($"Valor total à pagar para 10 diárias de moto: R$ {valorTotalMoto:F2}");
                        break;
                    case '0':
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
