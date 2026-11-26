class Polymorf 
{
    class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Email notification sent");
        }
    }

    class SMSNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("SMS notification sent");
        }
    }

    class DiscordNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Discord notification sent");
        }
    }

    class TelegramNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Telegram notification sent");
        }
    }
    interface INotification
    {
        void Send();
    }

    static void Notify(INotification notification)
    {
        notification.Send();
    }

    static void Main(string[] args)
    {
        Notify(new EmailNotification());
        Notify(new SMSNotification());
        Notify(new DiscordNotification());
        Notify(new TelegramNotification());
        Order order = new Order(new EmailNotification());
        Order order2 = new Order(new SMSNotification());
        order2.Finish();
        order.Finish();
    }
    class Order
    {
        private INotification notification;

        public Order(INotification notification)
        {
            this.notification = notification;
        }

        public void Finish()
        {
            notification.Send();
        }
    }

}