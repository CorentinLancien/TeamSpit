using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Observer
{
    public class LogObserver : IListener
    {
        public void update(IObservable target)
        {
            Console.WriteLine("OBSERVER_UPDATE");
            Console.WriteLine(target.ToString());
        }
    }
}
