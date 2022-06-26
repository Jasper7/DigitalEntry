using System;
using System.Collections.Generic;
using DigitalEntry.ViewModels;
using Xamarin.Forms;

namespace DigitalEntry.Views.Institution
{
    public partial class AccessHistoryPage : ContentPage
    {
        AccessHistoryVM vm { get; set; }

        public AccessHistoryPage()
        {
            InitializeComponent();

            vm = new AccessHistoryVM();
            BindingContext = vm;
        }

        void OnChangeFilter(System.Object sender, Plugin.Segmented.Event.SegmentSelectEventArgs e)
        {
            vm.Filter(e.NewValue);
        }
    }
}

