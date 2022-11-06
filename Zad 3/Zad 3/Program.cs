using System.Diagnostics.CodeAnalysis;

namespace Zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Podaj a");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b");

            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Podaj c");
            
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("Najwieksze jest " + a);
            }
            
            else if (b > a)
            
            {
                if (b > c)
                    
                    Console.WriteLine("Najwieksze jes " + b);
                
                else
                
                    Console.WriteLine("Najwieksze jest " + c);
                
                Console.ReadKey();
            }
        }
    }
}