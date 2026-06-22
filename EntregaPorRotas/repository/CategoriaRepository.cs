using EntregaPorRotas.backend;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EntregaPorRotas.repository
{
    internal class CategoriaRepository 
    {
        public List<Categoria> ObterTodos()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoCategoria,
                                    descricao
                                FROM Categoria";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria();

                        categoria.CodigoCategoria = Convert.ToInt32(reader["codigoCategoria"]);
                        categoria.Descricao = reader["descricao"].ToString();

                        lista.Add(categoria);
                    }
                }
            }
            return lista;
        }

        public void Inserir(Categoria categoria)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                INSERT INTO Categoria
                                (descricao)
                                VALUES
                                (@descricao)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@descricao", categoria.Descricao);

                    cmd.ExecuteNonQuery();
                }
            }
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
