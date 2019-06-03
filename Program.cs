using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Mascota mascota = new Mascota();
            string respuesta;

            Console.WriteLine("¿Cúal es tu nombre?");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("¿Que tipo de macota buscas?");
            mascota.tipo = Console.ReadLine();
            Console.WriteLine("Quieres adoptarlo? Si/No");
            respuesta = Console.ReadLine();
            Adopcion adopcion = new Adopcion(mascota, persona);
        }
    }
}
