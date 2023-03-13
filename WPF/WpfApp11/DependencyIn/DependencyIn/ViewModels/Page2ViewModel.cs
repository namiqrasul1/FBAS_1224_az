using DependencyIn.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyIn.ViewModels
{
    public class Page2ViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;
        private readonly IMessenger messenger;

        public Page2ViewModel(INavigationService navigationService, IMessenger messenger)
        {
            this.navigationService = navigationService;
            this.messenger = messenger;
        }
    }
}
