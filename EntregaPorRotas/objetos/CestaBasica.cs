using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.objetos
{
    internal class CestaBasica
    {
        private int codigoCesta;
        private int codigoCategoria;
        private int quantidade;

        public int CodigoCesta { get => codigoCesta; set => codigoCesta = value; }
        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }
        public int Quantidade { get => quantidade; set { quantidade = (value > 0) ? value : 0; } }
    }
}
