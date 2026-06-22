using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntregaPorRotas.objetos;

namespace EntregaPorRotas.backend
{
    internal class EntregaRepository
    {
        public List<Entrega> ObterTodos()
        {
            List<Entrega> lista = new List<Entrega>();

            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoEntrega,
                                    codigoCesta,
                                    codigoBeneficiario,
                                    dataEntrega
                                FROM Entrega";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Entrega entrega = new Entrega();

                        entrega.CodigoEntrega = Convert.ToInt32(reader["codigoEntrega"]);
                        entrega.CodigoCesta = Convert.ToInt32(reader["codigoCesta"]);
                        entrega.CodigoBeneficiario = Convert.ToInt32(reader["codigoBeneficiario"]);
                        entrega.DataEntrega = Convert.ToDateTime(reader["dataEntrega"]).ToString("dd/MM/yyyy");

                        lista.Add(entrega);
                    }
                }
            }

            return lista;
        }

        public Entrega ObterPorId(int codigoEntrega)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoEntrega,
                                    codigoCesta,
                                    codigoBeneficiario,
                                    dataEntrega
                                FROM Entrega
                                WHERE codigoEntrega = @codigoEntrega";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigoEntrega", codigoEntrega);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Entrega entrega = new Entrega();

                            entrega.CodigoEntrega = Convert.ToInt32(reader["codigoEntrega"]);
                            entrega.CodigoCesta = Convert.ToInt32(reader["codigoCesta"]);
                            entrega.CodigoBeneficiario = Convert.ToInt32(reader["codigoBeneficiario"]);
                            entrega.DataEntrega = Convert.ToDateTime(reader["dataEntrega"]).ToString("dd/MM/yyyy");

                            return entrega;
                        }
                    }
                }
            }

            return null;
        }

        public Entrega ObterPorBeneficiario(int codigoBeneficiario)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT TOP 1
                                    codigoEntrega,
                                    codigoCesta,
                                    codigoBeneficiario,
                                    dataEntrega
                                FROM Entrega
                                WHERE codigoBeneficiario = @codigoBeneficiario
                                ORDER BY codigoEntrega DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigoBeneficiario", codigoBeneficiario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Entrega entrega = new Entrega();

                            entrega.CodigoEntrega = Convert.ToInt32(reader["codigoEntrega"]);
                            entrega.CodigoCesta = Convert.ToInt32(reader["codigoCesta"]);
                            entrega.CodigoBeneficiario = Convert.ToInt32(reader["codigoBeneficiario"]);
                            entrega.DataEntrega = Convert.ToDateTime(reader["dataEntrega"]).ToString("dd/MM/yyyy");

                            return entrega;
                        }
                    }
                }
            }

            return null;
        }
    }
}
