using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Mediator mediator = new Mediator();
            ICollection oPepe = new User(mediator);
            ICollection oAdmin = new UserAdmin(mediator);

            mediator.Add(oPepe);
            mediator.Add(oAdmin);

            oPepe.Comunicate("Oye admin tengo un problema");
        }
    }
}