
namespace Programa {
    public class Beneficiario : Cadastro {
        public bool beneficiario;
        public List<Beneficios> beneficios;

        public Beneficiario(string? nome, uint idade, bool beneficiario) : base(nome, idade) {
            this.beneficiario = beneficiario;
            Console.WriteLine("Nº de benefícios: ");
            int N = int.Parse(Console.ReadLine());
            beneficios = new List<Beneficios>();
            for (int i = 0; i < N; i++) {
                Beneficios beneficio = new Beneficios();
                int OP;
                do {
                    Console.WriteLine("========== BENEFÍCIOS ==========");

                    List<string> lista = new List<string>();
                    lista = listar();
                    int contador = 0;
                    foreach (string S in lista) { 
                        Console.WriteLine($"{S} = {contador}");
                        contador++;
                    }

                    Console.WriteLine("================================");
                    Console.WriteLine("Sua escolha: ");
                    OP = int.Parse(Console.ReadLine());
                    switch (OP)
                    {

                    }
                } while (OP != -1);


                beneficios.Add(beneficio);
            }

        }

        static private List<string> listar() {
            string[] beneficios = { "Minha Casa, Minha Vida", "Auxílio Gás", "Bolsa Família", "Passagem Gratúita para Idosos", "BPC", "Pé de Meia", "Cisternas" };
            List<string> list = new List<string>();

            foreach (string S in beneficios) list.Add(S);
            return list;
        }
    }    
}