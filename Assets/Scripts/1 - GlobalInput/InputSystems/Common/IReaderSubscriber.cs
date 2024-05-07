namespace InputSystem
{
    public interface IReaderSubscriber<T> where T : IReader
    {
        void SubscribeEvents(T reader);
    }
}