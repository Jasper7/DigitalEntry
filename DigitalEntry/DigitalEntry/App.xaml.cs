using System;
using System.Threading.Tasks;
using DigitalEntry.Helpers;
using DigitalEntry.Services;
using DigitalEntry.Views;
using DigitalEntry.Views.Institution;
using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using Xamarin.Forms;

namespace DigitalEntry
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //MainPage = new EnterReasonPage();
            NotificationCenter.Current.NotificationTapped += OnLocalNotificationTapped;
            //MainPage = new AccessHistoryPage();

            MainPage = new UISelectPage(); // UI выбор
            //MainPage = new CodeCheckPage(); // UI охранника
            //MainPage = new AppShell(); // UI родителя
            //MainPage = new InstitutionTabbedPage(); // UI секретаря
        }

        private async void OnLocalNotificationTapped(NotificationEventArgs e)
        {
            if(e.Request.NotificationId == 101)
            {
                await Task.Delay(400);
                await MainPage.Navigation.PushModalAsync(new ShowQrCodePage("Код на вход в школу"));
            }
            else
            if (e.Request.NotificationId == 102)
            {
                await Task.Delay(400);
                await MainPage.Navigation.PushModalAsync(new ShowQrCodePage("Код на вход в детский садик"));
            }
            else
            if (e.Request.NotificationId == 103)
            {
                await Task.Delay(400);
                await MainPage.Navigation.PushModalAsync(new ShowQrCodePage("Код на родительское собрание"));
            }
        }

        protected override void OnStart ()
        {
            //ApiTest();
            //ScheduleHelper.CreateChildNotification();
        }

        private async void ApiTest()
        {
            await ApiService.GetAccessHistory();
            await ApiService.GetChilds();
            await ApiService.GetParentsForChild();
            await ApiService.CheckCode("123");
            await ApiService.GetChildsHistory();
        }

        protected override void OnSleep ()
        {

        }

        protected override void OnResume ()
        {

        }
    }
}

