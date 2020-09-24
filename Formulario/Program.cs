using System;

namespace Formulario
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, numtel;
            int edad;
            Console.WriteLine("Escribe tu nombre completo: ");
            nom = Console.ReadLine();
            Console.WriteLine("\nEscribe tu edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEscribe tu numero de telefono");
            numtel = Console.ReadLine();

            
            if (edad < 18) 
            {
                Console.WriteLine("El registro solo es para mayores de edad");
                


            }
            else
            {
               
                
            }
        }
    }
}
