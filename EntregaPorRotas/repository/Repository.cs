using System.Data;
using System.Data.SqlClient;

namespace EntregaPorRotas.repository
{
    internal class Repository
    {
        // lista todos de uma tabela referenciada
        public DataTable ListarTodos(string tabela)
        {
            if (string.IsNullOrWhiteSpace(tabela))
            {
                return null;
            }

            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = $"SELECT * FROM [{tabela}]";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
