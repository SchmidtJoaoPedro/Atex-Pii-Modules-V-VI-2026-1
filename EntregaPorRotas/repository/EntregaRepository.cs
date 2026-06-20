using EntregaPorRotas.objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.repository
{
    internal class EntregaRepository
    {
        private readonly SqlConnection conn = Conexao.Conectar();
        public void Insert(Entrega b)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Entrega(codigoCesta, codigoBeneficiario, dataEntrega) VALUES(@A, @B, @C);", this.conn);
            cmd.Parameters.AddWithValue("@A", b.CodigoCesta);
            cmd.Parameters.AddWithValue("@B", b.CodigoBeneficiario);
            cmd.Parameters.AddWithValue("@C", b.DataEntrega);
            cmd.ExecuteNonQuery();
        }
        public void Delete(int id)
        {
            if (id <= 0) return;

            SqlCommand cmd = new SqlCommand(@"DELETE FROM Entrega WHERE codigoEntrega = @A;", this.conn);
            cmd.Parameters.AddWithValue("@A", id);
            cmd.ExecuteNonQuery();
        }
    }
}
