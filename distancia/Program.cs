using System;

namespace distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o tempo da viagem:  ");
            double tempo=double.Parse(Console.ReadLine()) ;
            Console.WriteLine("digite a velocidade do veiculo da viagem:  ");
            double velocidade=double.Parse(Console.ReadLine()) ;

            double distancia =tempo*velocidade;
            double lu=distancia/12;
            Console.WriteLine("o carro gastou" +lu);
            
        }
    }
}

