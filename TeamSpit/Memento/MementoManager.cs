using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;
using TeamSpit.Observer;

namespace TeamSpit.Memento
{
    public class MementoManager : IListener
	{
		private ArrayList messageMementos = new ArrayList();
		private int currentMessageIndex = -1;

		public void add(Message message)
		{
            if (this.messageMementos[message.getId()] == null)
            {
				this.messageMementos[message.getId()] = new List<MessageMemento>();
			}

			List<MessageMemento> mementos = (List<MessageMemento>) this.messageMementos[message.getId()];

			while (mementos.Count() - 1 > currentMessageIndex)
			{
				mementos.RemoveAt(mementos.Count() - 1);
			}

			mementos.Add(new MessageMemento(message));
			currentMessageIndex++;

			if (mementos.Count() > 15)
			{
				mementos.RemoveAt(0);
			}
		}

		public void previous(Message message)
		{
			if (this.messageMementos[message.getId()] == null)
			{
				List<MessageMemento> mementos = (List<MessageMemento>)this.messageMementos[message.getId()];

                Console.WriteLine("Message précédent");
				mementos[--currentMessageIndex].restore(message);
			}
		}

		public void next(Message message)
		{
			if (this.messageMementos[message.getId()] == null)
			{
				List<MessageMemento> mementos = (List<MessageMemento>)this.messageMementos[message.getId()];

				if (mementos.Count() - 2 >= currentMessageIndex)
				{
					Console.WriteLine("Message suivant");
					mementos[++currentMessageIndex].restore(message);
				}
			}
		}

        public void update(IObservable target)
		{
			Conversation conversation = target as Conversation;
			Message message = conversation.getMessages().LastOrDefault();

			if (message == null)
				this.add(message);
        }
    }
}
