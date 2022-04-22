using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Visitor
{
    public class Guide
    {
        public static void VisitingComponent(IComponent component, IVisitor visitor)
        {
            component.Accept(visitor);
        }
    }
}
