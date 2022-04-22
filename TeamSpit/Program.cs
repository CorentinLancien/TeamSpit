using TeamSpit.Memento;
using TeamSpit.Model;
using TeamSpit.Observer;
using TeamSpit.Services;
using TeamSpit.Singleton;
using TeamSpit.State;
using TeamSpit.Visitor;


DbContext context = DbContext.GetInstance();

IComponent component = new TextComponent(new Message(1, 
    "*Atention* /je vous joins ce lien/ <l>www.coucou.com<l> #3 c'est noir", DateTime.Now, new Utilisateur()));
List<IVisitor> visitors = new List<IVisitor>
{
    new ColorVisitor(),
    new LinkVisitor(),
    new StyleVisitor(),
};

foreach(var visitor in visitors)
{
    Guide.VisitingComponent(component, visitor);
}

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

var UtilisateurActuel = new UtilisateurActuel(new Present(), new Utilisateur(1, "erwan"));
UtilisateurActuel.Deconnecte();
UtilisateurActuel.Connecte();

