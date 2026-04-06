using System;

namespace NotificationSystem
{
    public delegate void Notify(string message);

    class NotificationService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }

        public void SendSMS(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }

        public void SendWhatsApp(string message)
        {
            Console.WriteLine("WhatsApp message sent: " + message);
        }
    }
}