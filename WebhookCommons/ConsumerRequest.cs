namespace WebhookCommons;

public class ConsumerRequest
{
    
    
}

public class ConsumerResponse
{
    
}

public interface IWebhookBroker:IDisposable
{
   void Publish<T>(object source, T message) where T : new ();
   void Subscribe<T>(object source, Action<T> subscription) where T : new ();
   void Unsubscribe<T>( Action<T> subscription) where T : new ();
}
