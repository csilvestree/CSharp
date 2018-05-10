using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class Cliente
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
        public Cliente() // Construtor vazio
        {

        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }


    }
}
