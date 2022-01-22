using System;
using System.Globalization;

namespace Aula40Ex3
{
    class Aluno
    {
        public string Nome;
        public double Nota;

        public string ProcNota()
        {
            if ((Nota / 3) >= 33.33)
            {
                return "Aprovado!";
            }
            else
            {
                return "Reprovado! Você precisa de mais " + (33.33 - (Nota / 3)).ToString("F2", CultureInfo.InvariantCulture) + " pontos para ser aprovado.";
            }
        }
    }
}
