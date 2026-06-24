using EntregaPorRotas.objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public List<Entrega> ObterTodosPorBeneficiario(int codigoBeneficiario)
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
                                FROM Entrega
                                WHERE codigoBeneficiario = @CodigoBeneficiario
                                ORDER BY codigoEntrega DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CodigoBeneficiario", codigoBeneficiario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Entrega
                            {
                                CodigoEntrega = Convert.ToInt32(reader["codigoEntrega"]),
                                CodigoCesta = Convert.ToInt32(reader["codigoCesta"]),
                                CodigoBeneficiario = Convert.ToInt32(reader["codigoBeneficiario"]),
                                DataEntrega = reader["dataEntrega"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Inserir(Entrega entrega)
        {
            if (entrega == null)
            {
                throw new ArgumentNullException(nameof(entrega));
            }

            using (SqlConnection conn = Conexao.Conectar())
            {
                const string sql = @"
                                    INSERT INTO Entrega
                                    (codigoCesta,codigoBeneficiario,dataEntrega)
                                    VALUES
                                    (@CodigoCesta,@CodigoBeneficiario,@DataEntrega)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@CodigoCesta", SqlDbType.Int).Value = entrega.CodigoCesta;
                    cmd.Parameters.Add("@CodigoBeneficiario", SqlDbType.Int).Value = entrega.CodigoBeneficiario;
                    cmd.Parameters.Add("@DataEntrega", SqlDbType.Date).Value = Convert.ToDateTime(entrega.DataEntrega);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ObterEnderecoDeHoje(List<string> enderecos)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"SELECT b.endereco
                                FROM Beneficiario AS b
                                INNER JOIN Entrega e ON b.codigoBeneficiario = e.codigoBeneficiario
                                WHERE CAST(e.dataEntrega AS DATE) = CAST(GETDATE() AS DATE);";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            enderecos.Add(reader["endereco"].ToString());
                        }
                    }
                }
            }
        }
    }
}
