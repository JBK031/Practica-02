using System;

namespace Programa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10.Crear un programa que pregunte al usuario su edad y su año de nacimiento. 
            Si la edad que introduce no es un número válido, mostrará un mensaje de aviso, pero aun así le preguntará su año de nacimiento.*/

            int edad;
            int nacimiento;
            
            int vali;

            Console.WriteLine("Introducir el año de nacimiento");
            nacimiento = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Introducir su edad:");
                edad = int.Parse(Console.ReadLine());
                vali = 2020 - edad;
                if (nacimiento!=vali)
                {
                    Console.WriteLine("No coincide el año de nacimiento y la edad");

                }else
                {
                    Console.WriteLine("Todo bien");
                }
            } while (vali == nacimiento);
        }
    }
}
