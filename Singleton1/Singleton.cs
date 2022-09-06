using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string mensaje = "";

        protected Singleton() 
        {
            mensaje = "Hola Mundo";
        }

        public static Singleton Instance 
        {
            get 
            {
                if (Instance == null)
                    instance = new Singleton { };
                return instance;
            }
        }
    }
}
