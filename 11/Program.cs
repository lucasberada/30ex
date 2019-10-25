using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;

            Console.WriteLine("digite o primeiro nome em ordem maiuscula:  "); 
            nome1= Console.ReadLine ();

             Console.WriteLine("digite o segundo nome em ordem maiuscula:  "); 
            nome2= Console.ReadLine ();

            if (nome1.CompareTo(nome2) == 0)  
                Console.WriteLine();  
            else if (nome1.CompareTo(nome2) < 0)  
                Console.WriteLine($"{nome1} , {nome2}.");  
            else if (nome1.CompareTo(nome2) > 0)  
                Console.WriteLine($"{nome2} , {nome1}."); 
        }
    }
}
