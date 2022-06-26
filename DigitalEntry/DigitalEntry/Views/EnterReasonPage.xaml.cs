using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DigitalEntry.Views
{
    public partial class EnterReasonPage : ContentPage
    {
        public EnterReasonPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ReasonText.Focus();
        }

        void OnSend(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new ShowQrCodePage("parent_code_id2"));
        }

        void OnClose(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

