﻿using System;

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
            Console.WriteLine(cli2.Nome);


            Cliente cli3 = new Cliente("Juciliuda", "123"); //nome, cpf

            Console.ReadKey();
        }
    }
}
