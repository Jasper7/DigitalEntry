using System;
using System.Collections.Generic;
using DigitalEntry.Models;
using Xamarin.Forms;

namespace DigitalEntry.Views.Institution
{
    public partial class ParentDetailsPage : ContentPage
    {

        public ParentDetailsPage(ParentModel parent)
        {
            InitializeComponent();
            Title = $"{parent.FirstName} {parent.LastName}";
        }

        async void OnCreateMeet(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Встреча назначена", "Родителю придет уведомление, а так же разрешен доступ в школу в назначенное время", "ОК");
            await Navigation.PopAsync();
        }
    }
}