using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Animal oAnimal = new Animal() {Nombre = "Oveja", Patas = 4 };
            oAnimal.Rasgos = new Detalles();
            oAnimal.Rasgos.Color = "Blanca";
            oAnimal.Rasgos.Raza = "Oveja";

            Animal oAnimalClonado = oAnimal.Clone() as Animal;
            oAnimalClonado.Rasgos.Color = "Negro";
            oAnimalClonado.Nombre = "Oveja Negra";

            Console.WriteLine("Animal Original: " + oAnimal.Rasgos.Color);
            Console.WriteLine("Animal clonado: " + oAnimalClonado.Rasgos.Color);
            Console.WriteLine("Animal Original: " + oAnimal.Nombre);
            Console.WriteLine("Animal clonado: " + oAnimalClonado.Nombre);
        }
    }
}
