using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Mediator : IMediator
    {
        private List<ICollection> collections;

        public Mediator() 
        {
            collections = new List<ICollection>();
        }

        public void Add(ICollection collection) 
        {
            this.collections.Add(collection);
        }

        public void Send(string message, ICollection collection)
        {
            foreach (var c in this.collections) 
            {
                if (collection != c) 
                {
                    collection.Receive(message);
                }
            }
        }
    }
}
