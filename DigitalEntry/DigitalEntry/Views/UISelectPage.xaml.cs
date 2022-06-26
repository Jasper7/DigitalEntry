using System;
using System.Collections.Generic;
using DigitalEntry.Views.Institution;
using Xamarin.Forms;

namespace DigitalEntry.Views
{
    public partial class UISelectPage : ContentPage
    {
        public UISelectPage()
        {
            InitializeComponent();
        }

        void UI_Guard(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new CodeCheckPage();
        }

        void UI_Parent(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new AppShell();
        }

        void UI_School(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new InstitutionTabbedPage();
        }

    }
}