using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.objetos
{
    internal class Entrega
    {
        private int codigoEntrega;
        private int codigoCesta;
        private int codigoBeneficiario;
        private string? dataEntrega;

        public int CodigoEntrega { get => codigoEntrega; set => codigoEntrega = value; }
        public int CodigoCesta { get => codigoCesta; set => codigoCesta = value; }
        public int CodigoBeneficiario { get => codigoBeneficiario; set => codigoBeneficiario = value; }
        public string DataEntrega { get => dataEntrega; set => (value != string.Empty) ? dataEntrega = value; : "Não informado."; }
    }
}
