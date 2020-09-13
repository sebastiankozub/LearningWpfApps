using System;
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

        private void OnLoaded(object sender, RoutedEventArgs e)  // breaking mvvm -should be opened by relay commands
        {
            RestaurantMenuWindow NewWindowB = new RestaurantMenuWindow();
            NewWindowB.Show();
        }

        protected override void OnInitialized(EventArgs e) // breaking mvvm -should be opened by relay commands
        {
            base.OnInitialized(e);

            RestaurantMenuWindow NewWindowB = new RestaurantMenuWindow();
            NewWindowB.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
