using System;

namespace NotificationSystem
{
    
    public delegate void Notify(string message);

    class Program
    {
        
        public static void SendEmail(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }

        public static void SendWhatsApp(string message)
        {
            Console.WriteLine("WhatsApp message sent: " + message);
        }

        static void Main(string[] args)
        {
            
            Notify notifyUser;

            notifyUser = SendEmail;
            notifyUser += SendSMS;
            notifyUser += SendWhatsApp;

            Console.WriteLine("Sending Notification to All Channels");
            notifyUser("Hello User!");

            
            notifyUser -= SendSMS;

            Console.WriteLine("\nAfter Removing SMS Channel");
            notifyUser("Hello Again!");
        }
    }
}