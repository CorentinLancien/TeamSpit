using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Visitor
{
    public class LinkVisitor : IVisitor
    {
        public string VisitText(string text, TextComponent component)
        {
            if (text.Contains("<l>"))
            {
                text = text.Replace("<l>", "[link]");
            }
            Console.WriteLine($"{component.GetType().Name} a été visité par {this.GetType().Name}");

            return text;
        }
    }
}
