using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Visitor
{
    public class ColorVisitor : IVisitor
    {

        public string VisitText(string text, TextComponent component)
        {
            foreach(char c in text)
            {
                if (c == '#')
                {
                    int index = text.IndexOf(c) + 1;
                    switch(text[index])
                    {
                        case '1':
                            text = text.Remove(index, 1);
                            text = text.Insert(index, "BLUE");
                            break;
                        case '2':
                            text = text.Remove(index, 1);
                            text = text.Insert(index, "RED");
                            break;
                        case '3':
                            text = text.Remove(index, 1);
                            text = text.Insert(index, "BLACK");
                            break;
                        case '4':
                            text = text.Remove(index, 1);
                            text = text.Insert(index, "GREEN");
                            break;
                    }
                }
            }
            Console.WriteLine($"{component.GetType().Name} a été visité par {this.GetType().Name}");

            return text;
        }
    }
}
