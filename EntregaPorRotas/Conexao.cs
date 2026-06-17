using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas
{
    internal class Conexao
    {
        private string conexao = "DataSource=.\\SQLEXPRESS;USER=sa;PW=123";

        public static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(stringConexao);
            conn.Open();
            return conn;
        }
    }
}
