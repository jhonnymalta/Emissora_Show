namespace Integrations
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMessage message, string QueueName);
    }
}
