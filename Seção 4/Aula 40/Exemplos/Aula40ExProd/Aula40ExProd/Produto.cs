using System.Globalization;

namespace Aula40ExProd
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string Nome, double preco, int quantidade)//Construtor deve ter o mesmo nome da classe e pode ser criado quantas vezes forem necessárias.
        {
            this.Nome = Nome; // o THIS informa para o sistema que a variável Nome é a váriável desta classe,
                              // não o parâmetro que a função/método está recebendo, visto que os dois estão escritos exatamente iguais.
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
