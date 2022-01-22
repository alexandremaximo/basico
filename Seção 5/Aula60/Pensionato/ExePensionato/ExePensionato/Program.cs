using System;

namespace ExePensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];
            Console.Write("Quantos quartos serão alugados: ");
            int qtdQuartos = int.Parse(Console.ReadLine());
           

            for (int cont = 1; cont <= qtdQuartos; cont++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + cont.ToString() + ":");

                Console.Write("Nome: ");
                string Nome = Console.ReadLine();

                Console.Write("E-mail: ");
                string Email = Console.ReadLine();

                Console.Write("Quarto: ");
                int Quarto = int.Parse(Console.ReadLine());

                quartos[Quarto] = new Estudante(Nome, Email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int cont = 0; cont < quartos.Length; cont++)
            {
                if(quartos[cont] != null)
                {
                    Console.WriteLine(cont+": "+quartos[cont]);
                }
                
            }

        }
    }
}
