using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DigitalEntry.Views
{
    public partial class CodeSelectPage : ContentPage
    {
        public CodeSelectPage()
        {
            InitializeComponent();
        }

        async void OnClickEmergency(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new EnterReasonPage());
        }

        async void OnLostCode(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Создан новый код", "Старый код теперь недействителен и если он был утерян, то человек не сможет по нему пройти", "ОК");
        }

        void OnShowRequestCode(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new ShowQrCodePage("parent_code_id2"));
        }

        void OnShowScheduleCode(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new ShowQrCodePage("parent_code_id2"));
        }
    }
}