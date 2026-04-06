using System;

namespace NotificationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService service = new NotificationService();

            Notify notifyUser;

            notifyUser = service.SendEmail;
            notifyUser += service.SendSMS;
            notifyUser += service.SendWhatsApp;

            Console.WriteLine("Sending Notification to All Channels");
            notifyUser("Hello User!");

            notifyUser -= service.SendSMS;

            Console.WriteLine("\nAfter Removing SMS Channel");
            notifyUser("Hello Again!");
        }
    }
}