using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LearningWpfApp.Views
{
    /// <summary>
    /// Interaction logic for RestaurantMenuWindow.xaml
    /// </summary>
    public partial class RestaurantMenuWindow : Window
    {
        public RestaurantMenuWindow()
        {
            InitializeComponent();
            Loaded += LoadedHandler;
        }

        public override void EndInit()
        {
            base.EndInit();
        }

        public void LoadedHandler(object sender, RoutedEventArgs e)
        {
            var task = new Task(() => { Task.Delay(5000).Wait(); DispatcherHelper.CheckBeginInvokeOnUI(() => Indy83.Visibility = Visibility.Collapsed); });
            task.Start();
            this.Topmost = true;
            this.Show();
        }

    }
}
