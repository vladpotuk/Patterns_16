public interface IMediator<T>
{
    void SendMessage(string message, T colleague);
}
