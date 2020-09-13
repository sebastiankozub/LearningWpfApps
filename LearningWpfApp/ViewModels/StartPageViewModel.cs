using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using LearningWpfApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningWpfApp.ViewModels
{
    public class StartPageViewModel : ViewModelBase
    {
        public StartPageViewModel()
        {
            Title = "";

            if (IsInDesignMode)
            {
                Title = "Hello Sebastian - MVVM Light (Design Mode)";
            }
            else
            {
                Title = "Hello Sebastian - MVVM Light";
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

        private RelayCommand _openMenuCommand;
        public RelayCommand OpenMenuCommand => _openMenuCommand ?? (_openMenuCommand = new RelayCommand( 
                           () =>
                           {
                               RestaurantMenuWindow NewWindowB = new RestaurantMenuWindow();
                               NewWindowB.Show();
                           }));
    }
}
