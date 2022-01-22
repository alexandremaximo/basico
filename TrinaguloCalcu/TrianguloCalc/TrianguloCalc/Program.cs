using System;
using System.Globalization;

namespace TrianguloCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ****Programa SEM ORIENTAÇÃO A OBJETOS****
            double areax, areay, x, y, z, a, b, c, p;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            Console.Write("Lado A: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (a + b + c) / 2;
            areax = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));


            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            Console.Write("Lado A: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (a + b + c) / 2;
            areay = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));

            Console.WriteLine("Área de X: " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areay.ToString("F4", CultureInfo.InvariantCulture));
            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }*/

            /*--------------------------------------------------------------*/
            /*
             * PROGRAMA COM ORIENTAÇÃO A OBJETOS*/

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            Console.Write("Lado A: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areax = x.Area();

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            Console.Write("Lado A: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areay = y.Area();

            Console.WriteLine("Área de X: " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
