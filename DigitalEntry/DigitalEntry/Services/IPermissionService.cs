using System.Threading.Tasks;

namespace DigitalEntry.Services
{
    public interface IPermissionService
    {
        public Task<bool> RequestPermission();
    }
}