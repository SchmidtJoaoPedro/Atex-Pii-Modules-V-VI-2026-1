using System.Data.SqlClient;

namespace EntregaPorRotas
{
    internal class Conexao
    {
        private static readonly string stringConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=bancoPII;User ID=sa;Password=123;TrustServerCertificate=True";

        public static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(stringConexao);
            conn.Open();
            return conn;
        }
    }
}