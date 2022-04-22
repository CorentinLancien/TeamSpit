using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Visitor
{
    public class TextComponent : IComponent
    {
        private string _text;

        public TextComponent(string text)
        {
            _text = text;
        }
        public void Accept(IVisitor visitor)
        {
            _text = visitor.VisitText(_text, this);
        }
    }
}
