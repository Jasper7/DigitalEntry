using System;
using System.Threading.Tasks;
using DigitalEntry.Services;
using Plugin.LocalNotification;
using Xamarin.Forms;

namespace DigitalEntry.Helpers
{
    public class ScheduleHelper
    {
        public static async Task CreateChildNotification()
        {
            var service = DependencyService.Get<IPermissionService>();
            await service.RequestPermission();

            var notification = new NotificationRequest
            {
                NotificationId = 101,
                Title = "Школа №11",
                Description = "Не забудьте забрать ребенка в 18:00",
                Schedule = { NotifyTime = DateTime.Now.AddSeconds(15) }
            };
            await NotificationCenter.Current.Show(notification);

            var notification2 = new NotificationRequest
            {
                NotificationId = 102,
                Title = "Детский сад №8",
                Description = "Не забудьте забрать ребенка в 18:30",
                Schedule = { NotifyTime = DateTime.Now.AddSeconds(10) }
            };
            await NotificationCenter.Current.Show(notification2);

            var notification3 = new NotificationRequest
            {
                NotificationId = 103,
                Title = "Школа №11",
                Description = "Сегодня родительское собрание в 20:00",
                Schedule = { NotifyTime = DateTime.Now.AddSeconds(25) }
            };

            var notification4 = new NotificationRequest
            {
                NotificationId = 104,
                Title = "Школа №11",
                Description = "Предодаватель назачил встречу на 29.06.2022 в 12:00",
                Schedule = { NotifyTime = DateTime.Now.AddSeconds(30) }
            };

            await NotificationCenter.Current.Show(notification4);
        }
    }
}