using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
        
            

                Console.Write("Diga um número: ");
                num = int.Parse(Console.ReadLine());

                if (num != 0){
                    if (num % 3 == 0){
                        Console.WriteLine("O número é multiplo");
                    } else {
                        Console.WriteLine("O número não é multiplo");
                    }
                }
            }
        }
    }

