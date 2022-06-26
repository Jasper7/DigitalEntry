using DigitalEntry.ViewModels;
using Xamarin.Forms;

namespace DigitalEntry.Views
{
    public partial class ShowQrCodePage : ContentPage
    {
        ShowQrCodeVM vm { get; set; }

        public ShowQrCodePage(string codeValue)
        {
            InitializeComponent();

            vm = new ShowQrCodeVM();
            BindingContext = vm;

            barcode.BarcodeOptions.Width = ShowQrCodeVM.CodeSize;
            barcode.BarcodeOptions.Height = ShowQrCodeVM.CodeSize;

            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;

            barcode.BarcodeValue = codeValue;
            barcodedecode.Text = codeValue;
        }

        async void OnClose(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}