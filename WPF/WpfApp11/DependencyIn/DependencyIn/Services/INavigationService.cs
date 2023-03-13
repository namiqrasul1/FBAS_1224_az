using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyIn.Services
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : ViewModelBase;
    }
}
