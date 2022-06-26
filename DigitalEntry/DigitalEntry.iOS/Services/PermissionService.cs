using System.Threading.Tasks;
using DigitalEntry.iOS.Services;
using DigitalEntry.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PermissionService))]
namespace DigitalEntry.iOS.Services
{
    public class PermissionService : IPermissionService
    {
        public async Task<bool> RequestPermission()
        {
            return await Plugin.LocalNotification.NotificationCenter.AskPermissionAsync();
        }
    }
}