using System;
using System.Collections.Generic;
using DigitalEntry.Models;
using DigitalEntry.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DigitalEntry.Views
{
    public partial class ChildDetailsPage : ContentPage
    {
        ChildDetailsVM vm { get; set; }

        public ChildDetailsPage(ChildModel model)
        {
            InitializeComponent();

            Title = $"{model.FirstName} {model.LastName}";
            vm = new ChildDetailsVM();
            BindingContext = vm;
        }

        void OnCall(System.Object sender, System.EventArgs e)
        {
            PhoneDialer.Open("+7977-777-77-77");
        }
    }
}

