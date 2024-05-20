using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Jaguar : Animal
    {
        public void Correr()
        {
            Console.WriteLine($"El {TipoAnimal} corre a una velocidad de {Velocidad} km/h.");
        }
    }
}
