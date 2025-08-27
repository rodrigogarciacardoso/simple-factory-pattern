namespace simple_factory_pattern.Service
{
    public class EmailNotification : NotificationTypeInterface
    {
        public void Send(string? message, string? recipent)
        {
            // implement logic to send notification EMAIL
        }
    }
}
