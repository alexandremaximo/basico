using System;
using System.Globalization;

namespace Aula40Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario pessoa1 = new Funcionario();
            Funcionario pessoa2 = new Funcionario();

            Console.WriteLine("Informe os dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Informe os dados do segundo funcionário: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (pessoa1.Salario + pessoa2.Salario) / 2;
            Console.WriteLine("A média dos salários é: " + media.ToString("F2", CultureInfo.InvariantCulture));

            
        }
    }
}
