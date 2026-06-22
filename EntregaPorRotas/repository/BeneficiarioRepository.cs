using EntregaPorRotas.backend;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EntregaPorRotas.repository
{
    internal class BeneficiarioRepository
    {
        public List<Beneficiario> ObterTodos()
        {
            List<Beneficiario> lista = new List<Beneficiario>();

            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"
                                SELECT
                                    codigoBeneficiario,
                                    nomeBeneficiario,
                                    endereco
                                FROM Beneficiario";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Beneficiario beneficiario = new Beneficiario();

                        beneficiario.CodigoBeneficiario = Convert.ToInt32(reader["codigoBeneficiario"]);
                        beneficiario.NomeBeneficiario = reader["nomeBeneficiario"].ToString();
                        beneficiario.Endereco = reader["endereco"].ToString();

                        lista.Add(beneficiario);
                    }
                }
            }

            return lista;
        }

        public void Inserir(Beneficiario beneficiario)
        {
            using (SqlConnection conn = Conexao.Conectar())
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"
                                    INSERT INTO Beneficiario
                                    (NomeBeneficiario,Endereco)
                                    VALUES
                                    (@NomeBeneficiario,@Endereco)";

                cmd.Parameters.AddWithValue("@NomeBeneficiario", beneficiario.NomeBeneficiario);
                cmd.Parameters.AddWithValue("@Endereco", beneficiario.Endereco);

                cmd.ExecuteNonQuery();
            }
        }
    }
}