using EntregaPorRotas.backend;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EntregaPorRotas.repository
{
    internal class BeneficiarioRepository
    {
        private readonly Conexao conexao = new Conexao();

        public List<Beneficiario> ObterTodos()
        {
            List<Beneficiario> lista = new List<Beneficiario>();

            using (SqlConnection conn = Conexao.Conectar())
            {
                string sql = @"SELECT
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
    }
}