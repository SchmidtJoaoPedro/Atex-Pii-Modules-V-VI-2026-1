using System.Diagnostics.CodeAnalysis;

namespace Program {
    public class Rotas {
        public string? rua;
        public string? bairro;
        public uint NCasa;
        [AllowNull]
        public string complemento;
    }
}