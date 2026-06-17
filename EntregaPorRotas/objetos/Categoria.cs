using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaPorRotas.backend
{
    internal class Categoria
    {
        private int codigoCategoria;
        private string descricao;

        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
