using System;
using System.Globalization;


namespace ContaBancaria
{
    class ContaBanco
    {
        private int _conta { get; }
        private string _nome;
        private double _valor;

        public ContaBanco(int conta, string nome, double valor)
        {
            _conta = conta;
            _nome = nome;
            _valor = valor;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome.Length > 1)
            {
                _nome = nome;
            }

        }

        public double GetValor()
        {
            return _valor;
        }

        public void SetValor(double valor)
        {
            _valor += valor;
        }

        public void MovimentaConta(double valor)
        {
            if(valor < 0)
            {
                SetValor(valor - 5);
            }
            else
            {
                SetValor(valor);
            }

        }
        public override string ToString()
        {
            return "Conta: " + _conta +
                    ", Titular: " + _nome +
                    ", Saldo: $ " + _valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
