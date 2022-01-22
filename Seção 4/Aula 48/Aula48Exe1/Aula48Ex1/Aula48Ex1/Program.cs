using System;
using System.Globalization;

namespace Aula48Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do Dólar: ");
            ConversorDeMoeda.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dólares você vai comprar: ");
            ConversorDeMoeda.Compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = "+ConversorDeMoeda.Conversor().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
