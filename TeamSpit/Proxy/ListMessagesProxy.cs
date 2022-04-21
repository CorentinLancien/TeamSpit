using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;
using TeamSpit.Singleton;

namespace TeamSpit.Proxy
{
    public  class ListMessagesProxy : List<Message>
    {
		private List<Message> _messages;

		private void load()
		{
			if (this._messages == null)
			{
				this._messages = DbContext.GetInstance().GetMessagesFromConversation();
			}
		}

	}
}
