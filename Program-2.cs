using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).
            int num;
            int cifras;
            Console.WriteLine("Introducir el numero: ");
            num = int.Parse(Console.ReadLine());

            int i=0;

            while (i < num)
            {
                num = num / 10;
                ++i;
                
            }
            Console.WriteLine("" + i);
        }
    }
}
