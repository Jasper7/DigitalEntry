using System;
using System.ComponentModel;
using DigitalEntry.Models;
using DigitalEntry.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalEntry.Views
{
    public partial class MainPage : ContentPage
    {
        MainViewModel vm { get; set; }

        public MainPage()
        {
            InitializeComponent();

            vm = new MainViewModel();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.Init();
        }

        void OnShowCode(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new ShowQrCodePage("code entry"));
        }

        void OnChildClick(System.Object sender, System.EventArgs e)
        {
            var frame = sender as Frame;
            Navigation.PushAsync(new ChildDetailsPage((ChildModel)frame.BindingContext));
        }
    }
}