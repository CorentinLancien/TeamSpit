using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Visitor
{
    public interface IVisitor
    {
        string VisitText(string text, TextComponent component);

    }

}
