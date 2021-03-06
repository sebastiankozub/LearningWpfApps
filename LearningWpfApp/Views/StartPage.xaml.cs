﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningWpfApp.Views
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)  // breaking mvvm -should be opened by relay commands - just to test more methods of new UIElement creation
        {
            RestaurantMenuWindow NewWindowB = new RestaurantMenuWindow();
            NewWindowB.Show();

            //this.Parent...
        }

        protected override void OnInitialized(EventArgs e) // breaking mvvm -should be opened by relay commands - just to test more methods of new UIElement creation
        {
            base.OnInitialized(e);

            RestaurantMenuWindow NewWindowB = new RestaurantMenuWindow();
            NewWindowB.Show();
        }
    }
}
