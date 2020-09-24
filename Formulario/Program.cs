using System;

namespace Formulario
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, numtel,correo,ocup;
            int edad;
            Console.WriteLine("Escribe tu nombre completo: ");
            nom = Console.ReadLine();
            Console.WriteLine("\nEscribe tu edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEscribe tu numero de telefono");
            numtel = Console.ReadLine();
            Console.WriteLine("\nEscribe tu correo electronico");
            correo = Console.ReadLine();
            Console.WriteLine("\n¿Cuál es tu ocupación? ");
            ocup = Console.ReadLine();

            if (edad < 18) 
            {
                Console.WriteLine("Lo sentimos, El registro solo es permitido para mayores de edad");
                


            }
            else
            {
                Console.Write("El registro fue existoso\n\n");
                
            }
        }
    }
}
