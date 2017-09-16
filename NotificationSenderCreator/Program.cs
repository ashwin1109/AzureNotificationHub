using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.NotificationHubs;
namespace NotificationSenderCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            SendNotificationAsync();
            Console.ReadLine();
        }
        private static async void SendNotificationAsync()
        {
            NotificationHubClient hub = NotificationHubClient
            .CreateClientFromConnectionString("service bus connection string from azure portal", "ashwinnotificationhub");
            string toast = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            "<wp:Notification xmlns:wp=\"WPNotification\">" +
            "<wp:Toast>" +
            "<wp:Text1>Hello From Ashwin's side</wp:Text1>" +
            "</wp:Toast> " +
            "</wp:Notification>";
            await hub.SendMpnsNativeNotificationAsync(toast);
        }
    }
}
