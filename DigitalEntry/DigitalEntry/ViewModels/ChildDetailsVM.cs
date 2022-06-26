using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DigitalEntry.Models;
using DigitalEntry.Services;

namespace DigitalEntry.ViewModels
{
    public class ChildDetailsVM : BaseViewModel
    {

        ParentModel _parent1;
        public ParentModel Parent1
        {
            get { return _parent1; }
            set { SetProperty(ref _parent1, value); }
        }

        ParentModel _parent2;
        public ParentModel Parent2
        {
            get { return _parent2; }
            set { SetProperty(ref _parent2, value); }
        }

        ObservableCollection<EnterHistoryModel> _historyItems;
        public ObservableCollection<EnterHistoryModel> HistoryItems
        {
            get { return _historyItems; }
            set { SetProperty(ref _historyItems, value); }
        }

        public ChildDetailsVM()
        {
            Init();
        }

        public async void Init()
        {
            var parents = await ApiService.GetParentsForChild();
            var list = await ApiService.GetChildsHistory();

            Parent1 = parents.First();
            Parent2 = parents.Last();

            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-3)));
            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-3).AddHours(8), true));
            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-2)));
            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-2).AddHours(8), true));
            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-1)));
            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-1).AddHours(8), true));
            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-4)));
            //list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-4).AddHours(8), true));

            HistoryItems = new ObservableCollection<EnterHistoryModel>(list.OrderByDescending(c => c.TimeEvent));
        }
    }
}

