using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Gato
    {
        public string Nombre { get; set; }
        public void Correr()
        {
            Console.WriteLine($"Este es un gato el cual corre rapido. Su nombre es: {Nombre}");
        }
    }
}
