using System;
using System.Globalization;

namespace Aula40Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();
            
            Console.Write("Digite o Nome do Aluno: ");
            al.Nome = Console.ReadLine();
            Console.Write("Digite a nota do primeiro Trimestre: ");
            al.Nota = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota do segundo Trimestre: ");
            al.Nota += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota do terceiro Trimestre: ");
            al.Nota += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine("Nota final: "+(al.Nota/3).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(al.ProcNota());
        }
    }
}
