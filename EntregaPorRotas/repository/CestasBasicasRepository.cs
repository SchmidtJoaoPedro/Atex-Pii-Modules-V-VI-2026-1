using EntregaPorRotas.objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.repository
{
    internal class CestasBasicasRepository
    {
        private readonly SqlConnection conn = Conexao.Conectar();
        public void Insert(CestasBasicas b)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO CestasBasicas(codigoCategoria, quantidade) VALUES(@A, @B);", this.conn);
            cmd.Parameters.AddWithValue("@A", b.CodigoCategoria);
            cmd.Parameters.AddWithValue("@B", b.Quantidade);
            cmd.ExecuteNonQuery();
        }
        public void Delete(int id)
        {
            if (id <= 0) return;

            SqlCommand cmd = new SqlCommand(@"DELETE FROM CestasBasicas WHERE codigoCesta = @A;", this.conn);
            cmd.Parameters.AddWithValue("@A", id);
            cmd.ExecuteNonQuery();
        }
    }
}
