using System;
using System.Collections.Generic;
using DigitalEntry.Models;
using DigitalEntry.ViewModels;
using Xamarin.Forms;

namespace DigitalEntry.Views.Institution
{
    public partial class ChildsListPage : ContentPage
    {
        ChildsListVM vm { get; set; }

        public ChildsListPage()
        {
            InitializeComponent();

            vm = new ChildsListVM();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnChildClick(System.Object sender, System.EventArgs e)
        {
            var frame = sender as Frame;
            Navigation.PushAsync(new InstitutionChildDetailsPage((ChildModel)frame.BindingContext));
        }
    }
}

