using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Observer
{
    public interface IObservable
    {
        public void attach(IListener listener);
        public void detach(IListener listener);
        public void alert();
    }
}
