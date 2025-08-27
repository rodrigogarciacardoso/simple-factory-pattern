namespace simple_factory_pattern.Service
{
    public class NotificationFactory
    {
        public static NotificationTypeInterface Create(string? notificationType)
        {
            return notificationType switch
            {
                "email" => new EmailNotification(),
                "slack" => new SlackNotification(),
                "sms" => new SmsNotification(),
                _ => throw new ArgumentException("Invalid NotificationType")
            };
        }
    }
}
