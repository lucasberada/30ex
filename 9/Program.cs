using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao=0;
            double mercurio=0.37;
            double venus=0.88;
            double marte=0.38;
            double jupter=2.64;
            double saturno=1.15;
            double urano=1.17;
            Console.Clear();
        

            Console.WriteLine("##############################");
            Console.WriteLine("BEM VINDO ");
            Console.WriteLine("##############################");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("entre com o peso:  ");
            int p=int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("entre com o numero do planeta:  ");
            Console.WriteLine("1-mercurio ");
            Console.WriteLine("2-venus ");
            Console.WriteLine("3-marte");
            Console.WriteLine("4-jupter");
            Console.WriteLine("5-saturno");
            Console.WriteLine("6-urano");
            opcao=int.Parse(Console.ReadLine());
Console.Clear();
            switch (opcao){
                    case 1:
                    Console.WriteLine(p/10*mercurio); 
                        break;
                    case 2:
                    Console.WriteLine(p/10*venus); ;
                        break;
                    case 3:
                        Console.WriteLine(p/10*marte); ;
                        break;
                    case 4:
                        Console.WriteLine(p/10*jupter); ;
                        break;
                    case 5:
                        Console.WriteLine(p/10*saturno); ;
                        break;
                    case 6:
                        Console.WriteLine(p/10*urano); ;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, digite uma nova opção");
                        Console.ReadLine();
                    break;
                }







        }
    }
}
