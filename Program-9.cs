using System;

namespace Programa_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.Crear un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3.
            int num = 1;
            while (num < 50)
            {
                int multiplo = num % 3;
                if (multiplo==0)
                {
                    Console.WriteLine("" + num);
                };
                num++;

            }
        }
    }
}
