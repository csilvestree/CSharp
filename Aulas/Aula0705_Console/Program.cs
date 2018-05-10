using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0705_Console {
    class Program {
        static void Main(string[] args) {
            string a = "aaa" ?? "a";

            Console.WriteLine($"Valor de A: { a } ");


            Console.WriteLine( Console.CapsLock ? "Ativado" : "Desativado");

            

            Console.ReadLine();
        }
    }
}
