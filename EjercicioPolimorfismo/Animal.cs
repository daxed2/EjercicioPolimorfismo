using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Animal
    {
        public string TipoAnimal { get; set; }
        public int Velocidad { get; set; }


        public void Correr()
        {
            Console.WriteLine($"{TipoAnimal} corre a {Velocidad} km/h.");
        }

        public void Correr(string Nombre)
        {
            Console.WriteLine($"Ese animal se llama {Nombre} y es de tipo {TipoAnimal} el cual corre a {Velocidad} km/h.");
        }
    }
}
