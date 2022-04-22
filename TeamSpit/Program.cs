using TeamSpit.Memento;
using TeamSpit.Model;
using TeamSpit.Observer;
using TeamSpit.Services;
using TeamSpit.Singleton;

// Récupération de l'instance
DbContext context = DbContext.GetInstance();

ConversationService conversationService = new ConversationService();
UtilisateurService utilisateurService = new UtilisateurService();

List<Conversation> conversations = conversationService.findAll();
Conversation? conversation = conversations.FirstOrDefault();

Utilisateur utilisateur;

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

    conversation.attach(new MementoManager());
    conversation.addMessage(new Message(15, "test", DateTime.Now, new Utilisateur(3, "admin")));
}












