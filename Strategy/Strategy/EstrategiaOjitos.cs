using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class EstrategiaOjitos : IBorracho
    {
        public void Conquistar() 
        {
            Console.WriteLine("Le hago ojitos a la muchacha");
        }
    }
}
