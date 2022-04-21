using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;
using TeamSpit.Services;
using TeamSpit.Singleton;

namespace TeamSpit.Proxy
{
    public class ListMessagesProxy : IList<Message>
    {
        #region Properties
        private List<Message> _messages;

        private Conversation _conversation;

        private IConversationService _conversationService = new ConversationService();

        #endregion

        #region Constructors
        public ListMessagesProxy(Conversation conversation)
        {
            this._conversation = conversation;
        }

        #endregion

        #region Getters and Setters

        public Message GetMessage(int index)
        {
            return _messages[index];
        }

        public void setMessage(int index, Message message)
        {
            this._messages[index] = message;
        }

        #endregion

        #region Methods
        // Chargement des messages de la conversation
        private void load()
        {
            if (this._messages == null)
            {
                this._messages = _conversationService.GetMessagesFromConversation(this._conversation);
            }
        }

        public bool IsReadOnly => false;

        int ICollection<Message>.Count => this.Count();

        public Message this[int index] { get => GetMessage(index); set => this.setMessage(index, value); }

        public void Add(Message item)
        {
            this.load();
            this._messages.Add(item);
        }

        public int Count()
        {
            this.load();
            return this._messages.Count();
        }

        public void Clear()
        {
            this.load();
            this._messages.Clear();
        }

        public bool Contains(Message item)
        {
            this.load();
            return this._messages.Contains(item);
        }

        public void CopyTo(Message[] array, int arrayIndex)
        {
            this.load();
            this._messages.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Message> GetEnumerator()
        {
            this.load();
            return this._messages.GetEnumerator();
        }

        public int IndexOf(Message item)
        {
            this.load();
            return this._messages.IndexOf(item);
        }

        public void Insert(int index, Message item)
        {
            this.load();
            this._messages.Insert(index, item);
        }

        public bool Remove(Message item)
        {
            this.load();
            return this._messages.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.load();
            this._messages.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            this.load();
            return this.GetEnumerator();
        }
        #endregion

    }
}
