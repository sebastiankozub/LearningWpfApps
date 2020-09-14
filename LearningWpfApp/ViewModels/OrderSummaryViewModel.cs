using LearningWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Linq;

namespace LearningWpfApp.ViewModels
{
    public class OrderSummaryViewModel : ViewModelBase
    {
        public ObservableCollection<DishModel> Positions { get; } = new ObservableCollection<DishModel>();

        private double _cost;
        private const string CostPropertyName = "Cost";
        public double Cost
        {
            get { return _cost; }
            set
            {
                Set(CostPropertyName, ref _cost, value);
            }
        }

        public OrderSummaryViewModel()
        {

        }
    }
}
