using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    class Program
    {
        
        static void Main(string[] args) 
        {
            IBebida oBebida = new MediasDeSeda("Picante");
            Cantinero oCantinero = new Cantinero(oBebida);
            oCantinero.Preparar();
        }
    }
}
