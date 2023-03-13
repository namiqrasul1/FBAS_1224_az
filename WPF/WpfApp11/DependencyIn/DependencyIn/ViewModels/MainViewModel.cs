using DependencyIn.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyIn.Messages;

namespace DependencyIn.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public MainViewModel(INavigationService navigationService, IMessenger messenger)
        {
            this.navigationService = navigationService;
            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
                CurrentViewModel = viewModel;
            });
        }

        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set => Set(ref currentViewModel, value);
        }

        public RelayCommand Page1Command
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<Page1ViewModel>();
            });
        }

        public RelayCommand Page2Command
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<Page2ViewModel>();
            });
        }
    }
}
