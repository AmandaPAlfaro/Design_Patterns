using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class VinoTinto : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagoPorHora()
        {
            return 20;
        }
    }
}
