using System;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            int i ;
            do
            {
                int num; 
                Console.WriteLine("Introducir el numero: ");
                num = int.Parse(Console.ReadLine());
                i = num;
                suma = i + num;

                
            } while (i > 0);
            Console.WriteLine(+suma);
        }
    }
}
