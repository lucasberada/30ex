using System;

namespace parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("digite o numero:  ");
             double N=double.Parse(Console.ReadLine()) ;

            if (N != 0){
                    if (N % 2 == 0){
                        Console.WriteLine("O número é par");
                    } else {
                        Console.WriteLine("O número é impar");
                    }
                }

            }
        }
    }


