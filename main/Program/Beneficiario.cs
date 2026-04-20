using System;
using System.Reflection;

namespace Program {
    public class Beneficiario : Cadastro {
        public bool beneficiario;
        public Beneficios? beneficios;

        public Beneficiario(string? nome, uint idade, bool beneficiario) : base(nome, idade) {
            this.beneficiario = beneficiario;
            if (!beneficiario) return;
            
            beneficios = new Beneficios();

            // maracutaia funcional
            Type tipo = typeof(Beneficios);
            FieldInfo[] campos = tipo.GetFields(BindingFlags.Public | BindingFlags.Instance);

            // percorre todo o vetor 'campos'
            Console.Write("\n");
            foreach (FieldInfo campo in campos) {
                Console.Write($"{campo.Name} (s/N): ");
                char resposta = char.Parse(Console.ReadLine()!);

                if (resposta == 'N' || resposta == 'n')
                    campo.SetValue(beneficios, false);
                else 
                    campo.SetValue(beneficios, true);
            }
        }
    }    
}