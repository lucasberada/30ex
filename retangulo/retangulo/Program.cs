using System;

namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
    

            
                 Console.WriteLine("digite base do retangulo:  ");
                 double Base=double.Parse(Console.ReadLine()) ;

                Console.WriteLine("digite altura do retangulo:  ");
                double altura=double.Parse(Console.ReadLine());
                double area=Base*altura;
                double diagonal=Base*Base+altura*altura;
                double perimetro=Base+altura*2;
                Console.WriteLine("o perimetro do retangulo é " + perimetro);
                Console.WriteLine("a area do retangulo é " + area);
                Console.WriteLine("a diagonal do retangulo é " + diagonal);

           

        }
    }
}
