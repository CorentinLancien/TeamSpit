using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.Services
{
    internal class ConversationService : IConversationService
    {
        public List<Conversation> findAll()
        {
            return new List<Conversation>()
            {
                new Conversation(1, "Ma première conversation", new List<Utilisateur>
                {
                    new Utilisateur(1,"corentin"),
                    new Utilisateur(2,"erwan")
                })
            };
        }

        public Conversation findById(int id)
        {
           return new Conversation(1, "Ma première conversation", new List<Utilisateur>
           {
                new Utilisateur(1,"corentin"),
                new Utilisateur(2,"erwan")
           });
        }


        public List<Message> GetMessagesFromConversation(Conversation conversation)
        {
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

        public List<Message> GetMessagesFromConversation(int id)
        {
            throw new NotImplementedException();
        }
    }
}
