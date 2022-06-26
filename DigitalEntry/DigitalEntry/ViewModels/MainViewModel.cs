using DigitalEntry.Models;
using DigitalEntry.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DigitalEntry.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        ObservableCollection<ChildModel> _childItems;
        public ObservableCollection<ChildModel> ChildItems
        {
            get { return _childItems; }
            set { SetProperty(ref _childItems, value); }
        }
        
        public MainViewModel()
        {
            Init();
        }

        public void Init()
        {
            ChildItems = new ObservableCollection<ChildModel>();
            ChildItems.Add(new ChildModel(1, "Иванов", "Иван", 7, "Школа №11", "1б класс"));
            ChildItems.Add(new ChildModel(1, "Иванов", "Петр", 7, "Детский сад №8", "6 группа"));
        }
    }
}