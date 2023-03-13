using DependencyIn.Services;
using DependencyIn.ViewModels;
using DependencyIn.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyIn
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            StartMain<MainViewModel>();
            base.OnStartup(e);
        }

        private void StartMain<T>() where T : ViewModelBase
        {
            Window window = new MainView();
            var viewModel = Container.GetInstance<T>();
            window.DataContext = viewModel;
            window.ShowDialog();
        }

        private void Register()
        {
            Container = new Container();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IMessenger, Messenger>();

            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<Page1ViewModel>();
            Container.RegisterSingleton<Page2ViewModel>();


            Container.Verify();
        }

    }
}
