using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Threading;
using LearningWpfApp.Views;


namespace LearningWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {            
            DispatcherHelper.Initialize();
        }


        protected override void OnLoadCompleted(NavigationEventArgs e)
        {
            base.OnLoadCompleted(e);
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                //this.DebugSettings.EnableFrameRateCounter = true;
            }

            UIElement topParent = App.Current.MainWindow;

            //topParent.RenderSize = new Size(300, 400);

            //topParent.Measure(new Size(300, 400));

            //topParent.Arrange(new Rect(500,500,300,400));

            //var desiredSize =  topParent.DesiredSize;

            topParent.RenderSize = new Size(400, 300);

            topParent.UpdateLayout();
#endif


        }
    }
}
