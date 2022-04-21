using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Observer
{
    public class MessageObserver : IListener
    {
        public void update(IObservable target)
        {
            Console.WriteLine("MESSAGE ENVOYE");
        }
    }
}
