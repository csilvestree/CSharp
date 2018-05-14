using System;

namespace Aula1405_Interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public Carro()
        {
            Velocidade += 10;
        }

        void IMeioTransporte.Acelerar()
        {
            throw new NotImplementedException();
        }

        void IMeioTransporte.Desacelerar()
        {
            throw new NotImplementedException();
        }
    }
}
