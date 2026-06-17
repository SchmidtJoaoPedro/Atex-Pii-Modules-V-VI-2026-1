using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaPorRotas.repository
{
    internal class Repository
    {
        // lista todos de uma tabela referenciada
        public DataTable ListarTodos(string tabela)
        {
            if (tabela == null || tabela = string.Empty) 
            {
                return null;
            }

            SqlConnection conn = Conexao.Conectar();
            string sql = @"SELECT * FROM @Tabela";
            SqlCommand cmd = new SqlCommand(conn, sql);
            cmd.Parameters.AddWithValue("@Tabela", tabela);
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
