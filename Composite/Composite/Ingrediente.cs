using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Ingrediente : Component
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
        public Ingrediente(string Nombre, decimal Costo, int cantidad, string unidad) : base(Nombre, Costo)
        {
            Cantidad = cantidad;
            Unidad = unidad;
        }
    }
}
