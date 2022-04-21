using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Observer
{
    public interface IListener
    {
        public void update(IObservable target);
    }
}
