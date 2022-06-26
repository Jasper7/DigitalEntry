using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DigitalEntry.Helpers
{
    public class PermissionHelper
    {
        public static async Task<bool> CheckCameraPermission()
        {
            try
            {
                var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
                if (status != PermissionStatus.Granted)
                {
                    var result = await Permissions.RequestAsync<Permissions.Camera>();

                    if (result == PermissionStatus.Granted)
                        return true;
                }

                if (status == PermissionStatus.Granted)
                {
                    return true;
                }
                else if (status != PermissionStatus.Unknown)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

    }
}