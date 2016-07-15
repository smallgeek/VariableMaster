using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VariableMaster.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private int _rate;
        public int Rate
        {
            get { return _rate; }
            set { SetProperty(ref _rate, value); }
        }

        public MainPageViewModel()
        {
            this.Rate = 40;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}


