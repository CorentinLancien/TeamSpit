using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TeamSpit.Visitor
{
    public class StyleVisitor : IVisitor
    {
        public string VisitText(string text, TextComponent component)
        {
           
            if (text.Contains("*"))
            {
                text = text.Replace("*", "[bold]");
            }
            if (text.Contains("/"))
            {
                text = text.Replace("/", "[italic]");
            }

            Console.WriteLine(text);
            Console.WriteLine($"{component.GetType().Name} a été visité par {this.GetType().Name}");
            return text;
        }
    }
}
