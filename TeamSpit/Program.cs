using TeamSpit.Observer;
using TeamSpit.Services;
using TeamSpit.Singleton;

DbContext context = DbContext.GetInstance();

IMessageService srvMessage = new();
MessageObserver messageObserver = new MessageObserver();

((IObservable)srvMessage).attach(new LogObserver());
((IObservable)srvMessage).attach(messageObserver);

srvMessage.findAll();

((IObservable)srvMessage).detach(messageObserver);
srvMessage.findAll();