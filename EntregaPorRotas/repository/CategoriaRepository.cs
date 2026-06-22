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

        public Categoria ObterPorId(int codigoCategoria)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoCategoria,
                                    descricao
                                FROM Categoria
                                WHERE codigoCategoria = @codigoCategoria";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigoCategoria", codigoCategoria);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Categoria categoria = new Categoria();

                            categoria.CodigoCategoria = Convert.ToInt32(reader["codigoCategoria"]);
                            categoria.Descricao = reader["descricao"].ToString();

                            return categoria;
                        }
                    }
                }
            }

            return null;
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
    }
}
