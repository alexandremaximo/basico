using System;
using System.Globalization;

namespace Aula40ExRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo medida = new Retangulo();

            Console.Write("Informe a largura do retângulo: ");
            medida.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a altura do retângulo: ");
            medida.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área = " + medida.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + medida.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + medida.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
