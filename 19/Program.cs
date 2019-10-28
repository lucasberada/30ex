using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[];
           
             for(int cont ;cont++;){
                Console.Write("Digite um número: ");
                vetor[cont] = int.Parse(Console.ReadLine());

            }

            System.Console.WriteLine(cont);
            
        }
    }
}
