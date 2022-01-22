using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace Cadastros
{
    public static class BDConn
    {
        public static MySqlConnection Abrir()
        {
            //Cria a variável de conexão com o BD            
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=maximocontrol;password=Ale198600!");
           
            //Conecta com o BD
            conn.Open();

            return conn;
        }
    }
}
