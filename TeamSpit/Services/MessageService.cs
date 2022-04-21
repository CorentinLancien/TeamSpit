using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;
using TeamSpit.Observer;

namespace TeamSpit.Services
{
    public class MessageService : IMessageService, IObservable
    {
        private List<IListener> listeners = new List<IListener>();

        public MessageService()
        {
            Console.WriteLine("CREATION MESSAGE SERVICE");
        }

        public List<Message> findAll()
        {
            Console.WriteLine("FIND ALL MESSAGE");
            this.alert();
            return new List<Message>();
        }

        public Message findById(int id)
        {
            throw new NotImplementedException();
        }

        public void alert()
        {
            listeners.ForEach(o => o.update(this));
        }

        public void attach(IListener listener)
        {
            this.listeners.Add(listener);
        }

        public void detach(IListener listener)
        {
            this.listeners.Remove(listener);
        }
    }
}
