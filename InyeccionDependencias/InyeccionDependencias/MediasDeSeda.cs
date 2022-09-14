using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public class MediasDeSeda : IBebida
    {
        public string tipo { get; set; }
        public MediasDeSeda(string tipo) 
        {
            this.tipo = tipo;
        }
        public void Preparar() 
        {
            Console.WriteLine("Se hace una media de seda " + tipo);
        }
    }
}
