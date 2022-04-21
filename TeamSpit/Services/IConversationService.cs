using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.Services
{
    public interface IConversationService
    {
        public List<Conversation> findAll();

        public Conversation findById(int id);

        public List<Message> GetMessagesFromConversation(int id);

    }
}
