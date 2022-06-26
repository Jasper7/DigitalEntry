using System;
using System.Threading.Tasks;
using DigitalEntry.Services;

namespace DigitalEntry.ViewModels
{
    public class CodeCheckVM : BaseViewModel
    {
        bool _isDeny = false;
        public bool IsDeny
        {
            get { return _isDeny; }
            set { SetProperty(ref _isDeny, value); }
        }
        bool _isApprove = false;
        public bool IsApprove
        {
            get { return _isApprove; }
            set { SetProperty(ref _isApprove, value); }
        }

        public CodeCheckVM()
        {

        }

        internal async Task<bool> DetectCode(string code)
        {
            IsBusy = true;

            var result = await ApiService.CheckCode(code);
            await Task.Delay(500);

            IsApprove = result;
            IsDeny = !result;

            IsBusy = false;

            return result;
        }
    }
}