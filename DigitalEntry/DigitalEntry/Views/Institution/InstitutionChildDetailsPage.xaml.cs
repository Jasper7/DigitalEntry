using System;
using System.Collections.Generic;
using DigitalEntry.Models;
using DigitalEntry.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DigitalEntry.Views.Institution
{
    public partial class InstitutionChildDetailsPage : ContentPage
    {
        ChildDetailsVM vm { get; set; }

        public InstitutionChildDetailsPage(ChildModel model)
        {
            InitializeComponent();

            Title = $"{model.FirstName} {model.LastName}";
            vm = new ChildDetailsVM();
            BindingContext = vm;
        }

        void OnParentClick(System.Object sender, System.EventArgs e)
        {
            var frame = sender as Frame;
            var parent = new ParentModel() { FirstName = "Дмитрий", LastName = "Васильев" };
            Navigation.PushAsync(new ParentDetailsPage(parent));
        }

        void OnParentCall(System.Object sender, System.EventArgs e)
        {
            PhoneDialer.Open("+7977-777-77-77");
        }
    }
}