using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("digite um numero"); 
            int num=int.Parse(Console.ReadLine());
            
            for(int nn =0!/2 ; nn<=num; nn+=2){
                System.Console.WriteLine(nn +"");
                
            }
        }
    }
}


