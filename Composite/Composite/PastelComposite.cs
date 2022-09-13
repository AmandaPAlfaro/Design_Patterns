using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class PastelComposite : Component
    {
        private List<Component> ingredientes = new List<Component>();

        public decimal CostoTotal 
        {
            get 
            {
                decimal costo = 0;
                foreach (var oElement in ingredientes) 
                {
                    if (oElement.GetType().Name == "PastelComposite")
                        costo += ((PastelComposite)oElement).CostoTotal;
                    else
                        costo += oElement.Costo;
                }
                return costo;
            }
        }

        public void Add(Component oElement) 
        {
            ingredientes.Add(oElement);
        }

        public void Remove(Component oElement) 
        {
            ingredientes.Remove(oElement);
        }

        public PastelComposite(string Nombre, decimal Costo=0) : base(Nombre, Costo)
        {

        }
    }
}
