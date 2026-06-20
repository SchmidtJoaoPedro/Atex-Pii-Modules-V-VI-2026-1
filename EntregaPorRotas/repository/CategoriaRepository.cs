using EntregaPorRotas.backend;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.repository
{
    internal class CategoriaRepository 
    {
        private readonly SqlConnection conn = Conexao.Conectar();
        public void Insert(Categoria b)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Categoria(descricao) VALUES(@A);", this.conn);
            cmd.Parameters.AddWithValue("@A", b.Descricao);
            cmd.ExecuteNonQuery();
        }
        public void Delete(int id)
        {
            if (id <= 0) return;

            SqlCommand cmd = new SqlCommand(@"DELETE FROM Categoria WHERE codigoCategoria = @A;", this.conn);
            cmd.Parameters.AddWithValue("@A", id);
            cmd.ExecuteNonQuery();
        }
    }
}
