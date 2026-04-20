using System;
using System.Reflection;

namespace Program {
    internal class Program {
        static void Main(string[] argv) {
            Beneficiario B = new Beneficiario("Seu Jorge", 60, true);
            FieldInfo[] campos = typeof(Beneficios).GetFields(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("\nX =========== BENEFÍCIOS =========== X");
            foreach (FieldInfo campo in campos) {
                string checkBox = ((bool)campo.GetValue(B.beneficios)) ? "  [X] Sim [ ] Não" : "  [ ] Sim [X] Não";
                Console.WriteLine($"{campo.Name}: {checkBox}");
            }
            Console.WriteLine("X ================================== X");
        }
    }    
}