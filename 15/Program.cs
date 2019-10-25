using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao =0;

        do{
            System.Console.WriteLine("digite o numero do mes ");
            opcao=int.Parse(Console.ReadLine());
            

                    switch (opcao){
                    case 1:
                    Console.WriteLine("janeiro"); 
                        break;
                    case 2:
                    Console.WriteLine("fevereiro"); 
                        break;
                    case 3:
                        Console.WriteLine("março"); 
                        break;
                    case 4:
                        Console.WriteLine("abril"); 
                        break;
                    case 5:
                        Console.WriteLine("maio"); 
                        break;
                    case 6:
                        Console.WriteLine("junho"); 
                        break;
                        case 7:
                        Console.WriteLine("julho"); 
                        break;
                        case 8:
                        Console.WriteLine("agosto"); 
                        break;
                        case 9:
                        Console.WriteLine("setembro"); 
                        break;
                        case 10:
                        Console.WriteLine("outubro"); 
                        break;
                        case 11:
                        Console.WriteLine("novembro");
                        break;
                        case 12:
                        Console.WriteLine("dezembro"); 
                        break;
                       
                    default:
                        Console.WriteLine("nao existe esse mes ,precione qualquer tecla ");
                        Console.ReadLine();
                    break;
                }
        }while (opcao>12);

        
        }

    }
}
