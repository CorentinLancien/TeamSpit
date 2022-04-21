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
            return new List<Message>
            {
                new Message(1, "coucou", DateTime.Now, new Utilisateur()),
                new Message(2, "bonjour", DateTime.Now, new Utilisateur()),
                new Message(3, "ça va", DateTime.Now, new Utilisateur()),
                new Message(4, "moi oui", DateTime.Now, new Utilisateur()),
                new Message(5, "ça peut aller et vous ?", DateTime.Now, new Utilisateur()),
                new Message(6, "qu'est-ce que tu as ?", DateTime.Now, new Utilisateur()),
                new Message(7, "J'ai le covid", DateTime.Now, new Utilisateur()),
                new Message(8, "t'approches pas de moi", DateTime.Now, new Utilisateur()),
                new Message(9, "moi je l'ai eu la semaine passée", DateTime.Now, new Utilisateur()),
                new Message(10, "ah super on est deux", DateTime.Now, new Utilisateur()),
                new Message(11, "bon bah je vais rester chez moi", DateTime.Now, new Utilisateur()),
                new Message(12, "bonne journée a tous", DateTime.Now, new Utilisateur()),
                new Message(13, "au revoir", DateTime.Now, new Utilisateur()),

            };
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
