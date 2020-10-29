using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Crear un programa que dé al usuario tres oportunidades para adivinar un número del 1 al 23.

            for (int i = 0; i < 3; i++)
            {
                var ramdon = new Random().Next(0, 23);
                int num1;
                Console.WriteLine("Introducir el numero: ");
                num1 = int.Parse(Console.ReadLine());

                if (num1 == ramdon)
                {
                    Console.WriteLine("Adivino el numero");
                    i = 3;
                }else
                {
                    Console.WriteLine("No adivino el numero:");
                    
                }
            }
        
            
        }
    }
}
