using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100; // sbyte Não precisa do Using System
            SByte y = 100; // SByte Precisa do Using System
            char letra = '\u0041';//informa para a variável que ela receberá um caractere unicode
            float z = 4.5f;//precisa do f na frente do número para o programa entender que é float.
            double w = 4.5;
            string nome = "Alexandre"; //quando for um único caractere, usamos '' (aspas simples)
                                       //se for um conjunto de caracteres, usamos "" (Aspas duplas)
            object qualquer = 'F';
            object qualquer2 = 23;
            object qualquer3 = "Alexandre";//Tipo object cria um objeto aleatório. Recebe qualquer valor.

            /*Console.Write("digite alguma merda: ");
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(letra);
            Console.WriteLine(x + y);*/

            byte n1 = 255; // Não aceita número negativos e só vai até 255.
                           // Se você somar 1 ao 255, o byte/sbyte volta para o número mais baixo.
            n1++;
            Console.WriteLine(n1);
            Console.WriteLine("Digite um número foda: ");
            int t = int.Parse(Console.ReadLine());/*O console.readline retorna sempre uma string.
                                                    O comando int.parse serve para converter esse
                                                    retorno no tipo da variável.*/
            if (t % 2 == 0)
            {
                Console.WriteLine("Número Par");
            }
            else
            {
                Console.WriteLine("Número impar");
            }
        }
    }
}
