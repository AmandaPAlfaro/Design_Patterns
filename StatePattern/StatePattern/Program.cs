using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args) 
        {
            ServidorContext oServidor = new ServidorContext();
            oServidor.State = new DisponibleServer();

            oServidor.AnterSolicitud();

            oServidor.State = new SaturadoServerState();
            oServidor.AnterSolicitud();
            oServidor.AnterSolicitud();

            oServidor.State = new SuperSaturadoServerState();
            oServidor.AnterSolicitud();
            oServidor.AnterSolicitud();

            oServidor.State = new CaidoServerState();
            oServidor.AnterSolicitud();
            oServidor.AnterSolicitud();

            oServidor.State = new DisponibleServer();
            oServidor.AnterSolicitud();
            oServidor.AnterSolicitud();
        }
    }
}
