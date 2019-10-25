using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {   string verbo; 

            System.Console.WriteLine("digite seu verbo no infinitivo:  ");
            verbo=Console.ReadLine();

            if(verbo.EndsWith ("ar")){
                System.Console.WriteLine("o Verbo da 1ª- conjugação");
            }else if(verbo.EndsWith ("er")){
                System.Console.WriteLine("Verbo da 2ª- conjugação");
            }else if(verbo.EndsWith("ir")){
                System.Console.WriteLine("verbo da 3ª- conjugação.");
            }else{
                System.Console.WriteLine("Verbo não está no infinitivo.");
            }
            
        }
    }
}
