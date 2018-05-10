using System;

namespace Aula1005_POO
{
    class Program {
        static void Main(string[] args) 
        {
            Cliente cli = new Cliente();
            cli.Nome = "Godofredo"; // set
            string nomeCliente = cli.Nome; //get

            cli.Cpf = "10402872999"; //get
            string cpfCliente = cli.Cpf; //set

            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.Cpf);


            // Utilizando os construtores parametrizados
            Cliente cli2 = new Cliente("Jucicreia"); //nome
            Console.WriteLine("cli2.nome: " + cli2.Nome);


            Cliente cli3 = new Cliente("Juciliuda", "123"); //nome, cpf
            Console.WriteLine("cli3.nome: " + cli3.Nome + " cli3.cpf: " + cli3.Cpf);
            cli3.DataNasc = new DateTime(1999, 05, 05);
            Console.WriteLine($"{ cli3.Nome } Tem { cli3.Idade } anos");
            //Pessoa p = new Pessoa(); // ERRO: classes abstratas não podem ser instanciadas

            Console.ReadKey();
        }
    }
}
