using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Adopcion
    {
        public Adopcion() { }
        public Adopcion(Mascota mascota, Persona persona) { adoptar(mascota, persona); }
        public void adoptar(Mascota mascota, Persona persona)
        {
            Console.WriteLine("Estimado: " + persona.nombre + "\nHaz adoptado a un: " + mascota.tipo);
            Console.WriteLine("Saludos.");
            Console.ReadLine();
        }
    }
}
