namespace Aula1405_Interfaces
{
    public interface IMeioTransporte
    {
        int Velocidade { get; set; }
        string Modelo { get; set; }
        void Acelerar();
        void Desacelerar();

        string ImprimirInfo();

    }
}
