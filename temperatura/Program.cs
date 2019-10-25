using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a temperatura:  ");
            double c=double.Parse(Console.ReadLine()) ;

            double F=(9 * c + 160) / 5;
            Console.WriteLine("a temperatura comvertida é " + F);
        }
    }
}
