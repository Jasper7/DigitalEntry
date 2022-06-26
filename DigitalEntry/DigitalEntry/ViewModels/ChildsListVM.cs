using System;
using System.Collections.ObjectModel;
using DigitalEntry.Models;
using DigitalEntry.Services;

namespace DigitalEntry.ViewModels
{
    public class ChildsListVM : BaseViewModel
    {
        ObservableCollection<ChildModel> _childItems;
        public ObservableCollection<ChildModel> ChildItems
        {
            get { return _childItems; }
            set { SetProperty(ref _childItems, value); }
        }

        public ChildsListVM()
        {
            Init();
        }

        public async void Init()
        {
            var childs = await ApiService.GetChilds();
            ChildItems = new ObservableCollection<ChildModel>(childs);

            //ChildItems = new ObservableCollection<ChildModel>();
            //ChildItems.Add(new ChildModel(1, "Иванов", "Иван", 7, "Школа №11", "2б класс"));
            //ChildItems.Add(new ChildModel(1, "Иванов", "Петр", 7, "Школа №11", "1а класс"));
            //ChildItems.Add(new ChildModel(1, "Петров", "Игорь", 7, "Школа №11", "1б класс"));
            //ChildItems.Add(new ChildModel(1, "Сидоров", "Василий", 7, "Школа №11", "1а класс"));
            //ChildItems.Add(new ChildModel(1, "Шумный", "Игнат", 7, "Школа №11", "2г класс"));
            //ChildItems.Add(new ChildModel(1, "Громкий", "Антон", 7, "Школа №11", "2а класс"));
            //ChildItems.Add(new ChildModel(1, "Быстрый", "Александр", 7, "Школа №11", "1в класс"));
            //ChildItems.Add(new ChildModel(1, "Высокий", "Дмитрий", 7, "Школа №11", "1а класс"));
        }
    }
}