namespace Aula1405_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        //Chave para objeto marca
        public int MarcaID { get; set; }

        public string Modelo { get; set; }
        //Propiedade de navegação
        public virtual Marca _Marca { get; set; }
        public Onibus()
        {
            Velocidade = 0;
        }
        public void Acelerar()
        {
            Velocidade += 6;
        }
        public void Desacelerar()
        {
            Velocidade -= 3;
        }

        public string ImprimirInfo()
        {
            return $"Ônibus, velocidade atual: {Velocidade}";

        }
        
    }
}
