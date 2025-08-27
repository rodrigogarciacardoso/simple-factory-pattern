using Microsoft.AspNetCore.Mvc;
using simple_factory_pattern.Service;

namespace simple_factory_pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : Controller
    {
        [HttpPost]
        public IActionResult SendNotification(SendNotificationData sendNotificationData)
        {
            try
            {
                var notifier = NotificationFactory.Create(sendNotificationData.NotificationType);

                notifier.Send(sendNotificationData.Message, sendNotificationData.Recipient);

                return Ok("Notification sent successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }

        public class SendNotificationData
        {
            public string? NotificationType { get; set; }
            public string? Recipient { get; set; }
            public string? Message { get; set; }
        }
    }
}
