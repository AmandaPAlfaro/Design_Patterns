using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Singleton.Instance.mensaje = "Hola";
            Console.WriteLine(Singleton.Instance.mensaje);
            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}