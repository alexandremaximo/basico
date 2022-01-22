using System;
using System.Globalization;

namespace Aula48Ex1
{
    class ConversorDeMoeda
    {
        public static double Dolar;
        public static double Compra;

        public static double Conversor()
        {
            return (Dolar * Compra) + ((Dolar * Compra) * 6.0 / 100);
        }
    }
}
