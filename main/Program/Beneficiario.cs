using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Program {
    public class Beneficiario : Cadastro {
        public bool beneficiario;
        [AllowNull]
        public Beneficios beneficios;
        [AllowNull]
        public Rotas rota;

        public Beneficiario(string? nome, uint idade, bool beneficiario) : base(nome, idade) {
            // se não for beneficiário
            if (!beneficiario) {
                this.beneficios = null;
                char resposta = char.Parse(Console.ReadLine()!);
                if (resposta == 's')
                    AdicionarRota();
                return;
            }

            this.beneficiario = beneficiario;
            beneficios = new Beneficios();
            rota = new Rotas();

            // maracutaia funcional
            Type tipo = typeof(Beneficios);
            FieldInfo[] campos = tipo.GetFields(BindingFlags.Public | BindingFlags.Instance);

            // percorre todo o vetor 'campos'
            Console.Write($"{base.nome}\n");
            foreach (FieldInfo campo in campos) {
                Console.Write($"{campo.Name} (s/N): ");
                char resposta = char.Parse(Console.ReadLine()!);

                if (resposta == 'N' || resposta == 'n')
                    campo.SetValue(beneficios, false);
                else 
                    campo.SetValue(beneficios, true);
            }
        }

        private static void AdicionarRota() { }
    }    
}