using EntregaPorRotas.objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.backend
{
    internal class CestaBasicaRepository
    {
        public List<CestaBasica> ObterTodos()
        {
            List<CestaBasica> lista = new List<CestaBasica>();

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
                        CestaBasica cesta = new CestaBasica();

                        cesta.CodigoCesta = Convert.ToInt32(reader["codigoCesta"]);
                        cesta.CodigoCategoria = Convert.ToInt32(reader["codigoCategoria"]);
                        cesta.Quantidade = Convert.ToInt32(reader["quantidade"]);

                        lista.Add(cesta);
                    }
                }
            }

            return lista;
        }

        public CestaBasica ObterPorId(int codigoCesta)
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
                            CestaBasica cesta = new CestaBasica();

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

        public List<CestaBasica> ObterPorCategoria(int codigoCategoria)
        {
            List<CestaBasica> lista = new List<CestaBasica>();

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
                            CestaBasica cesta = new CestaBasica();

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

        public void Inserir(CestaBasica cesta)
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
