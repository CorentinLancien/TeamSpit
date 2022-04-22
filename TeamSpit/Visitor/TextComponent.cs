using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.Visitor
{
    public class TextComponent : IComponent
    {
        private Message _message;

        public TextComponent(Message message)
        {
            _message = message;
        }
        public void Accept(IVisitor visitor)
        {
            _message.description = visitor.VisitText(_message.description, this);
        }
    }
}
