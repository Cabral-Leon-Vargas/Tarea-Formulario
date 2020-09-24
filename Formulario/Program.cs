using System;

namespace Formulario
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, numtel, correo, ocup;
            int edad, rep;
            Console.WriteLine("Escribe tu nombre completo: ");
            nom = Console.ReadLine();
            Console.WriteLine("\nEscribe tu edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEscribe tu numero de telefono");
            numtel = Console.ReadLine();
            Console.WriteLine("\nEscribe tu correo electronico");
            correo = Console.ReadLine();
            Console.WriteLine("\n¿Cuál es tu ocupación?");
            ocup = Console.ReadLine();
            
            if (edad < 18) 
            {
                Console.WriteLine("El registro solo es para mayores de edad");
                


            }
            else
            {
                Console.WriteLine("El registro fue exitoso\n\n");

                Console.WriteLine("\nTu nombre es: {0}", nom);
                Console.WriteLine("\nTu edad es: {0}", edad);
                Console.WriteLine("\nTu numero de telefono es: {0}", numtel );
                Console.WriteLine("\nTu correoelectronico es: {0}", correo);
                Console.WriteLine("\nTu ocupación es: {0}", ocup);
                
            }
        }
    }
}
