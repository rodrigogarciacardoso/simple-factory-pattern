namespace simple_factory_pattern.Service
{
    public class SlackNotification : NotificationTypeInterface
    {
        public void Send(string? message, string? recipent)
        {
            // implement logic to send notification SLACK
        }
    }
}
