public interface IMediator<T>
{
    void SendMessage<TMessage>(TMessage message, T colleague);
}
