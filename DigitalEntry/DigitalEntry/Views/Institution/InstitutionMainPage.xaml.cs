using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DigitalEntry.Views.Institution
{
    public partial class InstitutionMainPage : ContentPage
    {
        public InstitutionMainPage()
        {
            InitializeComponent();
        }

        void OnSave(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Сохранено", null, "ОК");
        }
    }
}

