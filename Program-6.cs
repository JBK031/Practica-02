using System;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6.Crea un programa que pida al usuario su cedula y su contraseña (ambos numéricos), 
            y no le permita seguir hasta que introduzca como cedula "00113764530" y como contraseña "1823".*/

            int cedula = 00113764530;
            int contra = 1823;
            int cedu;
            int con;

            
            
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Introducir su cedula:");
                    cedu = int.Parse(Console.ReadLine());
                    if (cedu == cedula)
                    {
                        Console.WriteLine("Introducir la contraseña:");
                        con = int.Parse(Console.ReadLine());
                        if (con == contra)
                        {
                            Console.WriteLine("Bienvenido");
                        }
                        else
                        {
                            Console.WriteLine("Incorrecto");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");

                    }

                }
                
            
        }
    }
}
