using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;
using TeamSpit.Services;
using TeamSpit.Singleton;

namespace TeamSpit.Proxy
{
    public  class ListMessagesProxy : List<Message>
    {
		private List<Message> _messages;

		private IConversationService _conversationService = new ConversationService();

		private void load(int idConversation)
		{
			if (this._messages == null)
			{
				this._messages = _conversationService.GetMessagesFromConversation(idConversation);
			}
		}

	}
}
