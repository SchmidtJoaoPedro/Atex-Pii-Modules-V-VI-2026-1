using EntregaPorRotas.objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.backend
{
    internal class CestasBasicasRepository
    {
        public List<CestasBasicas> ObterTodos()
        {
            List<CestasBasicas> lista = new List<CestasBasicas>();

            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoCesta,
                                    codigoCategoria,
                                    quantidade
                                FROM CestasBasicas";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CestasBasicas cesta = new CestasBasicas();

                        cesta.CodigoCesta = Convert.ToInt32(reader["codigoCesta"]);
                        cesta.CodigoCategoria = Convert.ToInt32(reader["codigoCategoria"]);
                        cesta.Quantidade = Convert.ToInt32(reader["quantidade"]);

                        lista.Add(cesta);
                    }
                }
            }

            return lista;
        }

        public CestasBasicas ObterPorId(int codigoCesta)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoCesta,
                                    codigoCategoria,
                                    quantidade
                                FROM CestasBasicas
                                WHERE codigoCesta = @codigoCesta";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigoCesta", codigoCesta);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CestasBasicas cesta = new CestasBasicas();

                            cesta.CodigoCesta = Convert.ToInt32(reader["codigoCesta"]);
                            cesta.CodigoCategoria = Convert.ToInt32(reader["codigoCategoria"]);
                            cesta.Quantidade = Convert.ToInt32(reader["quantidade"]);

                            return cesta;
                        }
                    }
                }
            }

            return null;
        }

        public List<CestasBasicas> ObterPorCategoria(int codigoCategoria)
        {
            List<CestasBasicas> lista = new List<CestasBasicas>();

            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoCesta,
                                    codigoCategoria,
                                    quantidade
                                FROM CestasBasicas
                                WHERE codigoCategoria = @codigoCategoria";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigoCategoria", codigoCategoria);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CestasBasicas cesta = new CestasBasicas();

                            cesta.CodigoCesta = Convert.ToInt32(reader["codigoCesta"]);
                            cesta.CodigoCategoria = Convert.ToInt32(reader["codigoCategoria"]);
                            cesta.Quantidade = Convert.ToInt32(reader["quantidade"]);

                            lista.Add(cesta);
                        }
                    }
                }
            }

            return lista;
        }

        public void Inserir(CestasBasicas cesta)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                INSERT INTO CestasBasicas
                                (codigoCategoria,quantidade)
                                VALUES
                                (@codigoCategoria,@quantidade)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigoCategoria", cesta.CodigoCategoria);
                    cmd.Parameters.AddWithValue("@quantidade", cesta.Quantidade);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
