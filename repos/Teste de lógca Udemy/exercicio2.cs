using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_lógca_Udemy
{
    class exercicio2
    {
        private static void Main(string[] args)
        {
            double area, raio, pi = 3.14159;

            Console.WriteLine("Informe o raio do círculo: ");
            raio = double.Parse(Console.ReadLine());

            area = (pi * (raio * raio));

            Console.WriteLine("O área do círculo é: "+Math.Round(area,4));

        }
    }
}
