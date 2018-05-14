using System;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();

            Console.WriteLine($"Velocidade inicial: {car.Velocidade}");
            car.Acelerar();
            car.Acelerar();
            car.Desacelerar();
            Console.WriteLine($"Velocidade atual: {car.Velocidade}");

            Onibus oni = new Onibus();
            Console.WriteLine($"Velocidade inicial: {oni.Velocidade}");
            oni.Acelerar();
            oni.Desacelerar();
            Console.WriteLine($"Velocidade atual: {oni.Velocidade}");


            AcelerarBastante(car);
            Console.WriteLine(car.ImprimirInfo());

            AcelerarBastante(oni);
            Console.WriteLine(oni.ImprimirInfo());

            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for(int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }

        static void CriarRelacionamento()
        {
            Carro c = new Carro();
            c.Modelo = "Corsa";

            Marca m = new Marca();
            m.Nome = "Chevrolet";

            c._Marca = m;

            Onibus o = new Onibus();
            o.Modelo = "3100";

            o._Marca = m;
        }

    }
}
