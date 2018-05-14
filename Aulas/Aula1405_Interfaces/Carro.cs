using System;

namespace Aula1405_Interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }
        //Chave para objeto marca
        public int MarcaID { get; set; }

        public string Modelo { get; set; }
        //Propiedade de navegação
        public virtual Marca _Marca { get; set; }

        public Carro()
        {
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }s

        public void Desacelerar()
        {
            Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return $"Carro, velocidade atual: {Velocidade}";
        }
    }
}
