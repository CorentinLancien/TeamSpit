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
            throw new NotImplementedException();
        }

        public List<Message> GetMessagesFromConversation(Conversation conversation)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessagesFromConversation(int id)
        {
            throw new NotImplementedException();
        }
    }
}
