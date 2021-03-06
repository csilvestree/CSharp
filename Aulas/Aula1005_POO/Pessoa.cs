﻿namespace Aula1005_POO
{
   public abstract class Pessoa
    {
        //Atributo
        private string nome;

        //Propriedades
        public string Cpf { get; set; }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        // Construtores
        public Pessoa() // Construtor vazio
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
