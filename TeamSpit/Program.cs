using TeamSpit.Model;
using TeamSpit.Observer;
using TeamSpit.Services;
using TeamSpit.Singleton;

DbContext context = DbContext.GetInstance();


ConversationService conversationService = new ConversationService();

List<Conversation> conversations = conversationService.findAll();

Conversation? conversation = conversations.FirstOrDefault();

if (conversation != null)
{
    List<Message> messages = conversationService.GetMessagesFromConversation(conversation);


    MessageService srvMessage = new();
    MessageObserver messageObserver = new MessageObserver();

    ((IObservable)srvMessage).attach(new LogObserver());
    ((IObservable)srvMessage).attach(messageObserver);

    srvMessage.findAll(conversations.FirstOrDefault());

    ((IObservable)srvMessage).detach(messageObserver);
    srvMessage.findAll(conversations.FirstOrDefault());
}
