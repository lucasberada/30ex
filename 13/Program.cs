using System;

namespace _13
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


            if ((n1==n2) && (n1==n3) &&(n2==n3) )
                Console.WriteLine("é um triangulo equilatero");  
            else if ((n1!=n2) && (n1!=n3) && (n2!=n3) )
                Console.WriteLine("é um triangulo escaleno");
                else {
                    System.Console.WriteLine("este triaguulo e um isoceles");
                }
            
        
        }
    }
}


