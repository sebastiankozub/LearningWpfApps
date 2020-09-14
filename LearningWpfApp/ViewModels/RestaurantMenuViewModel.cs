using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using LearningWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LearningWpfApp.ViewModels
{
    public class RestaurantMenuViewModel : ViewModelBase
    {
        private RestaurantMenuModel _restaurantMenuModel = new RestaurantMenuModel();
        public ObservableCollection<DishModel> RestaurantMenu { get; }
        public ObservableCollection<DishModel> SelectedDishes { get; } = new ObservableCollection<DishModel>();

        public RestaurantMenuViewModel()
        {            
            _restaurantMenuModel.RestaurantMenu.Sort((y, x) => x.CompareTo(y));
            RestaurantMenu = new ObservableCollection<DishModel>(_restaurantMenuModel.RestaurantMenu);

            Title = "";

            if (IsInDesignMode)
            {
                Title = "Hello Sebastian Restaurant - MVVM Light (Design Mode)";
            }
            else
            {
                Title = "Hello Sebastian Restaurant - MVVM Light";
            }
        }

        private int _count;
        private const string CountPropertyName = "Count";
        public int Count
        {
            get { return _count; }
            set
            {
                Set(CountPropertyName, ref _count, value);
            }
        }

        private decimal _cost;
        private const string CostPropertyName = "Cost";
        public decimal Cost
        {
            get { return _cost; }
            set
            {
                Set(CostPropertyName, ref _cost, value);
            }
        }

        private bool _isLoading = false;
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                RaisePropertyChanged("IsLoading");
            }
        }

        private string _title;
        public string Title
        {

            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    RaisePropertyChanged("Title");
                }
            }
        }

        // RELAY COMMANDS
        //
        private RelayCommand<DishModel> _addItemCommand;
        public RelayCommand<DishModel> AddItemCommand
        {
            get
            {
                return _addItemCommand ??= new RelayCommand<DishModel>(  // using compount assignment fine feature
                    (item) =>
                    {
                        SelectedDishes.Add(item);

                        Count = SelectedDishes.Count;   // should or could? be binded to SelectedDishes ListView and working automatically
                        Cost = SelectedDishes.Sum(dish => dish.Price);
                    });
            }
        }

        private RelayCommand _clearCommand;        
        public RelayCommand ClearCommand => _clearCommand ?? (_clearCommand = new RelayCommand(  // using expression body new feature
            () =>
            {
                SelectedDishes.Clear();  

                Count = 0;  // should or could? be binded to SelectedDishes ListView and working automatically
                Cost = 0;
            }));
    }
}
