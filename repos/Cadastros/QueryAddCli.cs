using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Cadastros
{
    class QueryAddCli
    {
        public static bool InsertCliente(   /*string codigo,*/ string nome, string endereco, Int32 numero, string bairro,
                                            string cidade, string estado, Int64 cep, Int64 telefone, Int64 celular,
                                            string email, Int64 cpf, string sexo )
        {
            //Cria/abre a conexão com o BD.
            MySqlConnection conn = BDConn.Abrir();
            
            //Query que será executada para inserir os dados na tabela Clientes
            string sql = "INSERT INTO clientes( nome, endereco, numero, bairro, cidade, " +
                                                "estado, cep, telefone, celular, email, cpf, sexo) " +
                                        "VALUES(@nome, @endereco, @numero, @bairro, @cidade, " +
                                                "@estado, @cep, @telefone, @celular, @email, @cpf, @sexo)";

            try
            {
                //Passa a query e a string de conexão para o banco.
                MySqlCommand comando = new MySqlCommand(sql, conn);

                //Campos para fazer insert dos dados na tabela.
                comando.Parameters.Add(new MySqlParameter("@nome", nome));
                comando.Parameters.Add(new MySqlParameter("@endereco", endereco));
                comando.Parameters.Add(new MySqlParameter("@numero", numero ));
                comando.Parameters.Add(new MySqlParameter("@bairro", bairro));
                comando.Parameters.Add(new MySqlParameter("@cidade", cidade));
                comando.Parameters.Add(new MySqlParameter("@estado", estado));
                comando.Parameters.Add(new MySqlParameter("@cep", cep));
                comando.Parameters.Add(new MySqlParameter("@telefone", telefone));
                comando.Parameters.Add(new MySqlParameter("@celular", celular));
                comando.Parameters.Add(new MySqlParameter("@email", email));
                comando.Parameters.Add(new MySqlParameter("@cpf", cpf));
                comando.Parameters.Add(new MySqlParameter("@sexo", sexo));

                //Executa o comando com os parâmetros que foram adicionados acima.
                comando.ExecuteNonQuery();

                //Finaliza a conexão com o Banco de dados.
                conn.Close();

                MessageBox.Show("O cliente " + nome.Trim() + " foi cadastrado com sucesso.",
                                "Cliente Cadastrado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("O cliente " + nome.Trim() + " não foi cadastrado.", 
                                "Cadastro não realizado", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);

                //Finaliza a conexão com o banco de dados
                conn.Close();

                return false;
            }
            finally
            {
                //Finaliza a conexão com o banco de dados
                conn.Close();

            }
        }
    }
}
