using System;

namespace ExMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamanho da Matriz:");

            Console.Write("Informe a quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de colunas: ");
            int colunas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Criaremos uma matriz com {linhas} linhas e {colunas} colunas.");

            int[,] matriz = new int[linhas, colunas];
            Console.WriteLine();
            Console.Write("Informe os valores para a Matriz:");

            for (int cntLin = 0; cntLin < linhas; cntLin++)
            {
                for (int cntCol = 0; cntCol < colunas; cntCol++)
                {
                    Console.Write($"Informe o valor que será inserido na linha {cntLin} / coluna {cntCol}:  ");
                    matriz[cntLin, cntCol] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.Write("A Matriz foi construída com a seguinda estrutura: ");

            for (int cntLin = 0; cntLin < linhas; cntLin++)
            {
                Console.WriteLine();
                for (int cntCol = 0; cntCol < colunas; cntCol++)
                {
                    Console.Write(matriz[cntLin, cntCol].ToString());
                }
            }

            Console.WriteLine();
            Console.Write("Informe qual termo deseja pesquisar:");
            int termo = int.Parse(Console.ReadLine());

            string resultado = "";

            for (int cntLin = 0; cntLin < linhas; cntLin++)
            {
                for (int cntCol = 0; cntCol < colunas; cntCol++)
                {
                    if (matriz[cntLin, cntCol] == termo)
                    {
                        if (resultado == "")
                        {
                            resultado += "O termo " + termo.ToString() +
                                        " está na linha " + cntLin.ToString() +
                                        " Coluna " + cntCol.ToString() +
                                        "." + Environment.NewLine;
                        }
                        else
                        {
                            resultado += Environment.NewLine+"Exite outro termo " + termo.ToString() +
                                        " que está na linha " + cntLin.ToString() +
                                        " Coluna " + cntCol.ToString() +
                                        "." + Environment.NewLine;
                        }

                        if (cntCol - 1 >= 0 && cntCol - 1 < colunas) //esquerda
                        {
                            resultado += "À esquerda, temos o termo " + matriz[cntLin, cntCol - 1].ToString() + Environment.NewLine;

                        }
                        if (cntCol + 1 < colunas) //direita
                        {
                            resultado += "À direita, temos o termo " + matriz[cntLin, cntCol + 1].ToString() + Environment.NewLine;
                        }
                        if (cntLin + 1 < linhas) //baixo
                        {
                            resultado += "Abaixo, temos o termo " + matriz[cntLin + 1, cntCol].ToString() + Environment.NewLine;
                        }
                        if (cntLin - 1 >= 0 && cntLin - 1 < linhas)//cima
                        {
                            resultado += "Acima, temos o termo " + matriz[cntLin - 1, cntCol].ToString() + Environment.NewLine;
                        }
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine(resultado);
            Console.WriteLine("Fim!");
        }
    }
}