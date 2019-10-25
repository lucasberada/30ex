using System;

namespace vvv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("variavel a:  ");
            double a=double.Parse(Console.ReadLine()) ;

            
            Console.WriteLine("variavel b");
            double b=double.Parse(Console.ReadLine()) ;

            double aa=b;
            Console.WriteLine("variavel a:"+aa);
            double bb =a;
             Console.WriteLine("variavel b:"+bb);
        }
    }
}

