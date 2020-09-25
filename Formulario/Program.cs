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
            Console.WriteLine("\nEscribe tu numero de teléfono");
            numtel = Console.ReadLine();
            Console.WriteLine("\nEscribe tu correo electrónico");
            correo = Console.ReadLine();
            Console.WriteLine("\n¿Cuál es tu ocupación? ");
            ocup = Console.ReadLine();

            if (edad < 18) 
            {
                Console.WriteLine("Lo sentimos, el registro solo es permitido para mayores de edad");
                


            }
            else
            {
                Console.Write("El registro fue existoso\n\n");

                Console.WriteLine("\nTu nombre es: {0}", nom);
                Console.WriteLine("\nTu edad es: {0}", edad);
                Console.WriteLine("\nTu número de teléfono es: {0}", numtel);
                Console.WriteLine("\nTu correo electrónico es: {0}", correo);
                Console.WriteLine("\nTu ocupación es: {0, ocup);");
           
            }
        }
    }
}
