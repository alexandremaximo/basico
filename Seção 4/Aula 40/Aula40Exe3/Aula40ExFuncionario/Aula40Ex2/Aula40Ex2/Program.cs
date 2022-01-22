using System;
using System.Globalization;

namespace Aula40Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Informe o Nome do funcionário: ");
            func.Nome = Console.ReadLine();
            Console.Write("Informe o Salário Bruto do funcionário: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine("Nome: " + func.Nome);
            Console.WriteLine("Salário Bruto: " + func.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Imposto: " + func.Imposto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Funcionário: " + func);
            
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados: "+func);

        }
    }
}
