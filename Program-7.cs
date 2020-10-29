using System;

namespace Programa_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.Crear un programa que muestre los primeros ocho números pares 
            //(tips: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar el doble del valor que hace de contador).

            int num = 0;
            int i = 0;
            while(i<8)
            {
                num = num + 2;
                Console.WriteLine("" + num);
                i++;
            }
            Console.ReadKey();
        }
    }
}
