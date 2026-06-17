using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.backend
{
    internal class Beneficiario
    {
        private int codigoBeneficiario;
        private string nomeBeneficiario;
        private string endereco;

        public int CodigoBeneficiario { get => codigoBeneficiario; set => codigoBeneficiario = value; }
        public string NomeBeneficiario { get => nomeBeneficiario; set => nomeBeneficiario = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
