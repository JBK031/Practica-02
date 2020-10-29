using System;

namespace Programa_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).
            int i = 0;
            string[] alfabeto = {"Z","Y","X","W","V","U","T","S","R","Q","P","O","Ñ","N","M","L","K","J","I","H","G","F","E","D","C","B","A" };

            while(i<27)
            {
                Console.WriteLine(alfabeto[i]);
                i++;
                Console.ReadKey();
            }
            
        }
    }
}
