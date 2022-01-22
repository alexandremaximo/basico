using System;
using System.Globalization;
namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double valDep = 0.0;

            Console.Write("Informe o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do titular da conta: ");
            string nomeTit = Console.ReadLine();
            Console.Write("Haverá depósito inicial [s/n]: ");
            char haDep = char.Parse(Console.ReadLine());

            if (haDep == 's')
            {
                Console.Write("Informe o valor do depósito: ");
                valDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBanco cliente = new ContaBanco(numConta, nomeTit, valDep);
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cliente);

            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            cliente.MovimentaConta(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);

            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            cliente.MovimentaConta(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * (-1));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);
        }
    }
}
