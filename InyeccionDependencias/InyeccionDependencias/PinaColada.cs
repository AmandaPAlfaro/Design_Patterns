using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public class PinaColada : IBebida
    {
        public void Preparar() 
        {
            Console.WriteLine("se hace una pina colada");
        }
    }
}
