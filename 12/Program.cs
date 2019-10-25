using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1;
            string n2;
            string n3;

            Console.WriteLine("digite o primeiro numero:  "); 
            n1= Console.ReadLine ();

             Console.WriteLine("digite o segundo numero:  "); 
            n2= Console.ReadLine ();

            Console.WriteLine("digite o terceiro numero:  "); 
            n3= Console.ReadLine ();

            if (n1.CompareTo(n2) == 0)  
                Console.WriteLine();  
            else if (n1.CompareTo(n2) < 0)  
                Console.WriteLine($"{n1} , {n2} , {n3}");  
            else if (n1.CompareTo(n2) > 0)  
                Console.WriteLine($"{n2} , {n1} , {n3}");
                 else if (n1.CompareTo(n3) > 0)  
                Console.WriteLine($"{n3} , {n1} , {n2}");
                 else if (n1.CompareTo(n3) < 0)  
                Console.WriteLine($"{n3} , {n2} , {n3}"); 
        }
    }
}

