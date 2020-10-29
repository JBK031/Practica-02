using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Crea un programa que escriba en pantalla los números del 1 al 10, "while". 
            int num = 1;

            while (num < 11)
            {
                Console.WriteLine("" + num);
                num++;
            }
            Console.ReadKey();
        }
    }
}
