using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DigitalEntry.Models;
using DigitalEntry.Services;

namespace DigitalEntry.ViewModels
{
    public class AccessHistoryVM : BaseViewModel
    {
        List<AccessHistoryModel> _originalHistoryItems = new List<AccessHistoryModel>();
        ObservableCollection<AccessHistoryModel> _historyItems;
        public ObservableCollection<AccessHistoryModel> HistoryItems
        {
            get { return _historyItems; }
            set { SetProperty(ref _historyItems, value); }
        }

        public AccessHistoryVM()
        {
            HistoryItems = new ObservableCollection<AccessHistoryModel>();
            _originalHistoryItems = new List<AccessHistoryModel>();
            Init();
        }

        internal void Filter(int filterIndex)
        {
            switch(filterIndex)
            {
                case 0:
                    HistoryItems = new ObservableCollection<AccessHistoryModel>(_originalHistoryItems);
                    break;
                case 1:
                    {
                        HistoryItems.Clear();
                        foreach(var item in _originalHistoryItems)
                        {
                            if(item.IsEmergencyEntry)
                                HistoryItems.Add(item);
                        }
                    }
                    break;
                case 2:
                    {
                        HistoryItems.Clear();
                        foreach (var item in _originalHistoryItems)
                        {
                            if (item.IsSecurityForbidden)
                                HistoryItems.Add(item);
                        }
                    }
                    break;
            }
        }

        public async void Init()
        {
            //var now = DateTime.Now;

            //var list = new List<AccessHistoryModel>();
            //list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-3), "Потерял сменку"));
            //list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-3).AddHours(8), "Потерял сменку"));

            //list.Add(new AccessHistoryModel("Смирнова Анна Борисовна", now.AddDays(-2), "Срочно", isEmergencyEntry: true));
            //list.Add(new AccessHistoryModel("Смирнова Анна Борисовна", now.AddDays(-2).AddHours(8), "Нужно", isEmergencyEntry: true));

            //list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-1), "Потерял сменку"));
            //list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-1).AddHours(8), "Потерял сменку"));

            //list.Add(new AccessHistoryModel("Игнатенко Ольга Витальевна", now.AddDays(-4), "Ударился", true, true));
            //list.Add(new AccessHistoryModel("Игнатенко Ольга Витальевна", now.AddDays(-5), "Кружится голова", true, true));


            _originalHistoryItems = await ApiService.GetAccessHistory();

            HistoryItems = new ObservableCollection<AccessHistoryModel>(_originalHistoryItems.OrderByDescending(c => c.TimeEvent));

        }
    }
}