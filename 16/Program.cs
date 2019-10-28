using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;


            System.Console.WriteLine("digite seu nome: ");
            nome=Console.ReadLine();
            System.Console.WriteLine("digite seu peso: ");
            double peso= double.Parse(Console.ReadLine()) ;
            System.Console.WriteLine("digite sua altura: ");
            double altura=double.Parse(Console.ReadLine());

            double imc=(peso/altura*2);
            
           if(imc<20)
           {
            System.Console.WriteLine($"{nome} abaixo do peso");
           }else if((imc ==20)&&(imc <25)){
               System.Console.WriteLine($"{nome} normal");
           }else if((imc >25)&&(imc <30)){
               System.Console.WriteLine($"{nome} exesso de peso");
           }else if((imc >30)&&(imc <35)){
               System.Console.WriteLine($"{nome} seu imc indica obesidade");
           }else if(imc >35){
               System.Console.WriteLine($"{nome} obesidade morbida");
           }else {
               System.Console.WriteLine("opção invalida");
           }
        }
    }
}

